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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbLoaiThe = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNgaySinhThang = new System.Windows.Forms.TextBox();
            this.txtNgayHetHanNgay = new System.Windows.Forms.TextBox();
            this.txtTenDocGia = new System.Windows.Forms.TextBox();
            this.txtMaThe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNgaySinhNgay = new System.Windows.Forms.TextBox();
            this.txtNgayHetHanNam = new System.Windows.Forms.TextBox();
            this.txtNgayHetHanThang = new System.Windows.Forms.TextBox();
            this.txtNgaySinhNam = new System.Windows.Forms.TextBox();
            this.txtNgayCapNam = new System.Windows.Forms.TextBox();
            this.txtNgayCapThang = new System.Windows.Forms.TextBox();
            this.txtNgayCapNgay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvThe = new System.Windows.Forms.DataGridView();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btLamLai = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.MaThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 132);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết thẻ";
            // 
            // cbLoaiThe
            // 
            this.cbLoaiThe.FormattingEnabled = true;
            this.cbLoaiThe.Location = new System.Drawing.Point(114, 41);
            this.cbLoaiThe.Name = "cbLoaiThe";
            this.cbLoaiThe.Size = new System.Drawing.Size(149, 21);
            this.cbLoaiThe.TabIndex = 9;
            this.cbLoaiThe.SelectedIndexChanged += new System.EventHandler(this.cbLoaiThe_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Loại Thẻ:";
            // 
            // txtNgaySinhThang
            // 
            this.txtNgaySinhThang.Location = new System.Drawing.Point(450, 37);
            this.txtNgaySinhThang.Name = "txtNgaySinhThang";
            this.txtNgaySinhThang.Size = new System.Drawing.Size(39, 20);
            this.txtNgaySinhThang.TabIndex = 7;
            // 
            // txtNgayHetHanNgay
            // 
            this.txtNgayHetHanNgay.Location = new System.Drawing.Point(114, 103);
            this.txtNgayHetHanNgay.Name = "txtNgayHetHanNgay";
            this.txtNgayHetHanNgay.Size = new System.Drawing.Size(41, 20);
            this.txtNgayHetHanNgay.TabIndex = 6;
            // 
            // txtTenDocGia
            // 
            this.txtTenDocGia.Location = new System.Drawing.Point(395, 11);
            this.txtTenDocGia.Name = "txtTenDocGia";
            this.txtTenDocGia.Size = new System.Drawing.Size(149, 20);
            this.txtTenDocGia.TabIndex = 5;
            // 
            // txtMaThe
            // 
            this.txtMaThe.Location = new System.Drawing.Point(114, 12);
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Size = new System.Drawing.Size(149, 20);
            this.txtMaThe.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày hết hạn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "mm/dd/yyyy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Đọc Giả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Thẻ";
            // 
            // txtNgaySinhNgay
            // 
            this.txtNgaySinhNgay.Location = new System.Drawing.Point(395, 37);
            this.txtNgaySinhNgay.Name = "txtNgaySinhNgay";
            this.txtNgaySinhNgay.Size = new System.Drawing.Size(39, 20);
            this.txtNgaySinhNgay.TabIndex = 7;
            // 
            // txtNgayHetHanNam
            // 
            this.txtNgayHetHanNam.Location = new System.Drawing.Point(224, 103);
            this.txtNgayHetHanNam.Name = "txtNgayHetHanNam";
            this.txtNgayHetHanNam.Size = new System.Drawing.Size(39, 20);
            this.txtNgayHetHanNam.TabIndex = 7;
            // 
            // txtNgayHetHanThang
            // 
            this.txtNgayHetHanThang.Location = new System.Drawing.Point(170, 103);
            this.txtNgayHetHanThang.Name = "txtNgayHetHanThang";
            this.txtNgayHetHanThang.Size = new System.Drawing.Size(39, 20);
            this.txtNgayHetHanThang.TabIndex = 7;
            // 
            // txtNgaySinhNam
            // 
            this.txtNgaySinhNam.Location = new System.Drawing.Point(505, 38);
            this.txtNgaySinhNam.Name = "txtNgaySinhNam";
            this.txtNgaySinhNam.Size = new System.Drawing.Size(39, 20);
            this.txtNgaySinhNam.TabIndex = 7;
            // 
            // txtNgayCapNam
            // 
            this.txtNgayCapNam.Location = new System.Drawing.Point(224, 72);
            this.txtNgayCapNam.Name = "txtNgayCapNam";
            this.txtNgayCapNam.Size = new System.Drawing.Size(39, 20);
            this.txtNgayCapNam.TabIndex = 7;
            // 
            // txtNgayCapThang
            // 
            this.txtNgayCapThang.Location = new System.Drawing.Point(170, 72);
            this.txtNgayCapThang.Name = "txtNgayCapThang";
            this.txtNgayCapThang.Size = new System.Drawing.Size(39, 20);
            this.txtNgayCapThang.TabIndex = 7;
            // 
            // txtNgayCapNgay
            // 
            this.txtNgayCapNgay.Location = new System.Drawing.Point(114, 72);
            this.txtNgayCapNgay.Name = "txtNgayCapNgay";
            this.txtNgayCapNgay.Size = new System.Drawing.Size(41, 20);
            this.txtNgayCapNgay.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ngày cấp:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ngày Sinh:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvThe);
            this.groupBox2.Location = new System.Drawing.Point(12, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(687, 177);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tất cả thẻ";
            // 
            // dgvThe
            // 
            this.dgvThe.AllowUserToAddRows = false;
            this.dgvThe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThe,
            this.LoaiThe,
            this.NgayCap,
            this.NgayHetHan,
            this.TenDocGia,
            this.NgaySinh});
            this.dgvThe.Location = new System.Drawing.Point(21, 19);
            this.dgvThe.MultiSelect = false;
            this.dgvThe.Name = "dgvThe";
            this.dgvThe.ReadOnly = true;
            this.dgvThe.RowHeadersVisible = false;
            this.dgvThe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThe.Size = new System.Drawing.Size(660, 150);
            this.dgvThe.TabIndex = 0;
            this.dgvThe.SelectionChanged += new System.EventHandler(this.dgvThe_SelectionChanged);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(624, 353);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 11;
            this.btThoat.Text = "&Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(525, 353);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 10;
            this.btXoa.Text = "&Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btLamLai
            // 
            this.btLamLai.Location = new System.Drawing.Point(204, 353);
            this.btLamLai.Name = "btLamLai";
            this.btLamLai.Size = new System.Drawing.Size(75, 23);
            this.btLamLai.TabIndex = 9;
            this.btLamLai.Text = "&Làm Lại";
            this.btLamLai.UseVisualStyleBackColor = true;
            this.btLamLai.Click += new System.EventHandler(this.btLamLai_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.Location = new System.Drawing.Point(107, 353);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btCapNhat.TabIndex = 8;
            this.btCapNhat.Text = "&Cập Nhật";
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(11, 353);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 7;
            this.btThem.Text = "&Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // MaThe
            // 
            this.MaThe.DataPropertyName = "Ma";
            this.MaThe.HeaderText = "Mã Thẻ";
            this.MaThe.Name = "MaThe";
            this.MaThe.ReadOnly = true;
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
            // 
            // TenDocGia
            // 
            this.TenDocGia.DataPropertyName = "TenDocGia";
            this.TenDocGia.HeaderText = "Tên Đọc Giả";
            this.TenDocGia.Name = "TenDocGia";
            this.TenDocGia.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // TheForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 378);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btLamLai);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TheForm";
            this.Text = "TheForm";
            this.Load += new System.EventHandler(this.TheForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbLoaiThe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNgaySinhThang;
        private System.Windows.Forms.TextBox txtNgayHetHanNgay;
        private System.Windows.Forms.TextBox txtTenDocGia;
        private System.Windows.Forms.TextBox txtMaThe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNgayHetHanThang;
        private System.Windows.Forms.TextBox txtNgaySinhNam;
        private System.Windows.Forms.TextBox txtNgayHetHanNam;
        private System.Windows.Forms.TextBox txtNgaySinhNgay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNgayCapNgay;
        private System.Windows.Forms.TextBox txtNgayCapThang;
        private System.Windows.Forms.TextBox txtNgayCapNam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvThe;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btLamLai;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHetHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
    }
}