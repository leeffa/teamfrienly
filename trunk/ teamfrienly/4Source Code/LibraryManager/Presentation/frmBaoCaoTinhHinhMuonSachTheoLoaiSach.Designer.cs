namespace Presentation
{
    partial class frmBaoCaoTinhHinhMuonSachTheoLoaiSach
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
            this.btnShow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cptvBaoCaoTinhHinhMuonSachTheoLoaiSach = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(731, 20);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 46);
            this.panel1.TabIndex = 8;
            // 
            // cptvBaoCaoTinhHinhMuonSachTheoLoaiSach
            // 
            this.cptvBaoCaoTinhHinhMuonSachTheoLoaiSach.ActiveViewIndex = -1;
            this.cptvBaoCaoTinhHinhMuonSachTheoLoaiSach.AutoSize = true;
            this.cptvBaoCaoTinhHinhMuonSachTheoLoaiSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cptvBaoCaoTinhHinhMuonSachTheoLoaiSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cptvBaoCaoTinhHinhMuonSachTheoLoaiSach.Location = new System.Drawing.Point(0, 46);
            this.cptvBaoCaoTinhHinhMuonSachTheoLoaiSach.Name = "cptvBaoCaoTinhHinhMuonSachTheoLoaiSach";
            this.cptvBaoCaoTinhHinhMuonSachTheoLoaiSach.SelectionFormula = "";
            this.cptvBaoCaoTinhHinhMuonSachTheoLoaiSach.Size = new System.Drawing.Size(827, 320);
            this.cptvBaoCaoTinhHinhMuonSachTheoLoaiSach.TabIndex = 9;
            this.cptvBaoCaoTinhHinhMuonSachTheoLoaiSach.ViewTimeSelectionFormula = "";
            // 
            // frmBaoCaoTinhHinhMuonSachTheoLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 366);
            this.Controls.Add(this.cptvBaoCaoTinhHinhMuonSachTheoLoaiSach);
            this.Controls.Add(this.panel1);
            this.Name = "frmBaoCaoTinhHinhMuonSachTheoLoaiSach";
            this.Text = "Báo Cáo Tình Hình Mượn Sách Theo Thể Loại";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer cptvBaoCaoTinhHinhMuonSachTheoLoaiSach;
    }
}