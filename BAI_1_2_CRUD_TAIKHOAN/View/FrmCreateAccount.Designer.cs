
namespace BAI_1_2_CRUD_TAIKHOAN
{
    partial class frmDangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bblTK = new System.Windows.Forms.Label();
            this.gbDK = new System.Windows.Forms.GroupBox();
            this.lblShowpass = new System.Windows.Forms.Label();
            this.btnMKtusinh = new System.Windows.Forms.Button();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.lblNamSinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.rdSexNu = new System.Windows.Forms.RadioButton();
            this.rdSexNam = new System.Windows.Forms.RadioButton();
            this.lblMK2 = new System.Windows.Forms.Label();
            this.lblMK = new System.Windows.Forms.Label();
            this.txtMK2 = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.gbDK.SuspendLayout();
            this.SuspendLayout();
            // 
            // bblTK
            // 
            this.bblTK.AutoSize = true;
            this.bblTK.Location = new System.Drawing.Point(19, 41);
            this.bblTK.Name = "bblTK";
            this.bblTK.Size = new System.Drawing.Size(80, 20);
            this.bblTK.TabIndex = 0;
            this.bblTK.Text = "Tài Khoản";
            // 
            // gbDK
            // 
            this.gbDK.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbDK.Controls.Add(this.lblShowpass);
            this.gbDK.Controls.Add(this.btnMKtusinh);
            this.gbDK.Controls.Add(this.cboYear);
            this.gbDK.Controls.Add(this.lblNamSinh);
            this.gbDK.Controls.Add(this.lblGioiTinh);
            this.gbDK.Controls.Add(this.rdSexNu);
            this.gbDK.Controls.Add(this.rdSexNam);
            this.gbDK.Controls.Add(this.lblMK2);
            this.gbDK.Controls.Add(this.lblMK);
            this.gbDK.Controls.Add(this.txtMK2);
            this.gbDK.Controls.Add(this.txtMK);
            this.gbDK.Controls.Add(this.txtTK);
            this.gbDK.Controls.Add(this.bblTK);
            this.gbDK.Location = new System.Drawing.Point(28, 35);
            this.gbDK.Name = "gbDK";
            this.gbDK.Size = new System.Drawing.Size(345, 281);
            this.gbDK.TabIndex = 1;
            this.gbDK.TabStop = false;
            this.gbDK.Text = "Đăng Ký";
            // 
            // lblShowpass
            // 
            this.lblShowpass.AutoSize = true;
            this.lblShowpass.BackColor = System.Drawing.SystemColors.Info;
            this.lblShowpass.Location = new System.Drawing.Point(23, 233);
            this.lblShowpass.Name = "lblShowpass";
            this.lblShowpass.Size = new System.Drawing.Size(81, 20);
            this.lblShowpass.TabIndex = 6;
            this.lblShowpass.Text = "showPass";
            this.lblShowpass.MouseLeave += new System.EventHandler(this.lblShowpass_MouseLeave);
            this.lblShowpass.MouseHover += new System.EventHandler(this.lblShowpass_MouseHover);
            // 
            // btnMKtusinh
            // 
            this.btnMKtusinh.Location = new System.Drawing.Point(134, 223);
            this.btnMKtusinh.Name = "btnMKtusinh";
            this.btnMKtusinh.Size = new System.Drawing.Size(194, 41);
            this.btnMKtusinh.TabIndex = 7;
            this.btnMKtusinh.Text = "mật khẩu tự sinh";
            this.btnMKtusinh.UseVisualStyleBackColor = true;
            this.btnMKtusinh.Click += new System.EventHandler(this.btnMKtusinh_Click);
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(134, 188);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(194, 28);
            this.cboYear.TabIndex = 5;
            // 
            // lblNamSinh
            // 
            this.lblNamSinh.AutoSize = true;
            this.lblNamSinh.Location = new System.Drawing.Point(23, 188);
            this.lblNamSinh.Name = "lblNamSinh";
            this.lblNamSinh.Size = new System.Drawing.Size(78, 20);
            this.lblNamSinh.TabIndex = 6;
            this.lblNamSinh.Text = "Năm Sinh";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(23, 153);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(71, 20);
            this.lblGioiTinh.TabIndex = 5;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // rdSexNu
            // 
            this.rdSexNu.AutoSize = true;
            this.rdSexNu.Location = new System.Drawing.Point(274, 149);
            this.rdSexNu.Name = "rdSexNu";
            this.rdSexNu.Size = new System.Drawing.Size(54, 24);
            this.rdSexNu.TabIndex = 4;
            this.rdSexNu.TabStop = true;
            this.rdSexNu.Text = "Nữ";
            this.rdSexNu.UseVisualStyleBackColor = true;
            // 
            // rdSexNam
            // 
            this.rdSexNam.AutoSize = true;
            this.rdSexNam.Location = new System.Drawing.Point(134, 149);
            this.rdSexNam.Name = "rdSexNam";
            this.rdSexNam.Size = new System.Drawing.Size(67, 24);
            this.rdSexNam.TabIndex = 3;
            this.rdSexNam.TabStop = true;
            this.rdSexNam.Text = "Nam";
            this.rdSexNam.UseVisualStyleBackColor = true;
            // 
            // lblMK2
            // 
            this.lblMK2.AutoSize = true;
            this.lblMK2.Location = new System.Drawing.Point(23, 114);
            this.lblMK2.Name = "lblMK2";
            this.lblMK2.Size = new System.Drawing.Size(104, 20);
            this.lblMK2.TabIndex = 2;
            this.lblMK2.Text = "Xác nhận MK";
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Location = new System.Drawing.Point(23, 76);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(77, 20);
            this.lblMK.TabIndex = 2;
            this.lblMK.Text = "Mật Khẩu";
            // 
            // txtMK2
            // 
            this.txtMK2.Location = new System.Drawing.Point(134, 111);
            this.txtMK2.Name = "txtMK2";
            this.txtMK2.PasswordChar = '*';
            this.txtMK2.Size = new System.Drawing.Size(194, 26);
            this.txtMK2.TabIndex = 2;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(134, 73);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(194, 26);
            this.txtMK.TabIndex = 1;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(134, 35);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(194, 26);
            this.txtTK.TabIndex = 0;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(251, 322);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(122, 40);
            this.btnDangKy.TabIndex = 9;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(28, 322);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(110, 40);
            this.btnDangNhap.TabIndex = 8;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(400, 375);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.gbDK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Ký";
            this.gbDK.ResumeLayout(false);
            this.gbDK.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label bblTK;
        private System.Windows.Forms.GroupBox gbDK;
        private System.Windows.Forms.RadioButton rdSexNu;
        private System.Windows.Forms.RadioButton rdSexNam;
        private System.Windows.Forms.Label lblMK2;
        private System.Windows.Forms.Label lblMK;
        private System.Windows.Forms.TextBox txtMK2;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label lblNamSinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnMKtusinh;
        private System.Windows.Forms.Label lblShowpass;
    }
}

