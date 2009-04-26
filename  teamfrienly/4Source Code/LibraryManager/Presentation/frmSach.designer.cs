namespace Presentation
{
    partial class frmSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSach));
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonNhapSach = new System.Windows.Forms.Button();
            this.buttonReresh = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGiaSach = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.comboxLoaiSach = new System.Windows.Forms.ComboBox();
            this.comboxNgonNgu = new System.Windows.Forms.ComboBox();
            this.txtTenNhaXB = new System.Windows.Forms.TextBox();
            this.txtNhanDe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimeNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonKiemTra = new System.Windows.Forms.Button();
            this.txtMaSachInsert = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgonNgu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonThoat.Location = new System.Drawing.Point(657, 483);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(99, 37);
            this.buttonThoat.TabIndex = 31;
            this.buttonThoat.Tag = "17";
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonNhapSach
            // 
            this.buttonNhapSach.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonNhapSach.Location = new System.Drawing.Point(146, 483);
            this.buttonNhapSach.Name = "buttonNhapSach";
            this.buttonNhapSach.Size = new System.Drawing.Size(104, 37);
            this.buttonNhapSach.TabIndex = 29;
            this.buttonNhapSach.Tag = "17";
            this.buttonNhapSach.Text = "Nhập Sách";
            this.buttonNhapSach.UseVisualStyleBackColor = false;
            this.buttonNhapSach.Click += new System.EventHandler(this.buttonNhapSach_Click);
            // 
            // buttonReresh
            // 
            this.buttonReresh.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonReresh.Location = new System.Drawing.Point(478, 483);
            this.buttonReresh.Name = "buttonReresh";
            this.buttonReresh.Size = new System.Drawing.Size(93, 37);
            this.buttonReresh.TabIndex = 27;
            this.buttonReresh.Tag = "17";
            this.buttonReresh.Text = "Làm Mới";
            this.buttonReresh.UseVisualStyleBackColor = false;
            this.buttonReresh.Click += new System.EventHandler(this.buttonReresh_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Location = new System.Drawing.Point(431, 159);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(93, 21);
            this.txtSoLuong.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 47;
            this.label8.Text = "SL Sách :";
            // 
            // txtGiaSach
            // 
            this.txtGiaSach.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtGiaSach.Location = new System.Drawing.Point(103, 156);
            this.txtGiaSach.Name = "txtGiaSach";
            this.txtGiaSach.Size = new System.Drawing.Size(151, 21);
            this.txtGiaSach.TabIndex = 46;
            this.txtGiaSach.Click += new System.EventHandler(this.txtGiaSach_Click);
            this.txtGiaSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaSach_KeyPress);
            // 
            // txtTacGia
            // 
            this.txtTacGia.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTacGia.Location = new System.Drawing.Point(103, 121);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(151, 21);
            this.txtTacGia.TabIndex = 45;
            this.txtTacGia.Click += new System.EventHandler(this.txtTacGia_Click);
            // 
            // comboxLoaiSach
            // 
            this.comboxLoaiSach.BackColor = System.Drawing.Color.Gainsboro;
            this.comboxLoaiSach.FormattingEnabled = true;
            this.comboxLoaiSach.Location = new System.Drawing.Point(431, 61);
            this.comboxLoaiSach.Name = "comboxLoaiSach";
            this.comboxLoaiSach.Size = new System.Drawing.Size(128, 23);
            this.comboxLoaiSach.TabIndex = 44;
            this.comboxLoaiSach.SelectedValueChanged += new System.EventHandler(this.comboxLoaiSach_SelectedValueChanged);
            // 
            // comboxNgonNgu
            // 
            this.comboxNgonNgu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboxNgonNgu.FormattingEnabled = true;
            this.comboxNgonNgu.Location = new System.Drawing.Point(431, 92);
            this.comboxNgonNgu.Name = "comboxNgonNgu";
            this.comboxNgonNgu.Size = new System.Drawing.Size(128, 23);
            this.comboxNgonNgu.TabIndex = 43;
            // 
            // txtTenNhaXB
            // 
            this.txtTenNhaXB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTenNhaXB.Location = new System.Drawing.Point(103, 92);
            this.txtTenNhaXB.Name = "txtTenNhaXB";
            this.txtTenNhaXB.Size = new System.Drawing.Size(151, 21);
            this.txtTenNhaXB.TabIndex = 42;
            this.txtTenNhaXB.Click += new System.EventHandler(this.txtTenNhaXB_Click);
            // 
            // txtNhanDe
            // 
            this.txtNhanDe.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNhanDe.Location = new System.Drawing.Point(103, 62);
            this.txtNhanDe.Name = "txtNhanDe";
            this.txtNhanDe.Size = new System.Drawing.Size(151, 21);
            this.txtNhanDe.TabIndex = 41;
            this.txtNhanDe.Click += new System.EventHandler(this.txtNhanDe_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 39;
            this.label7.Text = "Giá Sách :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "Tên Tác giả :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 37;
            this.label5.Text = "Ngôn ngữ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "Loại sách :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "Nhà xuất bản :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nhan Đề  :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(339, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 15);
            this.label9.TabIndex = 49;
            this.label9.Text = "Ngày sinh TG:";
            // 
            // dateTimeNgaySinh
            // 
            this.dateTimeNgaySinh.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dateTimeNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dateTimeNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNgaySinh.Location = new System.Drawing.Point(431, 125);
            this.dateTimeNgaySinh.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dateTimeNgaySinh.Name = "dateTimeNgaySinh";
            this.dateTimeNgaySinh.Size = new System.Drawing.Size(114, 21);
            this.dateTimeNgaySinh.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 51;
            this.label1.Text = "(Cuốn sách)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(253, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 52;
            this.label10.Text = "(VN Đ)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonKiemTra);
            this.groupBox1.Controls.Add(this.txtMaSachInsert);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimeNgaySinh);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtGiaSach);
            this.groupBox1.Controls.Add(this.txtTacGia);
            this.groupBox1.Controls.Add(this.comboxLoaiSach);
            this.groupBox1.Controls.Add(this.comboxNgonNgu);
            this.groupBox1.Controls.Add(this.txtTenNhaXB);
            this.groupBox1.Controls.Add(this.txtNhanDe);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 198);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sách";
            // 
            // buttonKiemTra
            // 
            this.buttonKiemTra.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonKiemTra.Location = new System.Drawing.Point(337, 31);
            this.buttonKiemTra.Name = "buttonKiemTra";
            this.buttonKiemTra.Size = new System.Drawing.Size(81, 24);
            this.buttonKiemTra.TabIndex = 58;
            this.buttonKiemTra.Tag = "17";
            this.buttonKiemTra.Text = "Kiểm tra";
            this.buttonKiemTra.UseVisualStyleBackColor = false;
            this.buttonKiemTra.Click += new System.EventHandler(this.buttonKiemTra_Click);
            // 
            // txtMaSachInsert
            // 
            this.txtMaSachInsert.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMaSachInsert.Location = new System.Drawing.Point(105, 31);
            this.txtMaSachInsert.Name = "txtMaSachInsert";
            this.txtMaSachInsert.Size = new System.Drawing.Size(151, 21);
            this.txtMaSachInsert.TabIndex = 54;
            this.txtMaSachInsert.Click += new System.EventHandler(this.txtMaSachInsert_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 15);
            this.label12.TabIndex = 53;
            this.label12.Text = "Mã Sách  :";
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCapNhat.Location = new System.Drawing.Point(256, 483);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(97, 37);
            this.buttonCapNhat.TabIndex = 56;
            this.buttonCapNhat.Tag = "17";
            this.buttonCapNhat.Text = "Cập Nhật";
            this.buttonCapNhat.UseVisualStyleBackColor = false;
            this.buttonCapNhat.Click += new System.EventHandler(this.buttonCapNhat_Click_1);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonXoa.Location = new System.Drawing.Point(359, 483);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(102, 37);
            this.buttonXoa.TabIndex = 55;
            this.buttonXoa.Tag = "17";
            this.buttonXoa.Text = "Xóa Sách";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(12, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(753, 163);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sách Trong Thư Viện";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.LoaiSach,
            this.TacGia,
            this.Gia,
            this.NgonNgu,
            this.NhaXB,
            this.Ten});
            this.dataGridView1.Location = new System.Drawing.Point(7, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 136);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "Ma";
            this.Ma.HeaderText = "Mã Sách";
            this.Ma.Name = "Ma";
            // 
            // LoaiSach
            // 
            this.LoaiSach.DataPropertyName = "LoaiSach";
            this.LoaiSach.HeaderText = "Loại Sách";
            this.LoaiSach.Name = "LoaiSach";
            // 
            // TacGia
            // 
            this.TacGia.DataPropertyName = "TacGia";
            this.TacGia.HeaderText = "Tác Giả";
            this.TacGia.Name = "TacGia";
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            // 
            // NgonNgu
            // 
            this.NgonNgu.DataPropertyName = "NgonNgu";
            this.NgonNgu.HeaderText = "Ngôn Ngữ";
            this.NgonNgu.Name = "NgonNgu";
            // 
            // NhaXB
            // 
            this.NhaXB.DataPropertyName = "NhaXB";
            this.NhaXB.HeaderText = "Nhà XB";
            this.NhaXB.Name = "NhaXB";
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên Sách";
            this.Ten.Name = "Ten";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation.Properties.Resources.bok;
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 102);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Perpetua Titling MT", 23F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(139, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(625, 37);
            this.label11.TabIndex = 58;
            this.label11.Text = "Thông Tin Sách Trong ThƯ VIỆn";
            // 
            // frmSach
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(795, 531);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonCapNhat);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonNhapSach);
            this.Controls.Add(this.buttonReresh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Indigo;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSach";
            this.Text = "frmSach";
            this.Load += new System.EventHandler(this.frmSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonNhapSach;
        private System.Windows.Forms.Button buttonReresh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGiaSach;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.ComboBox comboxLoaiSach;
        private System.Windows.Forms.ComboBox comboxNgonNgu;
        private System.Windows.Forms.TextBox txtTenNhaXB;
        private System.Windows.Forms.TextBox txtNhanDe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimeNgaySinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonKiemTra;
        private System.Windows.Forms.TextBox txtMaSachInsert;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgonNgu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.Label label11;
    }
}