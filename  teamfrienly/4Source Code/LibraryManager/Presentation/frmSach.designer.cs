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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Themtg = new System.Windows.Forms.Button();
            this.btn_ThemNXB = new System.Windows.Forms.Button();
            this.cbb_TacGia = new System.Windows.Forms.ComboBox();
            this.cbb_nhaXB = new System.Windows.Forms.ComboBox();
            this.buttonKiemTra = new System.Windows.Forms.Button();
            this.txtMaSachInsert = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGiaSach = new System.Windows.Forms.TextBox();
            this.comboxLoaiSach = new System.Windows.Forms.ComboBox();
            this.comboxNgonNgu = new System.Windows.Forms.ComboBox();
            this.txtNhanDe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgonNgu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonNhapSach = new System.Windows.Forms.Button();
            this.buttonReresh = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(715, 499);
            this.splitContainer1.SplitterDistance = 258;
            this.splitContainer1.TabIndex = 100;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label11);
            this.splitContainer2.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Size = new System.Drawing.Size(715, 258);
            this.splitContainer2.SplitterDistance = 85;
            this.splitContainer2.TabIndex = 100;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(147, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(565, 46);
            this.label11.TabIndex = 59;
            this.label11.Text = "Thông Tin Sách Trong Thư Viện";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation.Properties.Resources.bok;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 82);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Themtg);
            this.groupBox1.Controls.Add(this.btn_ThemNXB);
            this.groupBox1.Controls.Add(this.cbb_TacGia);
            this.groupBox1.Controls.Add(this.cbb_nhaXB);
            this.groupBox1.Controls.Add(this.buttonKiemTra);
            this.groupBox1.Controls.Add(this.txtMaSachInsert);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtGiaSach);
            this.groupBox1.Controls.Add(this.comboxLoaiSach);
            this.groupBox1.Controls.Add(this.comboxNgonNgu);
            this.groupBox1.Controls.Add(this.txtNhanDe);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 169);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sách";
            // 
            // btn_Themtg
            // 
            this.btn_Themtg.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Themtg.Location = new System.Drawing.Point(287, 124);
            this.btn_Themtg.Name = "btn_Themtg";
            this.btn_Themtg.Size = new System.Drawing.Size(70, 28);
            this.btn_Themtg.TabIndex = 10;
            this.btn_Themtg.Text = "+";
            this.btn_Themtg.UseVisualStyleBackColor = false;
            this.btn_Themtg.Click += new System.EventHandler(this.btn_Themtg_Click_1);
            // 
            // btn_ThemNXB
            // 
            this.btn_ThemNXB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_ThemNXB.Location = new System.Drawing.Point(287, 88);
            this.btn_ThemNXB.Name = "btn_ThemNXB";
            this.btn_ThemNXB.Size = new System.Drawing.Size(70, 29);
            this.btn_ThemNXB.TabIndex = 7;
            this.btn_ThemNXB.Text = "+";
            this.btn_ThemNXB.UseVisualStyleBackColor = false;
            this.btn_ThemNXB.Click += new System.EventHandler(this.btn_ThemNXB_Click);
            // 
            // cbb_TacGia
            // 
            this.cbb_TacGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TacGia.FormattingEnabled = true;
            this.cbb_TacGia.Location = new System.Drawing.Point(112, 125);
            this.cbb_TacGia.Name = "cbb_TacGia";
            this.cbb_TacGia.Size = new System.Drawing.Size(161, 23);
            this.cbb_TacGia.TabIndex = 9;
            // 
            // cbb_nhaXB
            // 
            this.cbb_nhaXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_nhaXB.FormattingEnabled = true;
            this.cbb_nhaXB.Location = new System.Drawing.Point(112, 90);
            this.cbb_nhaXB.Name = "cbb_nhaXB";
            this.cbb_nhaXB.Size = new System.Drawing.Size(161, 23);
            this.cbb_nhaXB.TabIndex = 6;
            // 
            // buttonKiemTra
            // 
            this.buttonKiemTra.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonKiemTra.Location = new System.Drawing.Point(287, 22);
            this.buttonKiemTra.Name = "buttonKiemTra";
            this.buttonKiemTra.Size = new System.Drawing.Size(70, 31);
            this.buttonKiemTra.TabIndex = 2;
            this.buttonKiemTra.Tag = "17";
            this.buttonKiemTra.Text = "Kiểm tra";
            this.buttonKiemTra.UseVisualStyleBackColor = false;
            this.buttonKiemTra.Click += new System.EventHandler(this.buttonKiemTra_Click);
            // 
            // txtMaSachInsert
            // 
            this.txtMaSachInsert.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMaSachInsert.Location = new System.Drawing.Point(112, 26);
            this.txtMaSachInsert.Name = "txtMaSachInsert";
            this.txtMaSachInsert.Size = new System.Drawing.Size(161, 21);
            this.txtMaSachInsert.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 15);
            this.label12.TabIndex = 53;
            this.label12.Text = "Mã Sách  :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(628, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 52;
            this.label10.Text = "(VN Đ)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(628, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 51;
            this.label1.Text = "(Cuốn sách)";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Location = new System.Drawing.Point(462, 126);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(158, 21);
            this.txtSoLuong.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 47;
            this.label8.Text = "SL Sách :";
            // 
            // txtGiaSach
            // 
            this.txtGiaSach.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtGiaSach.Location = new System.Drawing.Point(462, 91);
            this.txtGiaSach.Name = "txtGiaSach";
            this.txtGiaSach.Size = new System.Drawing.Size(158, 21);
            this.txtGiaSach.TabIndex = 8;
            this.txtGiaSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaSach_KeyPress);
            // 
            // comboxLoaiSach
            // 
            this.comboxLoaiSach.BackColor = System.Drawing.Color.Gainsboro;
            this.comboxLoaiSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxLoaiSach.FormattingEnabled = true;
            this.comboxLoaiSach.Location = new System.Drawing.Point(462, 26);
            this.comboxLoaiSach.Name = "comboxLoaiSach";
            this.comboxLoaiSach.Size = new System.Drawing.Size(182, 23);
            this.comboxLoaiSach.TabIndex = 3;
            // 
            // comboxNgonNgu
            // 
            this.comboxNgonNgu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboxNgonNgu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxNgonNgu.FormattingEnabled = true;
            this.comboxNgonNgu.Location = new System.Drawing.Point(462, 56);
            this.comboxNgonNgu.Name = "comboxNgonNgu";
            this.comboxNgonNgu.Size = new System.Drawing.Size(182, 23);
            this.comboxNgonNgu.TabIndex = 5;
            // 
            // txtNhanDe
            // 
            this.txtNhanDe.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNhanDe.Location = new System.Drawing.Point(112, 57);
            this.txtNhanDe.Name = "txtNhanDe";
            this.txtNhanDe.Size = new System.Drawing.Size(161, 21);
            this.txtNhanDe.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 39;
            this.label7.Text = "Giá Sách :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "Tên Tác giả :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 37;
            this.label5.Text = "Ngôn ngữ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "Loại sách :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "Nhà xuất bản :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nhan Đề  :";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer3.Size = new System.Drawing.Size(715, 237);
            this.splitContainer3.SplitterDistance = 169;
            this.splitContainer3.TabIndex = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(715, 169);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sách Trong Thư Viện";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.LoaiSach,
            this.TacGia,
            this.Gia,
            this.NgonNgu,
            this.NhaXB,
            this.Ten});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(709, 149);
            this.dataGridView1.TabIndex = 100;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "Ma";
            this.Ma.HeaderText = "Mã Sách";
            this.Ma.Name = "Ma";
            this.Ma.ReadOnly = true;
            // 
            // LoaiSach
            // 
            this.LoaiSach.DataPropertyName = "LoaiSach";
            this.LoaiSach.HeaderText = "Loại Sách";
            this.LoaiSach.Name = "LoaiSach";
            this.LoaiSach.ReadOnly = true;
            // 
            // TacGia
            // 
            this.TacGia.DataPropertyName = "TacGia";
            this.TacGia.HeaderText = "Tác Giả";
            this.TacGia.Name = "TacGia";
            this.TacGia.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // NgonNgu
            // 
            this.NgonNgu.DataPropertyName = "NgonNgu";
            this.NgonNgu.HeaderText = "Ngôn Ngữ";
            this.NgonNgu.Name = "NgonNgu";
            this.NgonNgu.ReadOnly = true;
            // 
            // NhaXB
            // 
            this.NhaXB.DataPropertyName = "NhaXB";
            this.NhaXB.HeaderText = "Nhà XB";
            this.NhaXB.Name = "NhaXB";
            this.NhaXB.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên Sách";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonThoat);
            this.groupBox3.Controls.Add(this.buttonCapNhat);
            this.groupBox3.Controls.Add(this.buttonXoa);
            this.groupBox3.Controls.Add(this.buttonNhapSach);
            this.groupBox3.Controls.Add(this.buttonReresh);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(715, 64);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // buttonThoat
            // 
            this.buttonThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonThoat.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonThoat.Location = new System.Drawing.Point(604, 15);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(99, 37);
            this.buttonThoat.TabIndex = 20;
            this.buttonThoat.Tag = "17";
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCapNhat.Location = new System.Drawing.Point(129, 15);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(97, 37);
            this.buttonCapNhat.TabIndex = 17;
            this.buttonCapNhat.Tag = "17";
            this.buttonCapNhat.Text = "Cập Nhật";
            this.buttonCapNhat.UseVisualStyleBackColor = false;
            this.buttonCapNhat.Click += new System.EventHandler(this.buttonCapNhat_Click_1);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonXoa.Location = new System.Drawing.Point(232, 15);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(102, 37);
            this.buttonXoa.TabIndex = 18;
            this.buttonXoa.Tag = "17";
            this.buttonXoa.Text = "Xóa Sách";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonNhapSach
            // 
            this.buttonNhapSach.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonNhapSach.Location = new System.Drawing.Point(19, 15);
            this.buttonNhapSach.Name = "buttonNhapSach";
            this.buttonNhapSach.Size = new System.Drawing.Size(104, 37);
            this.buttonNhapSach.TabIndex = 16;
            this.buttonNhapSach.Tag = "17";
            this.buttonNhapSach.Text = "Nhập Sách";
            this.buttonNhapSach.UseVisualStyleBackColor = false;
            this.buttonNhapSach.Click += new System.EventHandler(this.buttonNhapSach_Click);
            // 
            // buttonReresh
            // 
            this.buttonReresh.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonReresh.Location = new System.Drawing.Point(340, 15);
            this.buttonReresh.Name = "buttonReresh";
            this.buttonReresh.Size = new System.Drawing.Size(93, 37);
            this.buttonReresh.TabIndex = 19;
            this.buttonReresh.Tag = "17";
            this.buttonReresh.Text = "Làm Mới";
            this.buttonReresh.UseVisualStyleBackColor = false;
            this.buttonReresh.Click += new System.EventHandler(this.buttonReresh_Click);
            // 
            // frmSach
            // 
            this.AcceptButton = this.buttonKiemTra;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.buttonThoat;
            this.ClientSize = new System.Drawing.Size(715, 499);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmSach";
            this.Text = "Sách";
            this.Load += new System.EventHandler(this.frmSach1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Themtg;
        private System.Windows.Forms.Button btn_ThemNXB;
        private System.Windows.Forms.ComboBox cbb_TacGia;
        private System.Windows.Forms.ComboBox cbb_nhaXB;
        private System.Windows.Forms.Button buttonKiemTra;
        private System.Windows.Forms.TextBox txtMaSachInsert;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGiaSach;
        private System.Windows.Forms.ComboBox comboxLoaiSach;
        private System.Windows.Forms.ComboBox comboxNgonNgu;
        private System.Windows.Forms.TextBox txtNhanDe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgonNgu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonNhapSach;
        private System.Windows.Forms.Button buttonReresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonThoat;



    }
}