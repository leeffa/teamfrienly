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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.cptvBaoCaoTinhHinhMuonSachHong = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 0);
            this.panel1.TabIndex = 10;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.btnHienThi);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cptvBaoCaoTinhHinhMuonSachHong);
            this.splitContainer1.Size = new System.Drawing.Size(804, 350);
            this.splitContainer1.SplitterDistance = 44;
            this.splitContainer1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(711, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHienThi.Location = new System.Drawing.Point(619, 12);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(75, 23);
            this.btnHienThi.TabIndex = 1;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // cptvBaoCaoTinhHinhMuonSachHong
            // 
            this.cptvBaoCaoTinhHinhMuonSachHong.ActiveViewIndex = -1;
            this.cptvBaoCaoTinhHinhMuonSachHong.AutoSize = true;
            this.cptvBaoCaoTinhHinhMuonSachHong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cptvBaoCaoTinhHinhMuonSachHong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cptvBaoCaoTinhHinhMuonSachHong.Location = new System.Drawing.Point(0, 0);
            this.cptvBaoCaoTinhHinhMuonSachHong.Name = "cptvBaoCaoTinhHinhMuonSachHong";
            this.cptvBaoCaoTinhHinhMuonSachHong.SelectionFormula = "";
            this.cptvBaoCaoTinhHinhMuonSachHong.Size = new System.Drawing.Size(804, 302);
            this.cptvBaoCaoTinhHinhMuonSachHong.TabIndex = 12;
            this.cptvBaoCaoTinhHinhMuonSachHong.ViewTimeSelectionFormula = "";
            // 
            // frmBaoCaoTinhHinhSachHong
            // 
            this.AcceptButton = this.btnHienThi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(804, 350);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "frmBaoCaoTinhHinhSachHong";
            this.Text = "Báo Cáo Tình  Hình Sách Hỏng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer cptvBaoCaoTinhHinhMuonSachHong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHienThi;
    }
}