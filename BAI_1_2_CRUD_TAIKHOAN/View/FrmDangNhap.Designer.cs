
namespace BAI_1_2_CRUD_TAIKHOAN.View
{
    partial class FrmDangNhap
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
            this.pbDangNhap = new System.Windows.Forms.GroupBox();
            this.llDangKy = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblMK = new System.Windows.Forms.Label();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.lblTK = new System.Windows.Forms.Label();
            this.pbDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbDangNhap
            // 
            this.pbDangNhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbDangNhap.Controls.Add(this.llDangKy);
            this.pbDangNhap.Controls.Add(this.linkLabel1);
            this.pbDangNhap.Controls.Add(this.btnDangNhap);
            this.pbDangNhap.Controls.Add(this.txtPass);
            this.pbDangNhap.Controls.Add(this.lblMK);
            this.pbDangNhap.Controls.Add(this.txtAcc);
            this.pbDangNhap.Controls.Add(this.lblTK);
            this.pbDangNhap.Location = new System.Drawing.Point(18, 15);
            this.pbDangNhap.Name = "pbDangNhap";
            this.pbDangNhap.Size = new System.Drawing.Size(354, 337);
            this.pbDangNhap.TabIndex = 1;
            this.pbDangNhap.TabStop = false;
            this.pbDangNhap.Text = "Đăng Nhập";
            // 
            // llDangKy
            // 
            this.llDangKy.AutoSize = true;
            this.llDangKy.Location = new System.Drawing.Point(198, 224);
            this.llDangKy.Name = "llDangKy";
            this.llDangKy.Size = new System.Drawing.Size(69, 20);
            this.llDangKy.TabIndex = 4;
            this.llDangKy.TabStop = true;
            this.llDangKy.Text = "Đăng Ký";
            this.llDangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llDangKy_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(198, 177);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(118, 20);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Quên mật khẩu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(202, 264);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(127, 32);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(139, 98);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(190, 26);
            this.txtPass.TabIndex = 1;
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Location = new System.Drawing.Point(22, 101);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(77, 20);
            this.lblMK.TabIndex = 0;
            this.lblMK.Text = "Mật Khẩu";
            // 
            // txtAcc
            // 
            this.txtAcc.Location = new System.Drawing.Point(139, 44);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Size = new System.Drawing.Size(190, 26);
            this.txtAcc.TabIndex = 0;
            // 
            // lblTK
            // 
            this.lblTK.AutoSize = true;
            this.lblTK.Location = new System.Drawing.Point(22, 47);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(80, 20);
            this.lblTK.TabIndex = 0;
            this.lblTK.Text = "Tài Khoản";
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(388, 364);
            this.Controls.Add(this.pbDangNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDangNhap_FormClosing);
            this.pbDangNhap.ResumeLayout(false);
            this.pbDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pbDangNhap;
        private System.Windows.Forms.LinkLabel llDangKy;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblMK;
        private System.Windows.Forms.TextBox txtAcc;
        private System.Windows.Forms.Label lblTK;
    }
}