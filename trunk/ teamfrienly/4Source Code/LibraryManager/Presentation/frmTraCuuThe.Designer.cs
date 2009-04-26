namespace Presentation
{
    partial class frmTraCuuThe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuThe));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_ngaysinh = new System.Windows.Forms.CheckBox();
            this.checkBox_ngayhethan = new System.Windows.Forms.CheckBox();
            this.dateTimePicker_sinhden = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_sinhtu = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_capden = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_hetden = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_hettu = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_captu = new System.Windows.Forms.DateTimePicker();
            this.checkBox_ngaycap = new System.Windows.Forms.CheckBox();
            this.comboBox_loaithe = new System.Windows.Forms.ComboBox();
            this.checkBox_loaithe = new System.Windows.Forms.CheckBox();
            this.textBox_Ten = new System.Windows.Forms.TextBox();
            this.textBox_Ma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_ngaysinh);
            this.groupBox1.Controls.Add(this.checkBox_ngayhethan);
            this.groupBox1.Controls.Add(this.dateTimePicker_sinhden);
            this.groupBox1.Controls.Add(this.dateTimePicker_sinhtu);
            this.groupBox1.Controls.Add(this.dateTimePicker_capden);
            this.groupBox1.Controls.Add(this.dateTimePicker_hetden);
            this.groupBox1.Controls.Add(this.dateTimePicker_hettu);
            this.groupBox1.Controls.Add(this.dateTimePicker_captu);
            this.groupBox1.Controls.Add(this.checkBox_ngaycap);
            this.groupBox1.Controls.Add(this.comboBox_loaithe);
            this.groupBox1.Controls.Add(this.checkBox_loaithe);
            this.groupBox1.Controls.Add(this.textBox_Ten);
            this.groupBox1.Controls.Add(this.textBox_Ma);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 126);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(784, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiêu chuẩn tra cứu";
            // 
            // checkBox_ngaysinh
            // 
            this.checkBox_ngaysinh.AutoSize = true;
            this.checkBox_ngaysinh.Location = new System.Drawing.Point(45, 111);
            this.checkBox_ngaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_ngaysinh.Name = "checkBox_ngaysinh";
            this.checkBox_ngaysinh.Size = new System.Drawing.Size(219, 21);
            this.checkBox_ngaysinh.TabIndex = 7;
            this.checkBox_ngaysinh.Text = "Ngày sinh trong khoảng từ";
            this.checkBox_ngaysinh.UseVisualStyleBackColor = true;
            this.checkBox_ngaysinh.CheckedChanged += new System.EventHandler(this.checkBox_ngaysinh_CheckedChanged);
            // 
            // checkBox_ngayhethan
            // 
            this.checkBox_ngayhethan.AutoSize = true;
            this.checkBox_ngayhethan.Location = new System.Drawing.Point(46, 202);
            this.checkBox_ngayhethan.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_ngayhethan.Name = "checkBox_ngayhethan";
            this.checkBox_ngayhethan.Size = new System.Drawing.Size(244, 21);
            this.checkBox_ngayhethan.TabIndex = 6;
            this.checkBox_ngayhethan.Text = "Ngày hết hạn trong khoảng từ";
            this.checkBox_ngayhethan.UseVisualStyleBackColor = true;
            this.checkBox_ngayhethan.CheckedChanged += new System.EventHandler(this.checkBox_ngayhethan_CheckedChanged);
            // 
            // dateTimePicker_sinhden
            // 
            this.dateTimePicker_sinhden.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_sinhden.Location = new System.Drawing.Point(534, 105);
            this.dateTimePicker_sinhden.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_sinhden.Name = "dateTimePicker_sinhden";
            this.dateTimePicker_sinhden.Size = new System.Drawing.Size(131, 23);
            this.dateTimePicker_sinhden.TabIndex = 5;
            // 
            // dateTimePicker_sinhtu
            // 
            this.dateTimePicker_sinhtu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_sinhtu.Location = new System.Drawing.Point(320, 107);
            this.dateTimePicker_sinhtu.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_sinhtu.Name = "dateTimePicker_sinhtu";
            this.dateTimePicker_sinhtu.Size = new System.Drawing.Size(131, 23);
            this.dateTimePicker_sinhtu.TabIndex = 5;
            // 
            // dateTimePicker_capden
            // 
            this.dateTimePicker_capden.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_capden.Location = new System.Drawing.Point(534, 155);
            this.dateTimePicker_capden.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_capden.Name = "dateTimePicker_capden";
            this.dateTimePicker_capden.Size = new System.Drawing.Size(131, 23);
            this.dateTimePicker_capden.TabIndex = 5;
            // 
            // dateTimePicker_hetden
            // 
            this.dateTimePicker_hetden.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_hetden.Location = new System.Drawing.Point(534, 200);
            this.dateTimePicker_hetden.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_hetden.Name = "dateTimePicker_hetden";
            this.dateTimePicker_hetden.Size = new System.Drawing.Size(131, 23);
            this.dateTimePicker_hetden.TabIndex = 5;
            // 
            // dateTimePicker_hettu
            // 
            this.dateTimePicker_hettu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_hettu.Location = new System.Drawing.Point(320, 200);
            this.dateTimePicker_hettu.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_hettu.Name = "dateTimePicker_hettu";
            this.dateTimePicker_hettu.Size = new System.Drawing.Size(131, 23);
            this.dateTimePicker_hettu.TabIndex = 5;
            // 
            // dateTimePicker_captu
            // 
            this.dateTimePicker_captu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_captu.Location = new System.Drawing.Point(320, 157);
            this.dateTimePicker_captu.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_captu.Name = "dateTimePicker_captu";
            this.dateTimePicker_captu.Size = new System.Drawing.Size(131, 23);
            this.dateTimePicker_captu.TabIndex = 5;
            // 
            // checkBox_ngaycap
            // 
            this.checkBox_ngaycap.AutoSize = true;
            this.checkBox_ngaycap.Location = new System.Drawing.Point(46, 155);
            this.checkBox_ngaycap.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_ngaycap.Name = "checkBox_ngaycap";
            this.checkBox_ngaycap.Size = new System.Drawing.Size(215, 21);
            this.checkBox_ngaycap.TabIndex = 4;
            this.checkBox_ngaycap.Text = "Ngày cấp trong khoảng từ";
            this.checkBox_ngaycap.UseVisualStyleBackColor = true;
            this.checkBox_ngaycap.CheckedChanged += new System.EventHandler(this.checkBox_ngaycap_CheckedChanged);
            // 
            // comboBox_loaithe
            // 
            this.comboBox_loaithe.FormattingEnabled = true;
            this.comboBox_loaithe.Location = new System.Drawing.Point(152, 66);
            this.comboBox_loaithe.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_loaithe.Name = "comboBox_loaithe";
            this.comboBox_loaithe.Size = new System.Drawing.Size(170, 24);
            this.comboBox_loaithe.TabIndex = 3;
            // 
            // checkBox_loaithe
            // 
            this.checkBox_loaithe.AutoSize = true;
            this.checkBox_loaithe.Location = new System.Drawing.Point(46, 69);
            this.checkBox_loaithe.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_loaithe.Name = "checkBox_loaithe";
            this.checkBox_loaithe.Size = new System.Drawing.Size(86, 21);
            this.checkBox_loaithe.TabIndex = 2;
            this.checkBox_loaithe.Text = "Loại thẻ";
            this.checkBox_loaithe.UseVisualStyleBackColor = true;
            this.checkBox_loaithe.CheckedChanged += new System.EventHandler(this.checkBox_loaithe_CheckedChanged);
            // 
            // textBox_Ten
            // 
            this.textBox_Ten.Location = new System.Drawing.Point(458, 27);
            this.textBox_Ten.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Ten.Name = "textBox_Ten";
            this.textBox_Ten.Size = new System.Drawing.Size(210, 23);
            this.textBox_Ten.TabIndex = 1;
            // 
            // textBox_Ma
            // 
            this.textBox_Ma.Location = new System.Drawing.Point(153, 29);
            this.textBox_Ma.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Ma.Name = "textBox_Ma";
            this.textBox_Ma.Size = new System.Drawing.Size(170, 23);
            this.textBox_Ma.TabIndex = 1;
            this.textBox_Ma.Text = "00001";
            this.textBox_Ma.Click += new System.EventHandler(this.textBox_Ma_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đến";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên độc giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Thẻ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox2.Location = new System.Drawing.Point(13, 437);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(792, 178);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả tra cứu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(8, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(799, 143);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Ma";
            this.Column1.HeaderText = "Mã thẻ";
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "LoaiThe";
            this.Column2.HeaderText = "Loại thẻ";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayCap";
            this.Column3.HeaderText = "Ngày cấp";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgayHetHan";
            this.Column4.HeaderText = "Ngày hết hạn";
            this.Column4.Name = "Column4";
            this.Column4.Width = 140;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TenDocGia";
            this.Column5.HeaderText = "Tên độc giả";
            this.Column5.Name = "Column5";
            this.Column5.Width = 140;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NgaySinh";
            this.Column6.HeaderText = "Ngày sinh";
            this.Column6.Name = "Column6";
            this.Column6.Width = 140;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.ForeColor = System.Drawing.Color.Firebrick;
            this.button1.Location = new System.Drawing.Point(641, 391);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tra cứu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(139, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(544, 55);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tra Cứu Thông Tin Thẻ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Presentation.Properties.Resources.abc1;
            this.pictureBox1.Location = new System.Drawing.Point(61, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 71);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.ForeColor = System.Drawing.Color.Firebrick;
            this.button2.Location = new System.Drawing.Point(649, 623);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 38);
            this.button2.TabIndex = 8;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmTraCuuThe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(819, 671);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTraCuuThe";
            this.Text = "Tra Cứu Thẻ Sách";
            this.Load += new System.EventHandler(this.frmTraCuuThe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_ngaycap;
        private System.Windows.Forms.ComboBox comboBox_loaithe;
        private System.Windows.Forms.CheckBox checkBox_loaithe;
        private System.Windows.Forms.TextBox textBox_Ma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox_ngaysinh;
        private System.Windows.Forms.CheckBox checkBox_ngayhethan;
        private System.Windows.Forms.DateTimePicker dateTimePicker_sinhden;
        private System.Windows.Forms.DateTimePicker dateTimePicker_sinhtu;
        private System.Windows.Forms.DateTimePicker dateTimePicker_hetden;
        private System.Windows.Forms.DateTimePicker dateTimePicker_hettu;
        private System.Windows.Forms.DateTimePicker dateTimePicker_captu;
        private System.Windows.Forms.TextBox textBox_Ten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_capden;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}