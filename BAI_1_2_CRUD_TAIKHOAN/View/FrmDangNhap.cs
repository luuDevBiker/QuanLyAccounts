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
    public partial class FrmDangNhap : Form
    {
        private IServices.IServices _ISVAccount = new ServicesAccount();
        private IFileServices _IFileSV = new ServicesFile();
        private string path = @"C:\Users\le van luu\Documents\C#3\frm1_buoi1\BAI_1_2_CRUD_TAIKHOAN\DATA\FileDataAccount.bin";
        private List<Account> _lstAccounts = new List<Account>();
        public FrmDangNhap()
        {
            InitializeComponent();
            _lstAccounts = _IFileSV.openList<Account>(path);
        }

        #region Form load function
        // take value for textbos account in to from form create account
        public void takeAcc(string acc)
        {
            txtAcc.Text = acc;
        }
        #endregion

        #region button funtions
        // button Login click 
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            bool status = false;
            // check account in the list accounts
            _lstAccounts.ForEach(x =>
            {
                if (x.Acc == txtAcc.Text && x.Pass == txtPass.Text)
                {
                    frmMain frmMain = new frmMain();
                    frmMain.setUser(txtAcc.Text);// sender username from frmmain (form Main)
                    frmMain.Show();
                    this.Hide();
                    status = true;
                }
            });
            if (status == false)
            {
                MessageBox.Show(
                    "Tài khoản hoặc mật khẩu không chính xác .",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        // button sigin click
        private void llDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangKy frmDangKy = new frmDangKy();
            frmDangKy.Show();
            this.Hide();
            return;
        }
        // button forgot password click
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBackPass frmBackPass = new FrmBackPass();
            frmBackPass.Show();
            this.Hide();
            return;
        }
        #endregion

        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
