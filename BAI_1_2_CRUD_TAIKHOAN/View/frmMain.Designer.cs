
using System.Windows.Forms;

namespace BAI_1_2_CRUD_TAIKHOAN.View
{
    partial class frmMain
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
            this.gbcontain = new System.Windows.Forms.GroupBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.grbCN = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbTK = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdOff = new System.Windows.Forms.RadioButton();
            this.rdOn = new System.Windows.Forms.RadioButton();
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
            this.bblTK = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDataAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.pnTimkiem = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.gbcontain.SuspendLayout();
            this.grbCN.SuspendLayout();
            this.grbTK.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.pnTimkiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbcontain
            // 
            this.gbcontain.Controls.Add(this.lblUser);
            this.gbcontain.Controls.Add(this.grbCN);
            this.gbcontain.Controls.Add(this.grbTK);
            this.gbcontain.Controls.Add(this.menuStrip1);
            this.gbcontain.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbcontain.Location = new System.Drawing.Point(0, 0);
            this.gbcontain.Name = "gbcontain";
            this.gbcontain.Size = new System.Drawing.Size(618, 401);
            this.gbcontain.TabIndex = 1;
            this.gbcontain.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.SystemColors.Info;
            this.lblUser.Location = new System.Drawing.Point(502, 29);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 20);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User";
            // 
            // grbCN
            // 
            this.grbCN.Controls.Add(this.btnClear);
            this.grbCN.Controls.Add(this.btnXoa);
            this.grbCN.Controls.Add(this.btnSua);
            this.grbCN.Controls.Add(this.btnThem);
            this.grbCN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbCN.Location = new System.Drawing.Point(342, 55);
            this.grbCN.Name = "grbCN";
            this.grbCN.Size = new System.Drawing.Size(273, 343);
            this.grbCN.TabIndex = 1;
            this.grbCN.TabStop = false;
            this.grbCN.Text = "Chức Năng";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(40, 199);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 31);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(40, 144);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(40, 89);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 31);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(40, 36);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 31);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grbTK
            // 
            this.grbTK.Controls.Add(this.groupBox2);
            this.grbTK.Controls.Add(this.lblShowpass);
            this.grbTK.Controls.Add(this.btnMKtusinh);
            this.grbTK.Controls.Add(this.cboYear);
            this.grbTK.Controls.Add(this.lblNamSinh);
            this.grbTK.Controls.Add(this.lblGioiTinh);
            this.grbTK.Controls.Add(this.rdSexNu);
            this.grbTK.Controls.Add(this.rdSexNam);
            this.grbTK.Controls.Add(this.lblMK2);
            this.grbTK.Controls.Add(this.lblMK);
            this.grbTK.Controls.Add(this.txtMK2);
            this.grbTK.Controls.Add(this.txtMK);
            this.grbTK.Controls.Add(this.txtTK);
            this.grbTK.Controls.Add(this.bblTK);
            this.grbTK.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbTK.Location = new System.Drawing.Point(3, 55);
            this.grbTK.Name = "grbTK";
            this.grbTK.Size = new System.Drawing.Size(339, 343);
            this.grbTK.TabIndex = 0;
            this.grbTK.TabStop = false;
            this.grbTK.Text = "Tài Khoản";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdOff);
            this.groupBox2.Controls.Add(this.rdOn);
            this.groupBox2.Location = new System.Drawing.Point(7, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 63);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trạng Thái";
            // 
            // rdOff
            // 
            this.rdOff.AutoSize = true;
            this.rdOff.Location = new System.Drawing.Point(235, 29);
            this.rdOff.Name = "rdOff";
            this.rdOff.Size = new System.Drawing.Size(56, 24);
            this.rdOff.TabIndex = 28;
            this.rdOff.TabStop = true;
            this.rdOff.Text = "Off";
            this.rdOff.UseVisualStyleBackColor = true;
            // 
            // rdOn
            // 
            this.rdOn.AutoSize = true;
            this.rdOn.Location = new System.Drawing.Point(117, 29);
            this.rdOn.Name = "rdOn";
            this.rdOn.Size = new System.Drawing.Size(55, 24);
            this.rdOn.TabIndex = 27;
            this.rdOn.TabStop = true;
            this.rdOn.Text = "On";
            this.rdOn.UseVisualStyleBackColor = true;
            // 
            // lblShowpass
            // 
            this.lblShowpass.AutoSize = true;
            this.lblShowpass.BackColor = System.Drawing.SystemColors.Info;
            this.lblShowpass.Location = new System.Drawing.Point(201, 295);
            this.lblShowpass.Name = "lblShowpass";
            this.lblShowpass.Size = new System.Drawing.Size(81, 20);
            this.lblShowpass.TabIndex = 18;
            this.lblShowpass.Text = "showPass";
            this.lblShowpass.MouseLeave += new System.EventHandler(this.lblShowpass_MouseLeave);
            this.lblShowpass.MouseHover += new System.EventHandler(this.lblShowpass_MouseHover);
            // 
            // btnMKtusinh
            // 
            this.btnMKtusinh.Location = new System.Drawing.Point(17, 286);
            this.btnMKtusinh.Name = "btnMKtusinh";
            this.btnMKtusinh.Size = new System.Drawing.Size(154, 38);
            this.btnMKtusinh.TabIndex = 20;
            this.btnMKtusinh.Text = "mật khẩu tự sinh";
            this.btnMKtusinh.UseVisualStyleBackColor = true;
            this.btnMKtusinh.Click += new System.EventHandler(this.btnMKtusinh_Click);
            // 
            // cboYear
            // 
            this.cboYear.AllowDrop = true;
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(124, 183);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(173, 28);
            this.cboYear.TabIndex = 16;
            // 
            // lblNamSinh
            // 
            this.lblNamSinh.AutoSize = true;
            this.lblNamSinh.Location = new System.Drawing.Point(13, 183);
            this.lblNamSinh.Name = "lblNamSinh";
            this.lblNamSinh.Size = new System.Drawing.Size(78, 20);
            this.lblNamSinh.TabIndex = 19;
            this.lblNamSinh.Text = "Năm Sinh";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(13, 148);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(71, 20);
            this.lblGioiTinh.TabIndex = 17;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // rdSexNu
            // 
            this.rdSexNu.AutoSize = true;
            this.rdSexNu.Location = new System.Drawing.Point(243, 144);
            this.rdSexNu.Name = "rdSexNu";
            this.rdSexNu.Size = new System.Drawing.Size(54, 24);
            this.rdSexNu.TabIndex = 15;
            this.rdSexNu.TabStop = true;
            this.rdSexNu.Text = "Nữ";
            this.rdSexNu.UseVisualStyleBackColor = true;
            // 
            // rdSexNam
            // 
            this.rdSexNam.AutoSize = true;
            this.rdSexNam.Location = new System.Drawing.Point(124, 144);
            this.rdSexNam.Name = "rdSexNam";
            this.rdSexNam.Size = new System.Drawing.Size(67, 24);
            this.rdSexNam.TabIndex = 14;
            this.rdSexNam.TabStop = true;
            this.rdSexNam.Text = "Nam";
            this.rdSexNam.UseVisualStyleBackColor = true;
            // 
            // lblMK2
            // 
            this.lblMK2.AutoSize = true;
            this.lblMK2.Location = new System.Drawing.Point(13, 109);
            this.lblMK2.Name = "lblMK2";
            this.lblMK2.Size = new System.Drawing.Size(104, 20);
            this.lblMK2.TabIndex = 11;
            this.lblMK2.Text = "Xác nhận MK";
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Location = new System.Drawing.Point(13, 71);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(77, 20);
            this.lblMK.TabIndex = 12;
            this.lblMK.Text = "Mật Khẩu";
            // 
            // txtMK2
            // 
            this.txtMK2.Location = new System.Drawing.Point(124, 106);
            this.txtMK2.Name = "txtMK2";
            this.txtMK2.PasswordChar = '*';
            this.txtMK2.Size = new System.Drawing.Size(173, 26);
            this.txtMK2.TabIndex = 13;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(124, 68);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(173, 26);
            this.txtMK.TabIndex = 10;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(124, 30);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(173, 26);
            this.txtTK.TabIndex = 8;
            // 
            // bblTK
            // 
            this.bblTK.AutoSize = true;
            this.bblTK.Location = new System.Drawing.Point(9, 36);
            this.bblTK.Name = "bblTK";
            this.bblTK.Size = new System.Drawing.Size(80, 20);
            this.bblTK.TabIndex = 9;
            this.bblTK.Text = "Tài Khoản";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 22);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(612, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDataAccountToolStripMenuItem,
            this.saveDataEditToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadDataAccountToolStripMenuItem
            // 
            this.loadDataAccountToolStripMenuItem.Name = "loadDataAccountToolStripMenuItem";
            this.loadDataAccountToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
            this.loadDataAccountToolStripMenuItem.Text = "load data account";
            this.loadDataAccountToolStripMenuItem.Click += new System.EventHandler(this.loadDataAccountToolStripMenuItem_Click);
            // 
            // saveDataEditToolStripMenuItem
            // 
            this.saveDataEditToolStripMenuItem.Name = "saveDataEditToolStripMenuItem";
            this.saveDataEditToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
            this.saveDataEditToolStripMenuItem.Text = "save data edit";
            this.saveDataEditToolStripMenuItem.Click += new System.EventHandler(this.saveDataEditToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAccount);
            this.groupBox1.Controls.Add(this.pnTimkiem);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 284);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "data";
            // 
            // dgvAccount
            // 
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccount.Location = new System.Drawing.Point(3, 97);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 62;
            this.dgvAccount.RowTemplate.Height = 28;
            this.dgvAccount.Size = new System.Drawing.Size(612, 184);
            this.dgvAccount.TabIndex = 1;
            this.dgvAccount.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAccount_CellMouseClick);
            // 
            // pnTimkiem
            // 
            this.pnTimkiem.Controls.Add(this.btnTimKiem);
            this.pnTimkiem.Controls.Add(this.txtTimKiem);
            this.pnTimkiem.Controls.Add(this.lblTimKiem);
            this.pnTimkiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTimkiem.Location = new System.Drawing.Point(3, 22);
            this.pnTimkiem.Name = "pnTimkiem";
            this.pnTimkiem.Size = new System.Drawing.Size(612, 75);
            this.pnTimkiem.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.Location = new System.Drawing.Point(346, 23);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(108, 34);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(116, 24);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(214, 26);
            this.txtTimKiem.TabIndex = 1;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(25, 28);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(77, 20);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = " Tìm Kiếm";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 685);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbcontain);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.gbcontain.ResumeLayout(false);
            this.gbcontain.PerformLayout();
            this.grbCN.ResumeLayout(false);
            this.grbTK.ResumeLayout(false);
            this.grbTK.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.pnTimkiem.ResumeLayout(false);
            this.pnTimkiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbcontain;
        private System.Windows.Forms.GroupBox grbCN;
        private System.Windows.Forms.GroupBox grbTK;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblShowpass;
        private System.Windows.Forms.Button btnMKtusinh;
        private System.Windows.Forms.Label lblNamSinh;
        private System.Windows.Forms.Label lblMK2;
        private System.Windows.Forms.Label lblMK;
        private System.Windows.Forms.TextBox txtMK2;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label bblTK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Panel pnTimkiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDataAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdOff;
        private System.Windows.Forms.RadioButton rdOn;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton rdSexNu;
        private System.Windows.Forms.RadioButton rdSexNam;
        private Button btnTimKiem;
        private ComboBox cboYear;
    }
}