namespace Presentation
{
    partial class frmTraCuuSach
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_Loaisach = new System.Windows.Forms.ComboBox();
            this.checkBox_tacgia = new System.Windows.Forms.CheckBox();
            this.checkBox_loaisach = new System.Windows.Forms.CheckBox();
            this.textBox_Ten = new System.Windows.Forms.TextBox();
            this.textBox_Ma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_tacgia = new System.Windows.Forms.ComboBox();
            this.checkBox_ngonngu = new System.Windows.Forms.CheckBox();
            this.comboBox_ngonngu = new System.Windows.Forms.ComboBox();
            this.checkBox_nhaxb = new System.Windows.Forms.CheckBox();
            this.comboBox_nhaxb = new System.Windows.Forms.ComboBox();
            this.checkBox_giatu = new System.Windows.Forms.CheckBox();
            this.textBox_giatu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_giaden = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_nhaxb);
            this.groupBox1.Controls.Add(this.comboBox_tacgia);
            this.groupBox1.Controls.Add(this.comboBox_ngonngu);
            this.groupBox1.Controls.Add(this.comboBox_Loaisach);
            this.groupBox1.Controls.Add(this.checkBox_tacgia);
            this.groupBox1.Controls.Add(this.checkBox_nhaxb);
            this.groupBox1.Controls.Add(this.checkBox_giatu);
            this.groupBox1.Controls.Add(this.checkBox_ngonngu);
            this.groupBox1.Controls.Add(this.checkBox_loaisach);
            this.groupBox1.Controls.Add(this.textBox_Ten);
            this.groupBox1.Controls.Add(this.textBox_giaden);
            this.groupBox1.Controls.Add(this.textBox_giatu);
            this.groupBox1.Controls.Add(this.textBox_Ma);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiêu chuẩn tra cứu";
            // 
            // comboBox_Loaisach
            // 
            this.comboBox_Loaisach.FormattingEnabled = true;
            this.comboBox_Loaisach.Location = new System.Drawing.Point(87, 60);
            this.comboBox_Loaisach.Name = "comboBox_Loaisach";
            this.comboBox_Loaisach.Size = new System.Drawing.Size(116, 21);
            this.comboBox_Loaisach.TabIndex = 3;
            // 
            // checkBox_tacgia
            // 
            this.checkBox_tacgia.AutoSize = true;
            this.checkBox_tacgia.Location = new System.Drawing.Point(259, 64);
            this.checkBox_tacgia.Name = "checkBox_tacgia";
            this.checkBox_tacgia.Size = new System.Drawing.Size(62, 17);
            this.checkBox_tacgia.TabIndex = 2;
            this.checkBox_tacgia.Text = "Tác giả";
            this.checkBox_tacgia.UseVisualStyleBackColor = true;
            this.checkBox_tacgia.CheckedChanged += new System.EventHandler(this.checkBox_tacgia_CheckedChanged);
            // 
            // checkBox_loaisach
            // 
            this.checkBox_loaisach.AutoSize = true;
            this.checkBox_loaisach.Location = new System.Drawing.Point(18, 62);
            this.checkBox_loaisach.Name = "checkBox_loaisach";
            this.checkBox_loaisach.Size = new System.Drawing.Size(72, 17);
            this.checkBox_loaisach.TabIndex = 2;
            this.checkBox_loaisach.Text = "Loại sách";
            this.checkBox_loaisach.UseVisualStyleBackColor = true;
            this.checkBox_loaisach.CheckedChanged += new System.EventHandler(this.checkBox_loaisach_CheckedChanged);
            // 
            // textBox_Ten
            // 
            this.textBox_Ten.Location = new System.Drawing.Point(314, 18);
            this.textBox_Ten.Name = "textBox_Ten";
            this.textBox_Ten.Size = new System.Drawing.Size(127, 20);
            this.textBox_Ten.TabIndex = 1;
            // 
            // textBox_Ma
            // 
            this.textBox_Ma.Location = new System.Drawing.Point(76, 18);
            this.textBox_Ma.Name = "textBox_Ma";
            this.textBox_Ma.Size = new System.Drawing.Size(127, 20);
            this.textBox_Ma.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách";
            // 
            // comboBox_tacgia
            // 
            this.comboBox_tacgia.FormattingEnabled = true;
            this.comboBox_tacgia.Location = new System.Drawing.Point(337, 60);
            this.comboBox_tacgia.Name = "comboBox_tacgia";
            this.comboBox_tacgia.Size = new System.Drawing.Size(104, 21);
            this.comboBox_tacgia.TabIndex = 3;
            // 
            // checkBox_ngonngu
            // 
            this.checkBox_ngonngu.AutoSize = true;
            this.checkBox_ngonngu.Location = new System.Drawing.Point(18, 106);
            this.checkBox_ngonngu.Name = "checkBox_ngonngu";
            this.checkBox_ngonngu.Size = new System.Drawing.Size(73, 17);
            this.checkBox_ngonngu.TabIndex = 2;
            this.checkBox_ngonngu.Text = "Ngôn ngữ";
            this.checkBox_ngonngu.UseVisualStyleBackColor = true;
            this.checkBox_ngonngu.CheckedChanged += new System.EventHandler(this.checkBox_ngonngu_CheckedChanged);
            // 
            // comboBox_ngonngu
            // 
            this.comboBox_ngonngu.FormattingEnabled = true;
            this.comboBox_ngonngu.Location = new System.Drawing.Point(87, 102);
            this.comboBox_ngonngu.Name = "comboBox_ngonngu";
            this.comboBox_ngonngu.Size = new System.Drawing.Size(116, 21);
            this.comboBox_ngonngu.TabIndex = 3;
            // 
            // checkBox_nhaxb
            // 
            this.checkBox_nhaxb.AutoSize = true;
            this.checkBox_nhaxb.Location = new System.Drawing.Point(258, 104);
            this.checkBox_nhaxb.Name = "checkBox_nhaxb";
            this.checkBox_nhaxb.Size = new System.Drawing.Size(63, 17);
            this.checkBox_nhaxb.TabIndex = 2;
            this.checkBox_nhaxb.Text = "Nhà XB";
            this.checkBox_nhaxb.UseVisualStyleBackColor = true;
            this.checkBox_nhaxb.CheckedChanged += new System.EventHandler(this.checkBox_nhaxb_CheckedChanged);
            // 
            // comboBox_nhaxb
            // 
            this.comboBox_nhaxb.FormattingEnabled = true;
            this.comboBox_nhaxb.Location = new System.Drawing.Point(337, 100);
            this.comboBox_nhaxb.Name = "comboBox_nhaxb";
            this.comboBox_nhaxb.Size = new System.Drawing.Size(104, 21);
            this.comboBox_nhaxb.TabIndex = 3;
            // 
            // checkBox_giatu
            // 
            this.checkBox_giatu.AutoSize = true;
            this.checkBox_giatu.Location = new System.Drawing.Point(18, 146);
            this.checkBox_giatu.Name = "checkBox_giatu";
            this.checkBox_giatu.Size = new System.Drawing.Size(54, 17);
            this.checkBox_giatu.TabIndex = 2;
            this.checkBox_giatu.Text = "Giá từ";
            this.checkBox_giatu.UseVisualStyleBackColor = true;
            this.checkBox_giatu.CheckedChanged += new System.EventHandler(this.checkBox_giatu_CheckedChanged);
            // 
            // textBox_giatu
            // 
            this.textBox_giatu.Location = new System.Drawing.Point(78, 143);
            this.textBox_giatu.Name = "textBox_giatu";
            this.textBox_giatu.Size = new System.Drawing.Size(96, 20);
            this.textBox_giatu.TabIndex = 1;
            this.textBox_giatu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_giatu_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "VND    đến";
            // 
            // textBox_giaden
            // 
            this.textBox_giaden.Location = new System.Drawing.Point(247, 143);
            this.textBox_giaden.Name = "textBox_giaden";
            this.textBox_giaden.Size = new System.Drawing.Size(96, 20);
            this.textBox_giaden.TabIndex = 1;
            this.textBox_giaden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_giaden_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "VND";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(9, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(495, 157);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả tra cứu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(479, 116);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tra cứu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTraCuuSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 410);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTraCuuSach";
            this.Text = "frmTraCuu";
            this.Load += new System.EventHandler(this.frmTraCuuSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Ma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Loaisach;
        private System.Windows.Forms.CheckBox checkBox_loaisach;
        private System.Windows.Forms.TextBox textBox_Ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_tacgia;
        private System.Windows.Forms.ComboBox comboBox_nhaxb;
        private System.Windows.Forms.ComboBox comboBox_tacgia;
        private System.Windows.Forms.ComboBox comboBox_ngonngu;
        private System.Windows.Forms.CheckBox checkBox_nhaxb;
        private System.Windows.Forms.CheckBox checkBox_giatu;
        private System.Windows.Forms.CheckBox checkBox_ngonngu;
        private System.Windows.Forms.TextBox textBox_giaden;
        private System.Windows.Forms.TextBox textBox_giatu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}