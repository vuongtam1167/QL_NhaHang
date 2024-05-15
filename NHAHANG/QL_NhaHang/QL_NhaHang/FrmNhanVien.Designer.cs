namespace QL_NhaHang
{
    partial class frmNhanVien
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtChucV = new System.Windows.Forms.ComboBox();
            this.picNhanVien = new System.Windows.Forms.PictureBox();
            this.ckbTrangThai = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnSuaKH = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtEmNV = new System.Windows.Forms.TextBox();
            this.txtTongTG = new System.Windows.Forms.TextBox();
            this.txtThanhTich = new System.Windows.Forms.TextBox();
            this.txtSDTNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvtt = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmailNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCCCDNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(-22, -37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 607);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtChucV);
            this.groupBox1.Controls.Add(this.picNhanVien);
            this.groupBox1.Controls.Add(this.ckbTrangThai);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnXoaKH);
            this.groupBox1.Controls.Add(this.btnSuaKH);
            this.groupBox1.Controls.Add(this.btnThemKH);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.txtCCCD);
            this.groupBox1.Controls.Add(this.txtEmNV);
            this.groupBox1.Controls.Add(this.txtTongTG);
            this.groupBox1.Controls.Add(this.txtThanhTich);
            this.groupBox1.Controls.Add(this.txtSDTNV);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(24, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(390, 573);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // txtChucV
            // 
            this.txtChucV.FormattingEnabled = true;
            this.txtChucV.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.txtChucV.Location = new System.Drawing.Point(145, 291);
            this.txtChucV.Name = "txtChucV";
            this.txtChucV.Size = new System.Drawing.Size(157, 21);
            this.txtChucV.TabIndex = 6;
            // 
            // picNhanVien
            // 
            this.picNhanVien.Image = global::QL_NhaHang.Properties.Resources.defaut;
            this.picNhanVien.Location = new System.Drawing.Point(15, 51);
            this.picNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.picNhanVien.Name = "picNhanVien";
            this.picNhanVien.Size = new System.Drawing.Size(111, 90);
            this.picNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNhanVien.TabIndex = 5;
            this.picNhanVien.TabStop = false;
            this.picNhanVien.Click += new System.EventHandler(this.picNhanVien_Click);
            // 
            // ckbTrangThai
            // 
            this.ckbTrangThai.AutoSize = true;
            this.ckbTrangThai.Location = new System.Drawing.Point(145, 376);
            this.ckbTrangThai.Margin = new System.Windows.Forms.Padding(2);
            this.ckbTrangThai.Name = "ckbTrangThai";
            this.ckbTrangThai.Size = new System.Drawing.Size(15, 14);
            this.ckbTrangThai.TabIndex = 4;
            this.ckbTrangThai.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(197, 472);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 33);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(390, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "THÔNG TIN NHÂN VIÊN";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.Location = new System.Drawing.Point(65, 472);
            this.btnXoaKH.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(85, 33);
            this.btnXoaKH.TabIndex = 3;
            this.btnXoaKH.Text = "Xóa";
            this.btnXoaKH.UseVisualStyleBackColor = true;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.Location = new System.Drawing.Point(197, 421);
            this.btnSuaKH.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(85, 33);
            this.btnSuaKH.TabIndex = 3;
            this.btnSuaKH.Text = "Sửa";
            this.btnSuaKH.UseVisualStyleBackColor = true;
            this.btnSuaKH.Click += new System.EventHandler(this.btnSuaKH_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.Location = new System.Drawing.Point(65, 421);
            this.btnThemKH.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(85, 33);
            this.btnThemKH.TabIndex = 3;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(145, 151);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(157, 20);
            this.txtMaNV.TabIndex = 2;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(145, 235);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(2);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(157, 20);
            this.txtCCCD.TabIndex = 2;
            // 
            // txtEmNV
            // 
            this.txtEmNV.Location = new System.Drawing.Point(145, 207);
            this.txtEmNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmNV.Name = "txtEmNV";
            this.txtEmNV.Size = new System.Drawing.Size(157, 20);
            this.txtEmNV.TabIndex = 2;
            // 
            // txtTongTG
            // 
            this.txtTongTG.Location = new System.Drawing.Point(145, 348);
            this.txtTongTG.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongTG.Name = "txtTongTG";
            this.txtTongTG.Size = new System.Drawing.Size(157, 20);
            this.txtTongTG.TabIndex = 2;
            // 
            // txtThanhTich
            // 
            this.txtThanhTich.Location = new System.Drawing.Point(145, 320);
            this.txtThanhTich.Margin = new System.Windows.Forms.Padding(2);
            this.txtThanhTich.Name = "txtThanhTich";
            this.txtThanhTich.Size = new System.Drawing.Size(157, 20);
            this.txtThanhTich.TabIndex = 2;
            // 
            // txtSDTNV
            // 
            this.txtSDTNV.Location = new System.Drawing.Point(145, 263);
            this.txtSDTNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDTNV.Name = "txtSDTNV";
            this.txtSDTNV.Size = new System.Drawing.Size(157, 20);
            this.txtSDTNV.TabIndex = 2;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(145, 179);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(157, 20);
            this.txtTenNV.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 378);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Trạng Thái:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 350);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tổng Thời Gian Làm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thành Tích:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 294);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chức Vụ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 266);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SDT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 238);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "CCCD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên Nhân Viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã Nhân Viên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvtt);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Location = new System.Drawing.Point(418, 32);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(598, 573);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // dgvtt
            // 
            this.dgvtt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNV,
            this.colTenNV,
            this.colEmailNV,
            this.colCCCDNV,
            this.colSDT,
            this.colCV,
            this.colTT,
            this.colTongTg,
            this.colTrangThai});
            this.dgvtt.Location = new System.Drawing.Point(4, 46);
            this.dgvtt.Margin = new System.Windows.Forms.Padding(2);
            this.dgvtt.MultiSelect = false;
            this.dgvtt.Name = "dgvtt";
            this.dgvtt.ReadOnly = true;
            this.dgvtt.RowHeadersVisible = false;
            this.dgvtt.RowHeadersWidth = 51;
            this.dgvtt.RowTemplate.Height = 24;
            this.dgvtt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtt.Size = new System.Drawing.Size(594, 527);
            this.dgvtt.TabIndex = 3;
            this.dgvtt.SelectionChanged += new System.EventHandler(this.dgvtt_SelectionChanged);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(0, 7);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(598, 40);
            this.button7.TabIndex = 0;
            this.button7.Text = "DANH SÁCH";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // colMaNV
            // 
            this.colMaNV.DataPropertyName = "MANV";
            this.colMaNV.HeaderText = "Mã Nhân Viên";
            this.colMaNV.MinimumWidth = 6;
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.ReadOnly = true;
            this.colMaNV.Width = 125;
            // 
            // colTenNV
            // 
            this.colTenNV.DataPropertyName = "HOTEN";
            this.colTenNV.HeaderText = "Tên Nhân Viên";
            this.colTenNV.MinimumWidth = 6;
            this.colTenNV.Name = "colTenNV";
            this.colTenNV.ReadOnly = true;
            this.colTenNV.Width = 125;
            // 
            // colEmailNV
            // 
            this.colEmailNV.DataPropertyName = "EMAIL";
            this.colEmailNV.HeaderText = "Email";
            this.colEmailNV.MinimumWidth = 6;
            this.colEmailNV.Name = "colEmailNV";
            this.colEmailNV.ReadOnly = true;
            this.colEmailNV.Width = 125;
            // 
            // colCCCDNV
            // 
            this.colCCCDNV.DataPropertyName = "CCCD";
            this.colCCCDNV.HeaderText = "CCCD";
            this.colCCCDNV.MinimumWidth = 6;
            this.colCCCDNV.Name = "colCCCDNV";
            this.colCCCDNV.ReadOnly = true;
            this.colCCCDNV.Width = 125;
            // 
            // colSDT
            // 
            this.colSDT.DataPropertyName = "SDT";
            this.colSDT.HeaderText = "SĐT";
            this.colSDT.MinimumWidth = 6;
            this.colSDT.Name = "colSDT";
            this.colSDT.ReadOnly = true;
            this.colSDT.Width = 125;
            // 
            // colCV
            // 
            this.colCV.DataPropertyName = "CHUCVU";
            this.colCV.HeaderText = "Chức Vụ";
            this.colCV.MinimumWidth = 6;
            this.colCV.Name = "colCV";
            this.colCV.ReadOnly = true;
            this.colCV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCV.Width = 125;
            // 
            // colTT
            // 
            this.colTT.DataPropertyName = "THANHTICH";
            this.colTT.HeaderText = "Thành Tích";
            this.colTT.MinimumWidth = 6;
            this.colTT.Name = "colTT";
            this.colTT.ReadOnly = true;
            this.colTT.Width = 125;
            // 
            // colTongTg
            // 
            this.colTongTg.DataPropertyName = "TONGTHOIGIANLAM";
            this.colTongTg.HeaderText = "Tổng Thời Gian Làm";
            this.colTongTg.MinimumWidth = 6;
            this.colTongTg.Name = "colTongTg";
            this.colTongTg.ReadOnly = true;
            this.colTongTg.Width = 125;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TRANGTHAI";
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Width = 125;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 620);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtChucV;
        private System.Windows.Forms.PictureBox picNhanVien;
        private System.Windows.Forms.CheckBox ckbTrangThai;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.Button btnSuaKH;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtEmNV;
        private System.Windows.Forms.TextBox txtTongTG;
        private System.Windows.Forms.TextBox txtThanhTich;
        private System.Windows.Forms.TextBox txtSDTNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvtt;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmailNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCCCDNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTg;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTrangThai;
    }
}