namespace QL_NhaHang
{
    partial class frmQL_Mon
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
            this.dgvCTMon = new System.Windows.Forms.DataGridView();
            this.colMaNL = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMon = new System.Windows.Forms.DataGridView();
            this.grbCTMon = new System.Windows.Forms.GroupBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cboMaNL = new System.Windows.Forms.ComboBox();
            this.btnGiamNL = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTangNL = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.grbMon = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.rtbMoTa = new System.Windows.Forms.RichTextBox();
            this.cboMaLoai = new System.Windows.Forms.ComboBox();
            this.nudGiaTien = new System.Windows.Forms.NumericUpDown();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.picAnhMon = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaLoai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).BeginInit();
            this.grbCTMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.grbMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhMon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.dgvCTMon);
            this.panel2.Controls.Add(this.dgvMon);
            this.panel2.Controls.Add(this.grbCTMon);
            this.panel2.Controls.Add(this.grbMon);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(981, 552);
            this.panel2.TabIndex = 2;
            // 
            // dgvCTMon
            // 
            this.dgvCTMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNL,
            this.colSoLuong});
            this.dgvCTMon.Location = new System.Drawing.Point(595, 213);
            this.dgvCTMon.MultiSelect = false;
            this.dgvCTMon.Name = "dgvCTMon";
            this.dgvCTMon.ReadOnly = true;
            this.dgvCTMon.RowHeadersVisible = false;
            this.dgvCTMon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTMon.Size = new System.Drawing.Size(365, 336);
            this.dgvCTMon.TabIndex = 11;
            this.dgvCTMon.SelectionChanged += new System.EventHandler(this.dgvCTMon_SelectionChanged);
            // 
            // colMaNL
            // 
            this.colMaNL.DataPropertyName = "MANGUYENLIEU";
            this.colMaNL.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colMaNL.HeaderText = "Nguyên Liệu";
            this.colMaNL.Name = "colMaNL";
            this.colMaNL.ReadOnly = true;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SOLUONG";
            this.colSoLuong.HeaderText = "Số Lượng";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            // 
            // dgvMon
            // 
            this.dgvMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaMon,
            this.colTenMon,
            this.colGia,
            this.colMaLoai,
            this.colMoTa});
            this.dgvMon.Location = new System.Drawing.Point(14, 213);
            this.dgvMon.MultiSelect = false;
            this.dgvMon.Name = "dgvMon";
            this.dgvMon.ReadOnly = true;
            this.dgvMon.RowHeadersVisible = false;
            this.dgvMon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMon.Size = new System.Drawing.Size(575, 336);
            this.dgvMon.TabIndex = 10;
            this.dgvMon.SelectionChanged += new System.EventHandler(this.dgvMon_SelectionChanged);
            // 
            // grbCTMon
            // 
            this.grbCTMon.Controls.Add(this.nudSoLuong);
            this.grbCTMon.Controls.Add(this.cboMaNL);
            this.grbCTMon.Controls.Add(this.btnGiamNL);
            this.grbCTMon.Controls.Add(this.label8);
            this.grbCTMon.Controls.Add(this.btnTangNL);
            this.grbCTMon.Controls.Add(this.label7);
            this.grbCTMon.Location = new System.Drawing.Point(595, 50);
            this.grbCTMon.Name = "grbCTMon";
            this.grbCTMon.Size = new System.Drawing.Size(365, 157);
            this.grbCTMon.TabIndex = 9;
            this.grbCTMon.TabStop = false;
            this.grbCTMon.Text = "Nguyên Liệu Món";
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(125, 50);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(219, 20);
            this.nudSoLuong.TabIndex = 3;
            // 
            // cboMaNL
            // 
            this.cboMaNL.FormattingEnabled = true;
            this.cboMaNL.Location = new System.Drawing.Point(125, 15);
            this.cboMaNL.Name = "cboMaNL";
            this.cboMaNL.Size = new System.Drawing.Size(219, 21);
            this.cboMaNL.TabIndex = 2;
            // 
            // btnGiamNL
            // 
            this.btnGiamNL.Image = global::QL_NhaHang.Properties.Resources.minus;
            this.btnGiamNL.Location = new System.Drawing.Point(287, 87);
            this.btnGiamNL.Name = "btnGiamNL";
            this.btnGiamNL.Size = new System.Drawing.Size(57, 55);
            this.btnGiamNL.TabIndex = 11;
            this.btnGiamNL.UseVisualStyleBackColor = true;
            this.btnGiamNL.Click += new System.EventHandler(this.btnGiamNL_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Số Lượng NL:";
            // 
            // btnTangNL
            // 
            this.btnTangNL.Image = global::QL_NhaHang.Properties.Resources.add;
            this.btnTangNL.Location = new System.Drawing.Point(200, 87);
            this.btnTangNL.Name = "btnTangNL";
            this.btnTangNL.Size = new System.Drawing.Size(57, 55);
            this.btnTangNL.TabIndex = 11;
            this.btnTangNL.UseVisualStyleBackColor = true;
            this.btnTangNL.Click += new System.EventHandler(this.btnTangNL_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nguyên Liệu:";
            // 
            // grbMon
            // 
            this.grbMon.Controls.Add(this.btnSua);
            this.grbMon.Controls.Add(this.btnLamMoi);
            this.grbMon.Controls.Add(this.btnXoa);
            this.grbMon.Controls.Add(this.btnThem);
            this.grbMon.Controls.Add(this.rtbMoTa);
            this.grbMon.Controls.Add(this.cboMaLoai);
            this.grbMon.Controls.Add(this.nudGiaTien);
            this.grbMon.Controls.Add(this.txtTenMon);
            this.grbMon.Controls.Add(this.txtMaMon);
            this.grbMon.Controls.Add(this.picAnhMon);
            this.grbMon.Controls.Add(this.label6);
            this.grbMon.Controls.Add(this.label5);
            this.grbMon.Controls.Add(this.label4);
            this.grbMon.Controls.Add(this.label3);
            this.grbMon.Controls.Add(this.label1);
            this.grbMon.Location = new System.Drawing.Point(14, 49);
            this.grbMon.Name = "grbMon";
            this.grbMon.Size = new System.Drawing.Size(575, 157);
            this.grbMon.TabIndex = 8;
            this.grbMon.TabStop = false;
            this.grbMon.Text = "Món";
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QL_NhaHang.Properties.Resources.edit;
            this.btnSua.Location = new System.Drawing.Point(431, 88);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(57, 55);
            this.btnSua.TabIndex = 11;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Image = global::QL_NhaHang.Properties.Resources.reset;
            this.btnLamMoi.Location = new System.Drawing.Point(512, 88);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(57, 55);
            this.btnLamMoi.TabIndex = 11;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QL_NhaHang.Properties.Resources.minus;
            this.btnXoa.Location = new System.Drawing.Point(512, 16);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(57, 55);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QL_NhaHang.Properties.Resources.add;
            this.btnThem.Location = new System.Drawing.Point(431, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(57, 55);
            this.btnThem.TabIndex = 11;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // rtbMoTa
            // 
            this.rtbMoTa.Location = new System.Drawing.Point(191, 119);
            this.rtbMoTa.Name = "rtbMoTa";
            this.rtbMoTa.Size = new System.Drawing.Size(181, 22);
            this.rtbMoTa.TabIndex = 10;
            this.rtbMoTa.Text = "";
            // 
            // cboMaLoai
            // 
            this.cboMaLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaLoai.FormattingEnabled = true;
            this.cboMaLoai.Location = new System.Drawing.Point(191, 93);
            this.cboMaLoai.Name = "cboMaLoai";
            this.cboMaLoai.Size = new System.Drawing.Size(181, 21);
            this.cboMaLoai.TabIndex = 9;
            // 
            // nudGiaTien
            // 
            this.nudGiaTien.Location = new System.Drawing.Point(191, 68);
            this.nudGiaTien.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudGiaTien.Name = "nudGiaTien";
            this.nudGiaTien.Size = new System.Drawing.Size(181, 20);
            this.nudGiaTien.TabIndex = 8;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(191, 42);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(181, 20);
            this.txtTenMon.TabIndex = 7;
            // 
            // txtMaMon
            // 
            this.txtMaMon.Location = new System.Drawing.Point(191, 16);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.ReadOnly = true;
            this.txtMaMon.Size = new System.Drawing.Size(181, 20);
            this.txtMaMon.TabIndex = 6;
            this.txtMaMon.TextChanged += new System.EventHandler(this.txtMaMon_TextChanged);
            // 
            // picAnhMon
            // 
            this.picAnhMon.Location = new System.Drawing.Point(23, 23);
            this.picAnhMon.Name = "picAnhMon";
            this.picAnhMon.Size = new System.Drawing.Size(81, 100);
            this.picAnhMon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnhMon.TabIndex = 5;
            this.picAnhMon.TabStop = false;
            this.picAnhMon.Click += new System.EventHandler(this.picAnhMon_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(122, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mô Tả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã Loại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Món:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Món:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(362, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "QUẢN LÝ MÓN";
            // 
            // colMaMon
            // 
            this.colMaMon.DataPropertyName = "MAMON";
            this.colMaMon.HeaderText = "Mã Món";
            this.colMaMon.Name = "colMaMon";
            this.colMaMon.ReadOnly = true;
            // 
            // colTenMon
            // 
            this.colTenMon.DataPropertyName = "TENMON";
            this.colTenMon.HeaderText = "Tên Món";
            this.colTenMon.Name = "colTenMon";
            this.colTenMon.ReadOnly = true;
            // 
            // colGia
            // 
            this.colGia.DataPropertyName = "GIA";
            this.colGia.HeaderText = "Giá";
            this.colGia.Name = "colGia";
            this.colGia.ReadOnly = true;
            // 
            // colMaLoai
            // 
            this.colMaLoai.DataPropertyName = "MALOAI";
            this.colMaLoai.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colMaLoai.HeaderText = "Loại";
            this.colMaLoai.Name = "colMaLoai";
            this.colMaLoai.ReadOnly = true;
            this.colMaLoai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaLoai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colMoTa
            // 
            this.colMoTa.DataPropertyName = "MOTA";
            this.colMoTa.HeaderText = "Mô Tả";
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.ReadOnly = true;
            // 
            // frmQL_Mon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 576);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQL_Mon";
            this.Load += new System.EventHandler(this.frmQL_Mon_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).EndInit();
            this.grbCTMon.ResumeLayout(false);
            this.grbCTMon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.grbMon.ResumeLayout(false);
            this.grbMon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhMon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvCTMon;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridView dgvMon;
        private System.Windows.Forms.GroupBox grbCTMon;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.ComboBox cboMaNL;
        private System.Windows.Forms.Button btnGiamNL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTangNL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbMon;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.RichTextBox rtbMoTa;
        private System.Windows.Forms.ComboBox cboMaLoai;
        private System.Windows.Forms.NumericUpDown nudGiaTien;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.PictureBox picAnhMon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
    }
}