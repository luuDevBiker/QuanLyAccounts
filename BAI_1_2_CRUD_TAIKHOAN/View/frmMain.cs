using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAI_1_2_CRUD_TAIKHOAN.IServices;
using BAI_1_2_CRUD_TAIKHOAN.Services;

namespace BAI_1_2_CRUD_TAIKHOAN.View
{
    public partial class frmMain : Form
    {
        private IServices.IServices _ISVAccount = new ServicesAccount();
        private IFileServices _IFileSV = new ServicesFile();
        private List<Account> _lstAccounts = new List<Account>();
        private bool _status = false;
        private string path =
            @"C:\Users\le van luu\Documents\C#3\frm1_buoi1\BAI_1_2_CRUD_TAIKHOAN\DATA\FileDataAccount.bin";
        public frmMain()
        {
            InitializeComponent();
            loadYear();// set list items year for combobox year birth
            cboYear.SelectedIndex = 20; // value selectedindex default = 20 
            _lstAccounts = _IFileSV.openList<Account>(path);// set value for _lstAccounts
            // hide button update and remove wait datagridview click take value for form
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }
        #region Form load
        // add list items into combobox 'cboYear'
        public void loadYear()
        {
            for (int i = 1980; i < 2021; i++)// value of year start with 1980 and end with 2021
            {
                // add items to combobox
                cboYear.Items.Add(i);
            }
        }
        // random Password and set value for textbox password
        private void btnMKtusinh_Click(object sender, EventArgs e)//create string password have lengh = 10 
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";//String char for random password

            var random = new Random();
            // set string password random none repeat have length equals 6
            var randomString = new string(Enumerable.Repeat(chars, 6)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            // set value for textbox
            txtMK.Text = randomString;
            txtMK2.Text = randomString;
        }
        //
        // hide and show password
        //
        private void lblShowpass_MouseHover(object sender, EventArgs e)// show password
        {
            txtMK.PasswordChar = '\0';
            txtMK2.PasswordChar = '\0';
        }
        private void lblShowpass_MouseLeave(object sender, EventArgs e)// hide password
        {
            txtMK.PasswordChar = '*';
            txtMK2.PasswordChar = '*';
        } 
        // set value from label UserName
        public void setUser(string acc)
        {
            lblUser.Text = acc;
        }
        // take value account from gatagridview 
        private void dgvAccount_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // set textbox property readonly and unhide button remove , update 
            txtTK.ReadOnly = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAccount.Rows[e.RowIndex];
                txtTK.Text = row.Cells[1].Value.ToString();
                txtMK.Text = txtMK2.Text = row.Cells[2].Value.ToString();
                if (int.Parse(row.Cells[3].Value.ToString()) == 0)
                {
                    rdSexNam.Checked = true;
                }
                else
                {
                    rdSexNu.Checked = true;
                }
                cboYear.Text = row.Cells[4].Value.ToString();
                if (bool.Parse(row.Cells[5].Value.ToString()) == false)
                {
                    rdOff.Checked = true;
                }
                else
                {
                    rdOn.Checked = true;
                }
            }
        }
        // reset value form
        void resetFormMain()
        {
            dgvAccount.DataSource = null;
            txtTK.ReadOnly = false;
            txtTK.Text = txtMK.Text = txtMK2.Text = default;
            rdSexNam.Checked = rdSexNu.Checked = rdOn.Checked = rdOff.Checked = default;
            dgvAccount.DataSource = _lstAccounts;
            // hide button remove and update
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        #endregion

        #region MenuStrip
        //button save data editting in the menustrip "File" ==> Save list accounts from file data
        private void saveDataEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _IFileSV.saveList(path, _lstAccounts);
        }
        // button Load data accounts in the menustrip "File" ==> set datasoure from datagridview accounts
        private void loadDataAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvAccount.DataSource = _lstAccounts;
        }
        //button exit in the menustrip "File" => exit program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion

        #region Form button method
        // button add accounts
        private void btnThem_Click(object sender, EventArgs e)
        {
            _status = true;
            if (checkAcc() == false)
            {
                return;
            }
            _ISVAccount.addAccount(resultAccount(), _lstAccounts);
            resetFormMain();
        }
        // button update click
        private void btnSua_Click(object sender, EventArgs e)
        {
            _status = true;
            int index = _ISVAccount.findAccount(txtTK.Text, _lstAccounts);
            _lstAccounts[index].Pass = txtMK.Text;
            _lstAccounts[index].Sex = rdSexNam.Checked == true ? 0 : 1;
            _lstAccounts[index].YearofBirth = int.Parse(cboYear.Text);
            _lstAccounts[index].Status = rdOn.Checked == true ? true : false;
            resetFormMain();
        }
        // button remove click
        private void btnXoa_Click(object sender, EventArgs e)
        {
            _status = true;
            int index = _ISVAccount.findAccount(txtTK.Text, _lstAccounts);
            _lstAccounts.RemoveAt(index);
            resetFormMain();
        }
        // button clear click 
        private void btnClear_Click(object sender, EventArgs e)
        {
            resetFormMain();
        }
        //  button Find click
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvAccount.DataSource = default;
            var listAcc = _lstAccounts.Where(x => x.Acc.StartsWith(txtTimKiem.Text));
            dgvAccount.DataSource = listAcc.ToList();
        }
        // close button click
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_status == true)
            {
                DialogResult dgl;
                dgl = MessageBox.Show(
                    "Lưu file thay đổi ? ",
                    "Thôn báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (dgl == DialogResult.Yes)
                {
                    _IFileSV.saveList(path, _lstAccounts);
                }
            }
        }
        #endregion

        #region Form validate
        // check informations account in the form
        bool checkAcc()
        {
            bool status = false;
            //
            // check text
            //
            #region check form and add account
            _lstAccounts.ForEach(z =>
            {
                if (z.Acc == txtTK.Text)
                {
                    MessageBox.Show("Tài khoản đã tồn tại.", "Thông báo.");
                    status = true;
                    return;
                }
            });
            if (status == true)
            {
                return false;
            }
            // check length of Account and Password with a length greater than 6
            if (txtTK.Text.Length < 6 || txtMK.Text.Length < 6)
            {
                MessageBox.Show("Tài khoản phải lớn hơn 8 ký tự \n Mật khẩu phải lớn hơn 8 ký tự.");
                return false;
            }
            // check duplication of password with confilm password
            if (txtMK.Text != txtMK2.Text)
            {
                MessageBox.Show("Mật khẩu không khớp");
                return false;
            }
            // check status radio sex
            if (rdSexNam.Checked == false && rdSexNu.Checked == false)
            {
                MessageBox.Show("Chưa chọn giới tính .");
                return false;
            }
            #endregion

            return true;
        }
        // result accuont with information in the form createaacuont
        Account resultAccount()
        {
            Account acc = new Account();
            acc.Id = _lstAccounts.Count + 1;
            acc.Acc = txtTK.Text;
            acc.Pass = txtMK.Text;
            acc.Sex = rdSexNam.Checked == true ? 0 : 1;
            acc.YearofBirth = Convert.ToInt32(cboYear.Text);
            acc.Status = rdOn.Checked == true ? true : rdOff.Checked == false ? false : false;
            return acc;
        }




        #endregion

    }
}
