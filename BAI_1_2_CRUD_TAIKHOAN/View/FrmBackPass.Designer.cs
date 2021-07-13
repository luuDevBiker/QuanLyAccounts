
namespace BAI_1_2_CRUD_TAIKHOAN.View
{
    partial class FrmBackPass
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
            this.grbTimTaiKhoan = new System.Windows.Forms.GroupBox();
            this.grbDatLaiMatKhau = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtMK2 = new System.Windows.Forms.TextBox();
            this.txtMK1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTkReset = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboSexTim = new System.Windows.Forms.ComboBox();
            this.cboYearTim = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTKTim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbTimTaiKhoan.SuspendLayout();
            this.grbDatLaiMatKhau.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTimTaiKhoan
            // 
            this.grbTimTaiKhoan.Controls.Add(this.cboSexTim);
            this.grbTimTaiKhoan.Controls.Add(this.cboYearTim);
            this.grbTimTaiKhoan.Controls.Add(this.btnTim);
            this.grbTimTaiKhoan.Controls.Add(this.txtTKTim);
            this.grbTimTaiKhoan.Controls.Add(this.label3);
            this.grbTimTaiKhoan.Controls.Add(this.label2);
            this.grbTimTaiKhoan.Controls.Add(this.label1);
            this.grbTimTaiKhoan.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbTimTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.grbTimTaiKhoan.Name = "grbTimTaiKhoan";
            this.grbTimTaiKhoan.Size = new System.Drawing.Size(378, 236);
            this.grbTimTaiKhoan.TabIndex = 0;
            this.grbTimTaiKhoan.TabStop = false;
            this.grbTimTaiKhoan.Text = "Tìm tài khoản";
            // 
            // grbDatLaiMatKhau
            // 
            this.grbDatLaiMatKhau.Controls.Add(this.btnSua);
            this.grbDatLaiMatKhau.Controls.Add(this.txtMK2);
            this.grbDatLaiMatKhau.Controls.Add(this.txtMK1);
            this.grbDatLaiMatKhau.Controls.Add(this.label5);
            this.grbDatLaiMatKhau.Controls.Add(this.txtTkReset);
            this.grbDatLaiMatKhau.Controls.Add(this.label4);
            this.grbDatLaiMatKhau.Controls.Add(this.label6);
            this.grbDatLaiMatKhau.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbDatLaiMatKhau.Location = new System.Drawing.Point(378, 0);
            this.grbDatLaiMatKhau.Name = "grbDatLaiMatKhau";
            this.grbDatLaiMatKhau.Size = new System.Drawing.Size(378, 236);
            this.grbDatLaiMatKhau.TabIndex = 1;
            this.grbDatLaiMatKhau.TabStop = false;
            this.grbDatLaiMatKhau.Text = "Đặt lại mật khẩu";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(274, 182);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 32);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtMK2
            // 
            this.txtMK2.Location = new System.Drawing.Point(135, 126);
            this.txtMK2.Name = "txtMK2";
            this.txtMK2.Size = new System.Drawing.Size(214, 26);
            this.txtMK2.TabIndex = 3;
            // 
            // txtMK1
            // 
            this.txtMK1.Location = new System.Drawing.Point(135, 81);
            this.txtMK1.Name = "txtMK1";
            this.txtMK1.Size = new System.Drawing.Size(214, 26);
            this.txtMK1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "N.lại Mật khẩu";
            // 
            // txtTkReset
            // 
            this.txtTkReset.Location = new System.Drawing.Point(135, 37);
            this.txtTkReset.Name = "txtTkReset";
            this.txtTkReset.Size = new System.Drawing.Size(214, 26);
            this.txtTkReset.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mật khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên tài khoản";
            // 
            // cboSexTim
            // 
            this.cboSexTim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexTim.FormattingEnabled = true;
            this.cboSexTim.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboSexTim.Location = new System.Drawing.Point(135, 126);
            this.cboSexTim.Name = "cboSexTim";
            this.cboSexTim.Size = new System.Drawing.Size(214, 28);
            this.cboSexTim.TabIndex = 3;
            // 
            // cboYearTim
            // 
            this.cboYearTim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYearTim.FormattingEnabled = true;
            this.cboYearTim.Location = new System.Drawing.Point(135, 81);
            this.cboYearTim.Name = "cboYearTim";
            this.cboYearTim.Size = new System.Drawing.Size(214, 28);
            this.cboYearTim.TabIndex = 2;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(274, 182);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 32);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTKTim
            // 
            this.txtTKTim.Location = new System.Drawing.Point(135, 37);
            this.txtTKTim.Name = "txtTKTim";
            this.txtTKTim.Size = new System.Drawing.Size(214, 26);
            this.txtTKTim.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 100;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 100;
            this.label2.Text = "Năm sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 100;
            this.label1.Text = "Tên tài khoản";
            // 
            // FrmBackPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(382, 236);
            this.Controls.Add(this.grbDatLaiMatKhau);
            this.Controls.Add(this.grbTimTaiKhoan);
            this.Name = "FrmBackPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt Lại Mật Khẩu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBackPass_FormClosing);
            this.grbTimTaiKhoan.ResumeLayout(false);
            this.grbTimTaiKhoan.PerformLayout();
            this.grbDatLaiMatKhau.ResumeLayout(false);
            this.grbDatLaiMatKhau.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTimTaiKhoan;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTKTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboYearTim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbDatLaiMatKhau;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtMK1;
        private System.Windows.Forms.TextBox txtTkReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMK2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSexTim;
    }
}