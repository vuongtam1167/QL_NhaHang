namespace QL_NhaHang
{
    partial class frmQLNguyenLieu
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
            this.label2 = new System.Windows.Forms.Label();
            this.gpbChiTiet = new System.Windows.Forms.GroupBox();
            this.cboNhaCungCap = new System.Windows.Forms.ComboBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.rtbMoTa = new System.Windows.Forms.RichTextBox();
            this.nudGiaTien = new System.Windows.Forms.NumericUpDown();
            this.cboLoaiNL = new System.Windows.Forms.ComboBox();
            this.nudSLton = new System.Windows.Forms.NumericUpDown();
            this.txtTenNL = new System.Windows.Forms.TextBox();
            this.txtMaNL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvNguyenLieu = new System.Windows.Forms.DataGridView();
            this.colMANL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiNL = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMaNCC = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSLton)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(320, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "QUẢN LÝ NGUYÊN LIỆU";
            // 
            // gpbChiTiet
            // 
            this.gpbChiTiet.Controls.Add(this.cboNhaCungCap);
            this.gpbChiTiet.Controls.Add(this.btnLamMoi);
            this.gpbChiTiet.Controls.Add(this.btnXoa);
            this.gpbChiTiet.Controls.Add(this.btnSua);
            this.gpbChiTiet.Controls.Add(this.btnThem);
            this.gpbChiTiet.Controls.Add(this.rtbMoTa);
            this.gpbChiTiet.Controls.Add(this.nudGiaTien);
            this.gpbChiTiet.Controls.Add(this.cboLoaiNL);
            this.gpbChiTiet.Controls.Add(this.nudSLton);
            this.gpbChiTiet.Controls.Add(this.txtTenNL);
            this.gpbChiTiet.Controls.Add(this.txtMaNL);
            this.gpbChiTiet.Controls.Add(this.label8);
            this.gpbChiTiet.Controls.Add(this.label7);
            this.gpbChiTiet.Controls.Add(this.label6);
            this.gpbChiTiet.Controls.Add(this.label5);
            this.gpbChiTiet.Controls.Add(this.label4);
            this.gpbChiTiet.Controls.Add(this.label3);
            this.gpbChiTiet.Controls.Add(this.label1);
            this.gpbChiTiet.Location = new System.Drawing.Point(24, 37);
            this.gpbChiTiet.Name = "gpbChiTiet";
            this.gpbChiTiet.Size = new System.Drawing.Size(308, 548);
            this.gpbChiTiet.TabIndex = 4;
            this.gpbChiTiet.TabStop = false;
            this.gpbChiTiet.Text = "Chi Tiết";
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.FormattingEnabled = true;
            this.cboNhaCungCap.Location = new System.Drawing.Point(103, 180);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(174, 21);
            this.cboNhaCungCap.TabIndex = 12;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(240, 439);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(60, 55);
            this.btnLamMoi.TabIndex = 11;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(162, 439);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(60, 55);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(84, 439);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(60, 55);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(6, 439);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(60, 55);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // rtbMoTa
            // 
            this.rtbMoTa.Location = new System.Drawing.Point(103, 259);
            this.rtbMoTa.Name = "rtbMoTa";
            this.rtbMoTa.Size = new System.Drawing.Size(174, 115);
            this.rtbMoTa.TabIndex = 10;
            this.rtbMoTa.Text = "";
            // 
            // nudGiaTien
            // 
            this.nudGiaTien.Location = new System.Drawing.Point(103, 219);
            this.nudGiaTien.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudGiaTien.Name = "nudGiaTien";
            this.nudGiaTien.Size = new System.Drawing.Size(174, 20);
            this.nudGiaTien.TabIndex = 9;
            // 
            // cboLoaiNL
            // 
            this.cboLoaiNL.FormattingEnabled = true;
            this.cboLoaiNL.Location = new System.Drawing.Point(103, 142);
            this.cboLoaiNL.Name = "cboLoaiNL";
            this.cboLoaiNL.Size = new System.Drawing.Size(174, 21);
            this.cboLoaiNL.TabIndex = 7;
            // 
            // nudSLton
            // 
            this.nudSLton.Location = new System.Drawing.Point(103, 105);
            this.nudSLton.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudSLton.Name = "nudSLton";
            this.nudSLton.Size = new System.Drawing.Size(174, 20);
            this.nudSLton.TabIndex = 6;
            // 
            // txtTenNL
            // 
            this.txtTenNL.Location = new System.Drawing.Point(103, 66);
            this.txtTenNL.Name = "txtTenNL";
            this.txtTenNL.Size = new System.Drawing.Size(174, 20);
            this.txtTenNL.TabIndex = 5;
            // 
            // txtMaNL
            // 
            this.txtMaNL.Location = new System.Drawing.Point(103, 28);
            this.txtMaNL.Name = "txtMaNL";
            this.txtMaNL.ReadOnly = true;
            this.txtMaNL.Size = new System.Drawing.Size(174, 20);
            this.txtMaNL.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Mô tả:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nhà Cung Cấp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Loại nguyên liệu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số lượng tồn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên nguyên liệu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nguyên liệu:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.dgvNguyenLieu);
            this.panel1.Controls.Add(this.gpbChiTiet);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 588);
            this.panel1.TabIndex = 1;
            // 
            // dgvNguyenLieu
            // 
            this.dgvNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguyenLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMANL,
            this.colTenNL,
            this.colSoLuongTon,
            this.colLoaiNL,
            this.colMaNCC,
            this.colGia,
            this.colMoTa});
            this.dgvNguyenLieu.Location = new System.Drawing.Point(338, 43);
            this.dgvNguyenLieu.MultiSelect = false;
            this.dgvNguyenLieu.Name = "dgvNguyenLieu";
            this.dgvNguyenLieu.ReadOnly = true;
            this.dgvNguyenLieu.RowHeadersVisible = false;
            this.dgvNguyenLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNguyenLieu.Size = new System.Drawing.Size(661, 542);
            this.dgvNguyenLieu.TabIndex = 5;
            this.dgvNguyenLieu.SelectionChanged += new System.EventHandler(this.dgvNguyenLieu_SelectionChanged);
            // 
            // colMANL
            // 
            this.colMANL.DataPropertyName = "MANGUYENLIEU";
            this.colMANL.HeaderText = "Mã Nguyên Liệu";
            this.colMANL.Name = "colMANL";
            this.colMANL.ReadOnly = true;
            // 
            // colTenNL
            // 
            this.colTenNL.DataPropertyName = "TENNGUYENLIEU";
            this.colTenNL.HeaderText = "Tên Nguyên Liệu";
            this.colTenNL.Name = "colTenNL";
            this.colTenNL.ReadOnly = true;
            // 
            // colSoLuongTon
            // 
            this.colSoLuongTon.DataPropertyName = "SOLUONGCON";
            this.colSoLuongTon.HeaderText = "Số Lượng Tồn";
            this.colSoLuongTon.Name = "colSoLuongTon";
            this.colSoLuongTon.ReadOnly = true;
            // 
            // colLoaiNL
            // 
            this.colLoaiNL.DataPropertyName = "LOAINGUYENLIEU";
            this.colLoaiNL.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colLoaiNL.HeaderText = "Loại Nguyên Liệu";
            this.colLoaiNL.Name = "colLoaiNL";
            this.colLoaiNL.ReadOnly = true;
            this.colLoaiNL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLoaiNL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colMaNCC
            // 
            this.colMaNCC.DataPropertyName = "MANHACUNGCAP";
            this.colMaNCC.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colMaNCC.HeaderText = "Nhà Cung Cấp";
            this.colMaNCC.Name = "colMaNCC";
            this.colMaNCC.ReadOnly = true;
            this.colMaNCC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaNCC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colGia
            // 
            this.colGia.DataPropertyName = "GIATIEN";
            this.colGia.HeaderText = "Giá";
            this.colGia.Name = "colGia";
            this.colGia.ReadOnly = true;
            // 
            // colMoTa
            // 
            this.colMoTa.DataPropertyName = "MOTA";
            this.colMoTa.HeaderText = "Mô Tả";
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.ReadOnly = true;
            // 
            // frmQLNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 612);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLNguyenLieu";
            this.Load += new System.EventHandler(this.frmQLNguyenLieu_Load);
            this.gpbChiTiet.ResumeLayout(false);
            this.gpbChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSLton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpbChiTiet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboNhaCungCap;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.RichTextBox rtbMoTa;
        private System.Windows.Forms.NumericUpDown nudGiaTien;
        private System.Windows.Forms.ComboBox cboLoaiNL;
        private System.Windows.Forms.NumericUpDown nudSLton;
        private System.Windows.Forms.TextBox txtTenNL;
        private System.Windows.Forms.TextBox txtMaNL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMANL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongTon;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLoaiNL;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
    }
}