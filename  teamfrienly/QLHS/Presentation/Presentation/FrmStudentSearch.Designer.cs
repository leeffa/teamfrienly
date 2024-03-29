namespace Presentation
{
    partial class FrmStudentSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentSearch));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkNameClass = new System.Windows.Forms.CheckBox();
            this.checkMark = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericEnd = new System.Windows.Forms.NumericUpDown();
            this.numericStart = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkSearchBirthday = new System.Windows.Forms.CheckBox();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.comClass = new System.Windows.Forms.ComboBox();
            this.txtIDStudent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridResult = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTBHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTBHK2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butSearch = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStart)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(915, 606);
            this.splitContainer1.SplitterDistance = 526;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(915, 526);
            this.splitContainer2.SplitterDistance = 327;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer3.Size = new System.Drawing.Size(915, 327);
            this.splitContainer3.SplitterDistance = 102;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 102);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 38.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(240, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(431, 60);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tra Cứu Học Sinh";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkNameClass);
            this.groupBox3.Controls.Add(this.butSearch);
            this.groupBox3.Controls.Add(this.checkMark);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.numericEnd);
            this.groupBox3.Controls.Add(this.numericStart);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.checkSearchBirthday);
            this.groupBox3.Controls.Add(this.dateTimeStart);
            this.groupBox3.Controls.Add(this.dateTimeEnd);
            this.groupBox3.Controls.Add(this.comClass);
            this.groupBox3.Controls.Add(this.txtIDStudent);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(915, 220);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Tra Cứu";
            // 
            // checkNameClass
            // 
            this.checkNameClass.AutoSize = true;
            this.checkNameClass.Location = new System.Drawing.Point(626, 43);
            this.checkNameClass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkNameClass.Name = "checkNameClass";
            this.checkNameClass.Size = new System.Drawing.Size(58, 19);
            this.checkNameClass.TabIndex = 39;
            this.checkNameClass.Text = "Lớp :";
            this.checkNameClass.UseVisualStyleBackColor = true;
            this.checkNameClass.CheckedChanged += new System.EventHandler(this.checkNameClass_CheckedChanged);
            // 
            // checkMark
            // 
            this.checkMark.AutoSize = true;
            this.checkMark.Location = new System.Drawing.Point(31, 124);
            this.checkMark.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkMark.Name = "checkMark";
            this.checkMark.Size = new System.Drawing.Size(101, 19);
            this.checkMark.TabIndex = 37;
            this.checkMark.Text = "Điểm TB Từ";
            this.checkMark.UseVisualStyleBackColor = true;
            this.checkMark.CheckedChanged += new System.EventHandler(this.checkDTB_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "=====>";
            // 
            // numericEnd
            // 
            this.numericEnd.Enabled = false;
            this.numericEnd.Location = new System.Drawing.Point(463, 123);
            this.numericEnd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericEnd.Name = "numericEnd";
            this.numericEnd.Size = new System.Drawing.Size(155, 21);
            this.numericEnd.TabIndex = 35;
            this.numericEnd.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericStart
            // 
            this.numericStart.Enabled = false;
            this.numericStart.Location = new System.Drawing.Point(155, 125);
            this.numericStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericStart.Name = "numericStart";
            this.numericStart.Size = new System.Drawing.Size(160, 21);
            this.numericStart.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Tên Học Sinh :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(434, 37);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 21);
            this.txtName.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "=====>";
            // 
            // checkSearchBirthday
            // 
            this.checkSearchBirthday.AutoSize = true;
            this.checkSearchBirthday.Location = new System.Drawing.Point(31, 83);
            this.checkSearchBirthday.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkSearchBirthday.Name = "checkSearchBirthday";
            this.checkSearchBirthday.Size = new System.Drawing.Size(111, 19);
            this.checkSearchBirthday.TabIndex = 29;
            this.checkSearchBirthday.Text = "Ngày Sinh Từ";
            this.checkSearchBirthday.UseVisualStyleBackColor = true;
            this.checkSearchBirthday.Click += new System.EventHandler(this.checkSearchBirthday_CheckedChanged);
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Enabled = false;
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeStart.Location = new System.Drawing.Point(158, 83);
            this.dateTimeStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(159, 21);
            this.dateTimeStart.TabIndex = 28;
            this.dateTimeStart.Value = new System.DateTime(1989, 1, 1, 20, 46, 0, 0);
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Enabled = false;
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEnd.Location = new System.Drawing.Point(463, 79);
            this.dateTimeEnd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimeEnd.MinDate = new System.DateTime(1989, 1, 1, 0, 0, 0, 0);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(152, 21);
            this.dateTimeEnd.TabIndex = 27;
            this.dateTimeEnd.Value = new System.DateTime(1994, 1, 1, 20, 44, 0, 0);
            // 
            // comClass
            // 
            this.comClass.BackColor = System.Drawing.Color.LightPink;
            this.comClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comClass.Enabled = false;
            this.comClass.FormattingEnabled = true;
            this.comClass.Location = new System.Drawing.Point(688, 39);
            this.comClass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comClass.Name = "comClass";
            this.comClass.Size = new System.Drawing.Size(181, 23);
            this.comClass.TabIndex = 26;
            this.comClass.SelectedIndexChanged += new System.EventHandler(this.comClass_SelectedIndexChanged);
            // 
            // txtIDStudent
            // 
            this.txtIDStudent.BackColor = System.Drawing.Color.Khaki;
            this.txtIDStudent.Location = new System.Drawing.Point(136, 37);
            this.txtIDStudent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIDStudent.Name = "txtIDStudent";
            this.txtIDStudent.Size = new System.Drawing.Size(181, 21);
            this.txtIDStudent.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã Học Sinh :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LimeGreen;
            this.groupBox2.Controls.Add(this.dataGridResult);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(915, 194);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết Quả Tra Cứu";
            // 
            // dataGridResult
            // 
            this.dataGridResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaHocSinh,
            this.TenHocSinh,
            this.NgaySinh,
            this.TenLop,
            this.DTBHK,
            this.DTBHK2});
            this.dataGridResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridResult.Location = new System.Drawing.Point(4, 17);
            this.dataGridResult.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridResult.Name = "dataGridResult";
            this.dataGridResult.RowHeadersVisible = false;
            this.dataGridResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridResult.Size = new System.Drawing.Size(907, 174);
            this.dataGridResult.TabIndex = 33;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MaHocSinh
            // 
            this.MaHocSinh.DataPropertyName = "MaHocSinh";
            this.MaHocSinh.HeaderText = "Mã Học Sinh";
            this.MaHocSinh.Name = "MaHocSinh";
            // 
            // TenHocSinh
            // 
            this.TenHocSinh.DataPropertyName = "TenHocSinh";
            this.TenHocSinh.HeaderText = "Tên Học Sinh";
            this.TenHocSinh.Name = "TenHocSinh";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // TenLop
            // 
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.HeaderText = "Tên Lớp";
            this.TenLop.Name = "TenLop";
            // 
            // DTBHK
            // 
            this.DTBHK.DataPropertyName = "DBHK1";
            this.DTBHK.HeaderText = "Điểm TB HK1";
            this.DTBHK.Name = "DTBHK";
            // 
            // DTBHK2
            // 
            this.DTBHK2.DataPropertyName = "DBHK2";
            this.DTBHK2.HeaderText = "Điểm TB HK2";
            this.DTBHK2.Name = "DTBHK2";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.butExit);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(915, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation.Properties.Resources.abc1;
            this.pictureBox1.Location = new System.Drawing.Point(136, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 75);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // butSearch
            // 
            this.butSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.butSearch.Image = global::Presentation.Properties.Resources.abc;
            this.butSearch.Location = new System.Drawing.Point(463, 153);
            this.butSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(169, 64);
            this.butSearch.TabIndex = 38;
            this.butSearch.Text = "Tra                   Cứu";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // butExit
            // 
            this.butExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butExit.Image = global::Presentation.Properties.Resources.Shutdown;
            this.butExit.Location = new System.Drawing.Point(693, 23);
            this.butExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(116, 40);
            this.butExit.TabIndex = 24;
            this.butExit.Text = "                      ";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // FrmStudentSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(915, 606);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmStudentSearch";
            this.Text = "Tra Cứu Học Sinh";
            this.Load += new System.EventHandler(this.FrmStudentSearch_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkNameClass;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.CheckBox checkMark;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericEnd;
        private System.Windows.Forms.NumericUpDown numericStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkSearchBirthday;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.ComboBox comClass;
        private System.Windows.Forms.TextBox txtIDStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTBHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTBHK2;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}