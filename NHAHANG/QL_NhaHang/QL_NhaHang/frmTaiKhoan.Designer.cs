namespace QL_NhaHang
{
    partial class frmTaiKhoan
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTK = new System.Windows.Forms.DataGridView();
            this.colMaNV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTenDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grbtt = new System.Windows.Forms.GroupBox();
            this.chkTrangThai = new System.Windows.Forms.CheckBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboManv = new System.Windows.Forms.ComboBox();
            this.cboLoaiTK = new System.Windows.Forms.ComboBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picAnhDD = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbtt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhDD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvTK);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.grbtt);
            this.panel2.Controls.Add(this.picAnhDD);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(938, 629);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dgvTK
            // 
            this.dgvTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNV,
            this.colTenDN,
            this.colLoaiTK,
            this.colTrangThai});
            this.dgvTK.Location = new System.Drawing.Point(2, 329);
            this.dgvTK.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTK.MultiSelect = false;
            this.dgvTK.Name = "dgvTK";
            this.dgvTK.ReadOnly = true;
            this.dgvTK.RowHeadersVisible = false;
            this.dgvTK.RowHeadersWidth = 51;
            this.dgvTK.RowTemplate.Height = 24;
            this.dgvTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTK.Size = new System.Drawing.Size(987, 298);
            this.dgvTK.TabIndex = 37;
            this.dgvTK.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // colMaNV
            // 
            this.colMaNV.DataPropertyName = "MANV";
            this.colMaNV.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colMaNV.HeaderText = "Mã Nhân Viên";
            this.colMaNV.MinimumWidth = 6;
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.ReadOnly = true;
            // 
            // colTenDN
            // 
            this.colTenDN.DataPropertyName = "TENDANGNHAP";
            this.colTenDN.HeaderText = "Tên Đăng Nhập";
            this.colTenDN.MinimumWidth = 6;
            this.colTenDN.Name = "colTenDN";
            this.colTenDN.ReadOnly = true;
            // 
            // colLoaiTK
            // 
            this.colLoaiTK.DataPropertyName = "LOAITK";
            this.colLoaiTK.HeaderText = "Loại Tài Khoản";
            this.colLoaiTK.MinimumWidth = 6;
            this.colLoaiTK.Name = "colLoaiTK";
            this.colLoaiTK.ReadOnly = true;
            this.colLoaiTK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TRANGTHAI";
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(0, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(999, 48);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "TÀI KHOẢN";
            // 
            // grbtt
            // 
            this.grbtt.Controls.Add(this.chkTrangThai);
            this.grbtt.Controls.Add(this.btnXoa);
            this.grbtt.Controls.Add(this.label11);
            this.grbtt.Controls.Add(this.btnSua);
            this.grbtt.Controls.Add(this.btnThem);
            this.grbtt.Controls.Add(this.cboManv);
            this.grbtt.Controls.Add(this.cboLoaiTK);
            this.grbtt.Controls.Add(this.txtMK);
            this.grbtt.Controls.Add(this.txtTenDN);
            this.grbtt.Controls.Add(this.label3);
            this.grbtt.Controls.Add(this.label5);
            this.grbtt.Controls.Add(this.label2);
            this.grbtt.Controls.Add(this.label1);
            this.grbtt.Location = new System.Drawing.Point(176, 85);
            this.grbtt.Margin = new System.Windows.Forms.Padding(2);
            this.grbtt.Name = "grbtt";
            this.grbtt.Padding = new System.Windows.Forms.Padding(2);
            this.grbtt.Size = new System.Drawing.Size(760, 227);
            this.grbtt.TabIndex = 1;
            this.grbtt.TabStop = false;
            this.grbtt.Text = "Thông tin chi tiết ";
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.AutoSize = true;
            this.chkTrangThai.Location = new System.Drawing.Point(124, 194);
            this.chkTrangThai.Margin = new System.Windows.Forms.Padding(2);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Size = new System.Drawing.Size(15, 14);
            this.chkTrangThai.TabIndex = 6;
            this.chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(514, 28);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 32);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 195);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Trạng Thái:";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(380, 75);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(88, 32);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(380, 28);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 32);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboManv
            // 
            this.cboManv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboManv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboManv.FormattingEnabled = true;
            this.cboManv.Location = new System.Drawing.Point(124, 28);
            this.cboManv.Margin = new System.Windows.Forms.Padding(2);
            this.cboManv.Name = "cboManv";
            this.cboManv.Size = new System.Drawing.Size(191, 25);
            this.cboManv.TabIndex = 6;
            // 
            // cboLoaiTK
            // 
            this.cboLoaiTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiTK.FormattingEnabled = true;
            this.cboLoaiTK.Items.AddRange(new object[] {
            "QL",
            "NV"});
            this.cboLoaiTK.Location = new System.Drawing.Point(124, 156);
            this.cboLoaiTK.Margin = new System.Windows.Forms.Padding(2);
            this.cboLoaiTK.Name = "cboLoaiTK";
            this.cboLoaiTK.Size = new System.Drawing.Size(191, 25);
            this.cboLoaiTK.TabIndex = 5;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(124, 113);
            this.txtMK.Margin = new System.Windows.Forms.Padding(2);
            this.txtMK.Multiline = true;
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(191, 26);
            this.txtMK.TabIndex = 4;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(124, 70);
            this.txtTenDN.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenDN.Multiline = true;
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(191, 26);
            this.txtTenDN.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại TK:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // picAnhDD
            // 
            this.picAnhDD.Location = new System.Drawing.Point(30, 85);
            this.picAnhDD.Margin = new System.Windows.Forms.Padding(2);
            this.picAnhDD.Name = "picAnhDD";
            this.picAnhDD.Size = new System.Drawing.Size(100, 101);
            this.picAnhDD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnhDD.TabIndex = 0;
            this.picAnhDD.TabStop = false;
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 629);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTaiKhoan";
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbtt.ResumeLayout(false);
            this.grbtt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhDD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTK;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiTK;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTrangThai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbtt;
        private System.Windows.Forms.CheckBox chkTrangThai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboManv;
        private System.Windows.Forms.ComboBox cboLoaiTK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picAnhDD;
    }
}