namespace Presentation
{
    partial class FrmReportSemester
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.comSemester = new System.Windows.Forms.ComboBox();
            this.crystalReportSemeter = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.comSemester);
            this.splitContainer1.Panel1.UseWaitCursor = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.crystalReportSemeter);
            this.splitContainer1.Panel2.UseWaitCursor = true;
            this.splitContainer1.Size = new System.Drawing.Size(959, 485);
            this.splitContainer1.SplitterDistance = 195;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Chọn Học Kỳ";
            this.label2.UseWaitCursor = true;
            // 
            // comSemester
            // 
            this.comSemester.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comSemester.BackColor = System.Drawing.Color.PeachPuff;
            this.comSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comSemester.FormattingEnabled = true;
            this.comSemester.Location = new System.Drawing.Point(31, 101);
            this.comSemester.Name = "comSemester";
            this.comSemester.Size = new System.Drawing.Size(151, 23);
            this.comSemester.TabIndex = 16;
            this.comSemester.UseWaitCursor = true;
            this.comSemester.SelectedIndexChanged += new System.EventHandler(this.comSemester_SelectedIndexChanged);
            // 
            // crystalReportSemeter
            // 
            this.crystalReportSemeter.ActiveViewIndex = -1;
            this.crystalReportSemeter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.crystalReportSemeter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportSemeter.DisplayGroupTree = false;
            this.crystalReportSemeter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportSemeter.Location = new System.Drawing.Point(0, 0);
            this.crystalReportSemeter.Name = "crystalReportSemeter";
            this.crystalReportSemeter.SelectionFormula = "";
            this.crystalReportSemeter.Size = new System.Drawing.Size(758, 485);
            this.crystalReportSemeter.TabIndex = 12;
            this.crystalReportSemeter.UseWaitCursor = true;
            this.crystalReportSemeter.ViewTimeSelectionFormula = "";
            // 
            // FrmReportSemester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(959, 485);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "FrmReportSemester";
            this.Text = "Báo Cáo Tổng Kết Học Kỳ";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.FrmReportSemester_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox comSemester;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportSemeter;
        private System.Windows.Forms.Label label2;




    }
}