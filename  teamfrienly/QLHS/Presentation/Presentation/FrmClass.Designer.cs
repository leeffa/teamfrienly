namespace Presentation
{
    partial class FrmClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClass));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comKhoi = new System.Windows.Forms.ComboBox();
            this.comClass = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoLopHienTai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.butCheckAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Khôi = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butUpdate = new System.Windows.Forms.Button();
            this.butInsert = new System.Windows.Forms.Button();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(822, 430);
            this.splitContainer2.SplitterDistance = 63;
            this.splitContainer2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(170, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(548, 47);
            this.label5.TabIndex = 29;
            this.label5.Text = "Chỉnh Sửa Thông Tin Lớp Học";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(822, 363);
            this.splitContainer1.SplitterDistance = 207;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comKhoi);
            this.groupBox2.Controls.Add(this.comClass);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 363);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(27, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "Lớp ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(9, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Khối";
            // 
            // comKhoi
            // 
            this.comKhoi.BackColor = System.Drawing.Color.MistyRose;
            this.comKhoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comKhoi.FormattingEnabled = true;
            this.comKhoi.Location = new System.Drawing.Point(29, 58);
            this.comKhoi.Name = "comKhoi";
            this.comKhoi.Size = new System.Drawing.Size(151, 23);
            this.comKhoi.TabIndex = 23;
            this.comKhoi.SelectedIndexChanged += new System.EventHandler(this.comKhoi_SelectedIndexChanged);
            // 
            // comClass
            // 
            this.comClass.BackColor = System.Drawing.Color.MistyRose;
            this.comClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comClass.Enabled = false;
            this.comClass.FormattingEnabled = true;
            this.comClass.Location = new System.Drawing.Point(44, 105);
            this.comClass.Name = "comClass";
            this.comClass.Size = new System.Drawing.Size(151, 23);
            this.comClass.TabIndex = 25;
            this.comClass.SelectionChangeCommitted += new System.EventHandler(this.comClass_SelectionChangeCommitted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoLopHienTai);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.butCheckAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Khôi);
            this.groupBox1.Controls.Add(this.txtTenLop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.butUpdate);
            this.groupBox1.Controls.Add(this.butInsert);
            this.groupBox1.Controls.Add(this.txtMaLop);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 363);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Lớp Học";
            // 
            // txtSoLopHienTai
            // 
            this.txtSoLopHienTai.BackColor = System.Drawing.Color.Wheat;
            this.txtSoLopHienTai.Enabled = false;
            this.txtSoLopHienTai.Location = new System.Drawing.Point(264, 163);
            this.txtSoLopHienTai.Name = "txtSoLopHienTai";
            this.txtSoLopHienTai.Size = new System.Drawing.Size(106, 21);
            this.txtSoLopHienTai.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Số lớp hiện tại :";
            // 
            // butCheckAdd
            // 
            this.butCheckAdd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.butCheckAdd.Location = new System.Drawing.Point(392, 87);
            this.butCheckAdd.Name = "butCheckAdd";
            this.butCheckAdd.Size = new System.Drawing.Size(99, 33);
            this.butCheckAdd.TabIndex = 26;
            this.butCheckAdd.Text = "Check Thêm";
            this.butCheckAdd.UseVisualStyleBackColor = false;
            this.butCheckAdd.Click += new System.EventHandler(this.butCheckAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-52, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Lớp :";
            // 
            // Khôi
            // 
            this.Khôi.AutoSize = true;
            this.Khôi.Location = new System.Drawing.Point(-52, 90);
            this.Khôi.Name = "Khôi";
            this.Khôi.Size = new System.Drawing.Size(44, 15);
            this.Khôi.TabIndex = 22;
            this.Khôi.Text = "Khối :";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Enabled = false;
            this.txtTenLop.Location = new System.Drawing.Point(187, 128);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(184, 21);
            this.txtTenLop.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên Lớp :";
            // 
            // butUpdate
            // 
            this.butUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butUpdate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.butUpdate.Location = new System.Drawing.Point(254, 295);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(105, 41);
            this.butUpdate.TabIndex = 19;
            this.butUpdate.Text = "Cập Nhật";
            this.butUpdate.UseVisualStyleBackColor = false;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // butInsert
            // 
            this.butInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butInsert.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.butInsert.Location = new System.Drawing.Point(145, 295);
            this.butInsert.Name = "butInsert";
            this.butInsert.Size = new System.Drawing.Size(99, 41);
            this.butInsert.TabIndex = 18;
            this.butInsert.Text = "Thêm";
            this.butInsert.UseVisualStyleBackColor = false;
            this.butInsert.Click += new System.EventHandler(this.butInsert_Click);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Enabled = false;
            this.txtMaLop.Location = new System.Drawing.Point(187, 87);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(184, 21);
            this.txtMaLop.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(458, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 41);
            this.button1.TabIndex = 16;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã Lớp :";
            // 
            // FrmClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(822, 430);
            this.Controls.Add(this.splitContainer2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmClass";
            this.Text = "Thông Tin Lớp";
            this.Load += new System.EventHandler(this.FrmClass_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comKhoi;
        private System.Windows.Forms.ComboBox comClass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoLopHienTai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butCheckAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Khôi;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.Button butInsert;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;


    }
}