using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAI_1_2_CRUD_TAIKHOAN.IServices;
using BAI_1_2_CRUD_TAIKHOAN.View;
using BAI_1_2_CRUD_TAIKHOAN.Services;

namespace BAI_1_2_CRUD_TAIKHOAN
{
    public partial class frmDangKy : Form
    {
        private IServices.IServices _ISVAccount = new ServicesAccount();
        private IFileServices _IFileSV = new ServicesFile();
        private string path = @"C:\Users\le van luu\Documents\C#3\frm1_buoi1\BAI_1_2_CRUD_TAIKHOAN\DATA\FileDataAccount.bin";
        private List<Account> _lstAccounts = new List<Account>();
        public frmDangKy()
        {
            InitializeComponent();
            loadYear();// load list value year into combobox year 'cboYear'
            cboYear.SelectedIndex = 20;// selected value have index = 20
            _lstAccounts = _IFileSV.openList<Account>(path); // set value for list accounts 
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
        }
        private void lblShowpass_MouseLeave(object sender, EventArgs e)// hide password
        {
            txtMK.PasswordChar = '*';
        }
        #endregion

        #region button funtion
        // button Login click
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            FrmDangNhap dangNhap = new FrmDangNhap();
            dangNhap.Show();
            this.Hide();
        }
        // button sign in click 
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            _lstAccounts.Add(resultAccount());
            _IFileSV.saveList(path, _lstAccounts);
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.takeAcc(txtTK.Text);
            frmDangNhap.Show();
            this.Hide();
        } 
        #endregion

        #region Form validate
        // check informations account in the form
        bool checkAcc()
        {
            //
            // check text
            //
            #region check form and add account
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
            acc.Status = false;
            return acc;
        }
        #endregion

    }
}
