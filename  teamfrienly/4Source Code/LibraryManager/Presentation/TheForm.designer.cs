namespace Presentation
{
    partial class TheForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbLoaiThe = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNgayCapNgay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNgayHetHanNgay = new System.Windows.Forms.TextBox();
            this.txtNgayCapThang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNgayHetHanThang = new System.Windows.Forms.TextBox();
            this.txtNgayCapNam = new System.Windows.Forms.TextBox();
            this.txtNgaySinhNam = new System.Windows.Forms.TextBox();
            this.txtNgayHetHanNam = new System.Windows.Forms.TextBox();
            this.txtNgaySinhNgay = new System.Windows.Forms.TextBox();
            this.txtNgaySinhThang = new System.Windows.Forms.TextBox();
            this.txtTenDocGia = new System.Windows.Forms.TextBox();
            this.txtMaThe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvThe = new System.Windows.Forms.DataGridView();
            this.MaThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btLamLai = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbLoaiThe);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNgayCapNgay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNgayHetHanNgay);
            this.groupBox1.Controls.Add(this.txtNgayCapThang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNgayHetHanThang);
            this.groupBox1.Controls.Add(this.txtNgayCapNam);
            this.groupBox1.Controls.Add(this.txtNgaySinhNam);
            this.groupBox1.Controls.Add(this.txtNgayHetHanNam);
            this.groupBox1.Controls.Add(this.txtNgaySinhNgay);
            this.groupBox1.Controls.Add(this.txtNgaySinhThang);
            this.groupBox1.Controls.Add(this.txtTenDocGia);
            this.groupBox1.Controls.Add(this.txtMaThe);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 114);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(722, 162);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết thẻ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(372, 130);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "mm/dd/yyyy";
            // 
            // cbLoaiThe
            // 
            this.cbLoaiThe.FormattingEnabled = true;
            this.cbLoaiThe.Location = new System.Drawing.Point(139, 50);
            this.cbLoaiThe.Margin = new System.Windows.Forms.Padding(4);
            this.cbLoaiThe.Name = "cbLoaiThe";
            this.cbLoaiThe.Size = new System.Drawing.Size(229, 24);
            this.cbLoaiThe.TabIndex = 9;
            this.cbLoaiThe.SelectedIndexChanged += new System.EventHandler(this.cbLoaiThe_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ngày cấp:";
            // 
            // txtNgayCapNgay
            // 
            this.txtNgayCapNgay.Location = new System.Drawing.Point(139, 89);
            this.txtNgayCapNgay.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayCapNgay.Name = "txtNgayCapNgay";
            this.txtNgayCapNgay.Size = new System.Drawing.Size(76, 22);
            this.txtNgayCapNgay.TabIndex = 6;
            this.txtNgayCapNgay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNgayCapThang_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày hết hạn";
            // 
            // txtNgayHetHanNgay
            // 
            this.txtNgayHetHanNgay.Location = new System.Drawing.Point(139, 127);
            this.txtNgayHetHanNgay.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayHetHanNgay.Name = "txtNgayHetHanNgay";
            this.txtNgayHetHanNgay.Size = new System.Drawing.Size(76, 22);
            this.txtNgayHetHanNgay.TabIndex = 6;
            // 
            // txtNgayCapThang
            // 
            this.txtNgayCapThang.Location = new System.Drawing.Point(223, 89);
            this.txtNgayCapThang.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayCapThang.Name = "txtNgayCapThang";
            this.txtNgayCapThang.Size = new System.Drawing.Size(73, 22);
            this.txtNgayCapThang.TabIndex = 7;
            this.txtNgayCapThang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNgayCapNgay_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Loại Thẻ:";
            // 
            // txtNgayHetHanThang
            // 
            this.txtNgayHetHanThang.Location = new System.Drawing.Point(223, 127);
            this.txtNgayHetHanThang.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayHetHanThang.Name = "txtNgayHetHanThang";
            this.txtNgayHetHanThang.Size = new System.Drawing.Size(73, 22);
            this.txtNgayHetHanThang.TabIndex = 7;
            this.txtNgayHetHanThang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNgayHetHanNgay_KeyPress);
            // 
            // txtNgayCapNam
            // 
            this.txtNgayCapNam.Location = new System.Drawing.Point(304, 89);
            this.txtNgayCapNam.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayCapNam.Name = "txtNgayCapNam";
            this.txtNgayCapNam.Size = new System.Drawing.Size(64, 22);
            this.txtNgayCapNam.TabIndex = 7;
            // 
            // txtNgaySinhNam
            // 
            this.txtNgaySinhNam.Location = new System.Drawing.Point(644, 48);
            this.txtNgaySinhNam.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgaySinhNam.Name = "txtNgaySinhNam";
            this.txtNgaySinhNam.Size = new System.Drawing.Size(73, 22);
            this.txtNgaySinhNam.TabIndex = 7;
            // 
            // txtNgayHetHanNam
            // 
            this.txtNgayHetHanNam.Location = new System.Drawing.Point(304, 127);
            this.txtNgayHetHanNam.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayHetHanNam.Name = "txtNgayHetHanNam";
            this.txtNgayHetHanNam.Size = new System.Drawing.Size(64, 22);
            this.txtNgayHetHanNam.TabIndex = 7;
            // 
            // txtNgaySinhNgay
            // 
            this.txtNgaySinhNgay.Location = new System.Drawing.Point(478, 47);
            this.txtNgaySinhNgay.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgaySinhNgay.Name = "txtNgaySinhNgay";
            this.txtNgaySinhNgay.Size = new System.Drawing.Size(75, 22);
            this.txtNgaySinhNgay.TabIndex = 7;
            // 
            // txtNgaySinhThang
            // 
            this.txtNgaySinhThang.Location = new System.Drawing.Point(561, 47);
            this.txtNgaySinhThang.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgaySinhThang.Name = "txtNgaySinhThang";
            this.txtNgaySinhThang.Size = new System.Drawing.Size(75, 22);
            this.txtNgaySinhThang.TabIndex = 7;
            this.txtNgaySinhThang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNgaySinhNgay_KeyPress);
            // 
            // txtTenDocGia
            // 
            this.txtTenDocGia.Location = new System.Drawing.Point(478, 15);
            this.txtTenDocGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDocGia.Name = "txtTenDocGia";
            this.txtTenDocGia.Size = new System.Drawing.Size(239, 22);
            this.txtTenDocGia.TabIndex = 5;
            this.txtTenDocGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenDocGia_KeyPress);
            // 
            // txtMaThe
            // 
            this.txtMaThe.Location = new System.Drawing.Point(139, 15);
            this.txtMaThe.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Size = new System.Drawing.Size(229, 22);
            this.txtMaThe.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ngày Sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "mm/dd/yyyy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Đọc Giả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Thẻ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox2.Controls.Add(this.dgvThe);
            this.groupBox2.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox2.Location = new System.Drawing.Point(8, 285);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(732, 228);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tất cả thẻ";
            // 
            // dgvThe
            // 
            this.dgvThe.AllowUserToAddRows = false;
            this.dgvThe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThe,
            this.LoaiThe,
            this.NgayCap,
            this.NgayHetHan,
            this.TenDocGia,
            this.NgaySinh});
            this.dgvThe.GridColor = System.Drawing.Color.MidnightBlue;
            this.dgvThe.Location = new System.Drawing.Point(9, 25);
            this.dgvThe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThe.MultiSelect = false;
            this.dgvThe.Name = "dgvThe";
            this.dgvThe.ReadOnly = true;
            this.dgvThe.RowHeadersVisible = false;
            this.dgvThe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThe.Size = new System.Drawing.Size(713, 196);
            this.dgvThe.TabIndex = 0;
            this.dgvThe.SelectionChanged += new System.EventHandler(this.dgvThe_SelectionChanged);
            // 
            // MaThe
            // 
            this.MaThe.DataPropertyName = "Ma";
            this.MaThe.HeaderText = "Mã Thẻ";
            this.MaThe.Name = "MaThe";
            this.MaThe.ReadOnly = true;
            this.MaThe.Width = 140;
            // 
            // LoaiThe
            // 
            this.LoaiThe.DataPropertyName = "LoaiThe";
            this.LoaiThe.HeaderText = "Loại Thẻ";
            this.LoaiThe.Name = "LoaiThe";
            this.LoaiThe.ReadOnly = true;
            this.LoaiThe.Visible = false;
            this.LoaiThe.Width = 150;
            // 
            // NgayCap
            // 
            this.NgayCap.DataPropertyName = "NgayCap";
            this.NgayCap.HeaderText = "Ngày cấp";
            this.NgayCap.Name = "NgayCap";
            this.NgayCap.ReadOnly = true;
            this.NgayCap.Width = 150;
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.DataPropertyName = "NgayHetHan";
            this.NgayHetHan.HeaderText = "Ngày hết hạn";
            this.NgayHetHan.Name = "NgayHetHan";
            this.NgayHetHan.ReadOnly = true;
            this.NgayHetHan.Width = 150;
            // 
            // TenDocGia
            // 
            this.TenDocGia.DataPropertyName = "TenDocGia";
            this.TenDocGia.HeaderText = "Tên Đọc Giả";
            this.TenDocGia.Name = "TenDocGia";
            this.TenDocGia.ReadOnly = true;
            this.TenDocGia.Width = 140;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            this.NgaySinh.Width = 130;
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btThoat.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btThoat.Location = new System.Drawing.Point(636, 535);
            this.btThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(94, 38);
            this.btThoat.TabIndex = 16;
            this.btThoat.Text = "&Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btXoa.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btXoa.Location = new System.Drawing.Point(486, 535);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(104, 38);
            this.btXoa.TabIndex = 15;
            this.btXoa.Text = "&Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btThem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btThem.Location = new System.Drawing.Point(88, 535);
            this.btThem.Margin = new System.Windows.Forms.Padding(4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(118, 38);
            this.btThem.TabIndex = 12;
            this.btThem.Text = "&Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btLamLai
            // 
            this.btLamLai.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btLamLai.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btLamLai.Location = new System.Drawing.Point(357, 535);
            this.btLamLai.Margin = new System.Windows.Forms.Padding(4);
            this.btLamLai.Name = "btLamLai";
            this.btLamLai.Size = new System.Drawing.Size(106, 38);
            this.btLamLai.TabIndex = 14;
            this.btLamLai.Text = "&Làm Lại";
            this.btLamLai.UseVisualStyleBackColor = false;
            this.btLamLai.Click += new System.EventHandler(this.btLamLai_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btCapNhat.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btCapNhat.Location = new System.Drawing.Point(231, 535);
            this.btCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(105, 38);
            this.btCapNhat.TabIndex = 13;
            this.btCapNhat.Text = "&Cập Nhật";
            this.btCapNhat.UseVisualStyleBackColor = false;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(53, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 123);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Baskerville Old Face", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(198, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(517, 73);
            this.label9.TabIndex = 18;
            this.label9.Text = "Lập Thẻ Độc Giả";
            // 
            // TheForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(753, 586);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btLamLai);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TheForm";
            this.Text = "Lập Thẻ Độc Giả";
            this.Load += new System.EventHandler(this.TheForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNgaySinhThang;
        private System.Windows.Forms.TextBox txtTenDocGia;
        private System.Windows.Forms.TextBox txtNgaySinhNam;
        private System.Windows.Forms.TextBox txtNgaySinhNgay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvThe;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btLamLai;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbLoaiThe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNgayCapNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNgayHetHanNgay;
        private System.Windows.Forms.TextBox txtNgayCapThang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNgayHetHanThang;
        private System.Windows.Forms.TextBox txtNgayCapNam;
        private System.Windows.Forms.TextBox txtNgayHetHanNam;
        private System.Windows.Forms.TextBox txtMaThe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHetHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
    }
}