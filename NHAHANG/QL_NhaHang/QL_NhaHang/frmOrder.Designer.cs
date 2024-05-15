namespace QL_NhaHang
{
    partial class frmOrder
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInHD = new System.Windows.Forms.Button();
            this.dgvCT = new System.Windows.Forms.DataGridView();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.btnLapHD = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMaDB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbMoTa = new System.Windows.Forms.RichTextBox();
            this.cboMaLoai = new System.Windows.Forms.ComboBox();
            this.nudGiaTien = new System.Windows.Forms.NumericUpDown();
            this.picAnhMon = new System.Windows.Forms.PictureBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvwMon = new System.Windows.Forms.ListView();
            this.imlMon = new System.Windows.Forms.ImageList(this.components);
            this.nudSoluong = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.colMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMon = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoluong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInHD);
            this.panel1.Controls.Add(this.dgvCT);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnXoaCT);
            this.panel1.Controls.Add(this.btnLapHD);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lvwMon);
            this.panel1.Controls.Add(this.nudSoluong);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 524);
            this.panel1.TabIndex = 1;
            // 
            // btnInHD
            // 
            this.btnInHD.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnInHD.Location = new System.Drawing.Point(517, 466);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(104, 42);
            this.btnInHD.TabIndex = 63;
            this.btnInHD.Text = "In Hóa Đơn";
            this.btnInHD.UseVisualStyleBackColor = true;
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // dgvCT
            // 
            this.dgvCT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaMon,
            this.colTenMon,
            this.colGia,
            this.colMaLoai,
            this.colMoTa});
            this.dgvCT.Location = new System.Drawing.Point(16, 218);
            this.dgvCT.MultiSelect = false;
            this.dgvCT.Name = "dgvCT";
            this.dgvCT.ReadOnly = true;
            this.dgvCT.RowHeadersVisible = false;
            this.dgvCT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCT.Size = new System.Drawing.Size(571, 205);
            this.dgvCT.TabIndex = 62;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLamMoi.Location = new System.Drawing.Point(637, 466);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(84, 42);
            this.btnLamMoi.TabIndex = 66;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoaCT.Image = global::QL_NhaHang.Properties.Resources.minus;
            this.btnXoaCT.Location = new System.Drawing.Point(357, 175);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(39, 37);
            this.btnXoaCT.TabIndex = 58;
            this.btnXoaCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaCT.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnXoaCT.UseVisualStyleBackColor = true;
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // btnLapHD
            // 
            this.btnLapHD.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLapHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLapHD.Location = new System.Drawing.Point(374, 466);
            this.btnLapHD.Name = "btnLapHD";
            this.btnLapHD.Size = new System.Drawing.Size(116, 42);
            this.btnLapHD.TabIndex = 62;
            this.btnLapHD.Text = "Lập Hóa Đơn";
            this.btnLapHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLapHD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLapHD.UseVisualStyleBackColor = true;
            this.btnLapHD.Click += new System.EventHandler(this.btnLapHD_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTongTien.Location = new System.Drawing.Point(193, 478);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(158, 20);
            this.txtTongTien.TabIndex = 65;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cboMaDB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rtbMoTa);
            this.groupBox1.Controls.Add(this.cboMaLoai);
            this.groupBox1.Controls.Add(this.nudGiaTien);
            this.groupBox1.Controls.Add(this.picAnhMon);
            this.groupBox1.Controls.Add(this.txtTenMon);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 154);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // cboMaDB
            // 
            this.cboMaDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaDB.FormattingEnabled = true;
            this.cboMaDB.Location = new System.Drawing.Point(314, 56);
            this.cboMaDB.Name = "cboMaDB";
            this.cboMaDB.Size = new System.Drawing.Size(131, 21);
            this.cboMaDB.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã ĐB:";
            // 
            // rtbMoTa
            // 
            this.rtbMoTa.Location = new System.Drawing.Point(64, 97);
            this.rtbMoTa.Name = "rtbMoTa";
            this.rtbMoTa.Size = new System.Drawing.Size(381, 45);
            this.rtbMoTa.TabIndex = 21;
            this.rtbMoTa.Text = "";
            // 
            // cboMaLoai
            // 
            this.cboMaLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaLoai.FormattingEnabled = true;
            this.cboMaLoai.Location = new System.Drawing.Point(64, 51);
            this.cboMaLoai.Name = "cboMaLoai";
            this.cboMaLoai.Size = new System.Drawing.Size(150, 21);
            this.cboMaLoai.TabIndex = 20;
            // 
            // nudGiaTien
            // 
            this.nudGiaTien.Location = new System.Drawing.Point(314, 15);
            this.nudGiaTien.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudGiaTien.Name = "nudGiaTien";
            this.nudGiaTien.Size = new System.Drawing.Size(131, 20);
            this.nudGiaTien.TabIndex = 19;
            // 
            // picAnhMon
            // 
            this.picAnhMon.Location = new System.Drawing.Point(471, 28);
            this.picAnhMon.Name = "picAnhMon";
            this.picAnhMon.Size = new System.Drawing.Size(95, 102);
            this.picAnhMon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnhMon.TabIndex = 0;
            this.picAnhMon.TabStop = false;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(64, 14);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(149, 20);
            this.txtTenMon.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mô Tả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mã Loại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tên Món:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 481);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 64;
            this.label9.Text = "Tổng tiền:";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Image = global::QL_NhaHang.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(312, 175);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(39, 37);
            this.btnAdd.TabIndex = 59;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvwMon
            // 
            this.lvwMon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwMon.HideSelection = false;
            this.lvwMon.LargeImageList = this.imlMon;
            this.lvwMon.Location = new System.Drawing.Point(603, 15);
            this.lvwMon.Name = "lvwMon";
            this.lvwMon.Size = new System.Drawing.Size(154, 408);
            this.lvwMon.SmallImageList = this.imlMon;
            this.lvwMon.TabIndex = 1;
            this.lvwMon.UseCompatibleStateImageBehavior = false;
            this.lvwMon.SelectedIndexChanged += new System.EventHandler(this.lvwMon_SelectedIndexChanged);
            this.lvwMon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwMon_MouseDoubleClick);
            // 
            // imlMon
            // 
            this.imlMon.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imlMon.ImageSize = new System.Drawing.Size(60, 60);
            this.imlMon.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // nudSoluong
            // 
            this.nudSoluong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoluong.Location = new System.Drawing.Point(231, 181);
            this.nudSoluong.Margin = new System.Windows.Forms.Padding(2);
            this.nudSoluong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoluong.Name = "nudSoluong";
            this.nudSoluong.Size = new System.Drawing.Size(68, 23);
            this.nudSoluong.TabIndex = 61;
            this.nudSoluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Số lượng:";
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
            this.colTenMon.DataPropertyName = "MAMON";
            this.colTenMon.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colTenMon.HeaderText = "Tên Món";
            this.colTenMon.Name = "colTenMon";
            this.colTenMon.ReadOnly = true;
            this.colTenMon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTenMon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colGia
            // 
            this.colGia.DataPropertyName = "GIA";
            this.colGia.HeaderText = "Đơn Giá";
            this.colGia.Name = "colGia";
            this.colGia.ReadOnly = true;
            // 
            // colMaLoai
            // 
            this.colMaLoai.DataPropertyName = "SOLUONG";
            this.colMaLoai.HeaderText = "Số lượng";
            this.colMaLoai.Name = "colMaLoai";
            this.colMaLoai.ReadOnly = true;
            this.colMaLoai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colMoTa
            // 
            this.colMoTa.DataPropertyName = "THANHTIEN";
            this.colMoTa.HeaderText = "Thành tiền";
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.ReadOnly = true;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 524);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoluong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picAnhMon;
        private System.Windows.Forms.ListView lvwMon;
        private System.Windows.Forms.RichTextBox rtbMoTa;
        private System.Windows.Forms.ComboBox cboMaLoai;
        private System.Windows.Forms.NumericUpDown nudGiaTien;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudSoluong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvCT;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnLapHD;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ImageList imlMon;
        private System.Windows.Forms.ComboBox cboMaDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMon;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
    }
}