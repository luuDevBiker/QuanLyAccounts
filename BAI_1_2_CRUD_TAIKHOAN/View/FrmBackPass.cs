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
    public partial class FrmBackPass : Form
    {
        private IServices.IServices _ISVAccount = new ServicesAccount();
        private IFileServices _IFileSV = new ServicesFile();
        private string path = @"C:\Users\le van luu\Documents\C#3\frm1_buoi1\BAI_1_2_CRUD_TAIKHOAN\DATA\FileDataAccount.bin";
        private List<Account> _lstAccounts = new List<Account>();
        public FrmBackPass()
        {
            InitializeComponent();
            _lstAccounts = _IFileSV.openList<Account>(path);
            loadYear();// set items for combobox
            cboYearTim.SelectedIndex = 20;
            grbDatLaiMatKhau.Hide();
        }
        //
        // form load
        //
        public void loadYear()
        {
            for (int i = 1980; i < 2021; i++)// value of year start with 1980 and end with 2021
            {
                // add items to combobox
                cboYearTim.Items.Add(i);
            }
        }
        // button find click
        private void btnTim_Click(object sender, EventArgs e)
        {
            _lstAccounts.ForEach(x =>
            {
                if (x.Acc == txtTKTim.Text &&
                    x.YearofBirth == int.Parse(cboYearTim.Text) &&
                    x.Sex == (cboSexTim.Text == "Nam" ? 0 : 1))
                {
                    txtTkReset.Text = txtTKTim.Text;
                    grbDatLaiMatKhau.Show();
                    grbTimTaiKhoan.Hide();
                }
            });
        }
        // button update click
        private void btnSua_Click(object sender, EventArgs e)
        {
            int index = _ISVAccount.findAccount(txtTkReset.Text, _lstAccounts);
            _lstAccounts[index].Pass = txtMK1.Text;
            _IFileSV.saveList(path,_lstAccounts);
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.takeAcc(txtTkReset.Text);
            frmDangNhap.Show();
            this.Hide();
        }
        // button close form click
        private void FrmBackPass_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.Show();
            this.Hide();
        }
        // validate form
        bool checkValueForm()
        {
            if (txtMK1.Text != txtMK2.Text)
            {
                MessageBox.Show("Mật khẩu không khớp.");
                return false;
            }

            if (txtMK1.Text.Length < 6)
            {
                MessageBox.Show("Mật Khẩu phải lớn hơn 5 ký tự.");
                return false;
            }

            return true;
        }
    }
}
