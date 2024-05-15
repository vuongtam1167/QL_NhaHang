namespace QL_NhaHang
{
    partial class frmXemBaoCao
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
            this.rpvXemBC = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvXemBC
            // 
            this.rpvXemBC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvXemBC.LocalReport.ReportEmbeddedResource = "QL_NhaHang.rptHOADON.rdlc";
            this.rpvXemBC.Location = new System.Drawing.Point(0, 0);
            this.rpvXemBC.Name = "rpvXemBC";
            this.rpvXemBC.ServerReport.BearerToken = null;
            this.rpvXemBC.Size = new System.Drawing.Size(800, 450);
            this.rpvXemBC.TabIndex = 0;
            // 
            // frmXemBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvXemBC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmXemBaoCao";
            this.ShowIcon = false;
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.frmXemBaoCao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvXemBC;
    }
}