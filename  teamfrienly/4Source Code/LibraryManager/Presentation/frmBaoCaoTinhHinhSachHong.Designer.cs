namespace Presentation
{
    partial class frmBaoCaoTinhHinhSachHong
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
            this.cptvBaoCaoTinhHinhMuonSachHong = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(731, 23);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // cptvBaoCaoTinhHinhMuonSachHong
            // 
            this.cptvBaoCaoTinhHinhMuonSachHong.ActiveViewIndex = -1;
            this.cptvBaoCaoTinhHinhMuonSachHong.AutoSize = true;
            this.cptvBaoCaoTinhHinhMuonSachHong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cptvBaoCaoTinhHinhMuonSachHong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cptvBaoCaoTinhHinhMuonSachHong.Location = new System.Drawing.Point(0, 49);
            this.cptvBaoCaoTinhHinhMuonSachHong.Name = "cptvBaoCaoTinhHinhMuonSachHong";
            this.cptvBaoCaoTinhHinhMuonSachHong.SelectionFormula = "";
            this.cptvBaoCaoTinhHinhMuonSachHong.Size = new System.Drawing.Size(820, 301);
            this.cptvBaoCaoTinhHinhMuonSachHong.TabIndex = 11;
            this.cptvBaoCaoTinhHinhMuonSachHong.ViewTimeSelectionFormula = "";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 49);
            this.panel1.TabIndex = 10;
            // 
            // frmBaoCaoTinhHinhSachHong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 350);
            this.Controls.Add(this.cptvBaoCaoTinhHinhMuonSachHong);
            this.Controls.Add(this.panel1);
            this.Name = "frmBaoCaoTinhHinhSachHong";
            this.Text = "Báo Cáo Tình  Hình Sách Hỏng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer cptvBaoCaoTinhHinhMuonSachHong;
        private System.Windows.Forms.Panel panel1;
    }
}