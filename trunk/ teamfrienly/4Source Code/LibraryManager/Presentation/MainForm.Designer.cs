namespace Presentation
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muonSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKhoSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoaiThetoolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìnhHìnhMượnSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoLoạiSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoLoạiThẻĐộcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìnhHìnhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hỏngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTácGiảToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tacGiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyToolStripMenuItem,
            this.quảnLýKhoSáchToolStripMenuItem,
            this.thôngTinTácGiảToolStripMenuItem,
            this.traCứuToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.thôngTinTácGiảToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(804, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // quanLyToolStripMenuItem
            // 
            this.quanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muonSachToolStripMenuItem,
            this.traSachToolStripMenuItem});
            this.quanLyToolStripMenuItem.Image = global::Presentation.Properties.Resources.My_Documents;
            this.quanLyToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            this.quanLyToolStripMenuItem.Size = new System.Drawing.Size(141, 36);
            this.quanLyToolStripMenuItem.Text = "Quản Lý  mượn trả";
            // 
            // muonSachToolStripMenuItem
            // 
            this.muonSachToolStripMenuItem.Image = global::Presentation.Properties.Resources.Options1;
            this.muonSachToolStripMenuItem.Name = "muonSachToolStripMenuItem";
            this.muonSachToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.muonSachToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.muonSachToolStripMenuItem.Text = "&Mượn Sách";
            this.muonSachToolStripMenuItem.Click += new System.EventHandler(this.muonSachToolStripMenuItem_Click);
            // 
            // traSachToolStripMenuItem
            // 
            this.traSachToolStripMenuItem.Image = global::Presentation.Properties.Resources.Options;
            this.traSachToolStripMenuItem.Name = "traSachToolStripMenuItem";
            this.traSachToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.traSachToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.traSachToolStripMenuItem.Text = "&Trả Sách";
            this.traSachToolStripMenuItem.Click += new System.EventHandler(this.traSachToolStripMenuItem_Click);
            // 
            // quảnLýKhoSáchToolStripMenuItem
            // 
            this.quảnLýKhoSáchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinSáchToolStripMenuItem});
            this.quảnLýKhoSáchToolStripMenuItem.Image = global::Presentation.Properties.Resources.BOOKS04;
            this.quảnLýKhoSáchToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.quảnLýKhoSáchToolStripMenuItem.Name = "quảnLýKhoSáchToolStripMenuItem";
            this.quảnLýKhoSáchToolStripMenuItem.Size = new System.Drawing.Size(122, 36);
            this.quảnLýKhoSáchToolStripMenuItem.Text = "Quản Lý Kho Sách";
            // 
            // thôngTinSáchToolStripMenuItem
            // 
            this.thôngTinSáchToolStripMenuItem.Image = global::Presentation.Properties.Resources.Options;
            this.thôngTinSáchToolStripMenuItem.Name = "thôngTinSáchToolStripMenuItem";
            this.thôngTinSáchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.thôngTinSáchToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.thôngTinSáchToolStripMenuItem.Text = "Thông Tin Sách";
            this.thôngTinSáchToolStripMenuItem.Click += new System.EventHandler(this.thôngTinSáchToolStripMenuItem_Click);
            // 
            // thôngTinTácGiảToolStripMenuItem
            // 
            this.thôngTinTácGiảToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tToolStripMenuItem,
            this.LoaiThetoolStripMenu});
            this.thôngTinTácGiảToolStripMenuItem.Image = global::Presentation.Properties.Resources.Copy_of_docgia;
            this.thôngTinTácGiảToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.thôngTinTácGiảToolStripMenuItem.Name = "thôngTinTácGiảToolStripMenuItem";
            this.thôngTinTácGiảToolStripMenuItem.Size = new System.Drawing.Size(149, 36);
            this.thôngTinTácGiảToolStripMenuItem.Text = "Quản LýThẻ Đọc Giả";
            // 
            // tToolStripMenuItem
            // 
            this.tToolStripMenuItem.Image = global::Presentation.Properties.Resources.Options;
            this.tToolStripMenuItem.Name = "tToolStripMenuItem";
            this.tToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.tToolStripMenuItem.Text = "Thẻ Độc Giả";
            this.tToolStripMenuItem.Click += new System.EventHandler(this.tToolStripMenuItem_Click);
            // 
            // LoaiThetoolStripMenu
            // 
            this.LoaiThetoolStripMenu.Image = global::Presentation.Properties.Resources.Options;
            this.LoaiThetoolStripMenu.Name = "LoaiThetoolStripMenu";
            this.LoaiThetoolStripMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.LoaiThetoolStripMenu.Size = new System.Drawing.Size(182, 22);
            this.LoaiThetoolStripMenu.Text = "Loại Thẻ";
            this.LoaiThetoolStripMenu.Click += new System.EventHandler(this.LoaiThetoolStripMenu_Click);
            // 
            // traCứuToolStripMenuItem
            // 
            this.traCứuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThetoolStripMenuItem,
            this.sáchToolStripMenuItem});
            this.traCứuToolStripMenuItem.Image = global::Presentation.Properties.Resources._01__14_;
            this.traCứuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.traCứuToolStripMenuItem.Name = "traCứuToolStripMenuItem";
            this.traCứuToolStripMenuItem.Size = new System.Drawing.Size(109, 36);
            this.traCứuToolStripMenuItem.Text = "Tra cứu       ";
            // 
            // ThetoolStripMenuItem
            // 
            this.ThetoolStripMenuItem.Image = global::Presentation.Properties.Resources.Options;
            this.ThetoolStripMenuItem.Name = "ThetoolStripMenuItem";
            this.ThetoolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.ThetoolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ThetoolStripMenuItem.Text = "Thẻ";
            this.ThetoolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // sáchToolStripMenuItem
            // 
            this.sáchToolStripMenuItem.Image = global::Presentation.Properties.Resources.Options;
            this.sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            this.sáchToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.sáchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sáchToolStripMenuItem.Text = "Sách";
            this.sáchToolStripMenuItem.Click += new System.EventHandler(this.sáchToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìnhHìnhMượnSáchToolStripMenuItem,
            this.tìnhHìnhSáchToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Image = global::Presentation.Properties.Resources._01__32_;
            this.thốngKêToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(114, 36);
            this.thốngKêToolStripMenuItem.Text = "Thống Kê      ";
            // 
            // tìnhHìnhMượnSáchToolStripMenuItem
            // 
            this.tìnhHìnhMượnSáchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.theoLoạiSáchToolStripMenuItem,
            this.theoLoạiThẻĐộcGiảToolStripMenuItem});
            this.tìnhHìnhMượnSáchToolStripMenuItem.Image = global::Presentation.Properties.Resources.Options;
            this.tìnhHìnhMượnSáchToolStripMenuItem.Name = "tìnhHìnhMượnSáchToolStripMenuItem";
            this.tìnhHìnhMượnSáchToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.tìnhHìnhMượnSáchToolStripMenuItem.Text = "Tình hình mượn sách";
            // 
            // theoLoạiSáchToolStripMenuItem
            // 
            this.theoLoạiSáchToolStripMenuItem.Image = global::Presentation.Properties.Resources.Options;
            this.theoLoạiSáchToolStripMenuItem.Name = "theoLoạiSáchToolStripMenuItem";
            this.theoLoạiSáchToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.theoLoạiSáchToolStripMenuItem.Text = "Theo loại sách";
            this.theoLoạiSáchToolStripMenuItem.Click += new System.EventHandler(this.theoLoạiSáchToolStripMenuItem_Click);
            // 
            // theoLoạiThẻĐộcGiảToolStripMenuItem
            // 
            this.theoLoạiThẻĐộcGiảToolStripMenuItem.Image = global::Presentation.Properties.Resources.Options;
            this.theoLoạiThẻĐộcGiảToolStripMenuItem.Name = "theoLoạiThẻĐộcGiảToolStripMenuItem";
            this.theoLoạiThẻĐộcGiảToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.theoLoạiThẻĐộcGiảToolStripMenuItem.Text = "Theo loại thẻ độc giả";
            this.theoLoạiThẻĐộcGiảToolStripMenuItem.Click += new System.EventHandler(this.theoLoạiThẻĐộcGiảToolStripMenuItem_Click);
            // 
            // tìnhHìnhSáchToolStripMenuItem
            // 
            this.tìnhHìnhSáchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hỏngToolStripMenuItem,
            this.mấtToolStripMenuItem});
            this.tìnhHìnhSáchToolStripMenuItem.Image = global::Presentation.Properties.Resources.Options;
            this.tìnhHìnhSáchToolStripMenuItem.Name = "tìnhHìnhSáchToolStripMenuItem";
            this.tìnhHìnhSáchToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.tìnhHìnhSáchToolStripMenuItem.Text = "Tình hình sách";
            // 
            // hỏngToolStripMenuItem
            // 
            this.hỏngToolStripMenuItem.Image = global::Presentation.Properties.Resources.Options;
            this.hỏngToolStripMenuItem.Name = "hỏngToolStripMenuItem";
            this.hỏngToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hỏngToolStripMenuItem.Text = "Hỏng";
            this.hỏngToolStripMenuItem.Click += new System.EventHandler(this.hỏngToolStripMenuItem_Click);
            // 
            // mấtToolStripMenuItem
            // 
            this.mấtToolStripMenuItem.Image = global::Presentation.Properties.Resources.Options;
            this.mấtToolStripMenuItem.Name = "mấtToolStripMenuItem";
            this.mấtToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mấtToolStripMenuItem.Text = "Mất";
            this.mấtToolStripMenuItem.Click += new System.EventHandler(this.mấtToolStripMenuItem_Click);
            // 
            // thôngTinTácGiảToolStripMenuItem1
            // 
            this.thôngTinTácGiảToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.tacGiaToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.thôngTinTácGiảToolStripMenuItem1.Image = global::Presentation.Properties.Resources.dagron;
            this.thôngTinTácGiảToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.thôngTinTácGiảToolStripMenuItem1.Name = "thôngTinTácGiảToolStripMenuItem1";
            this.thôngTinTácGiảToolStripMenuItem1.Size = new System.Drawing.Size(95, 36);
            this.thôngTinTácGiảToolStripMenuItem1.Text = "Hệ thống";
            // 
            // tacGiaToolStripMenuItem
            // 
            this.tacGiaToolStripMenuItem.Image = global::Presentation.Properties.Resources.Options;
            this.tacGiaToolStripMenuItem.Name = "tacGiaToolStripMenuItem";
            this.tacGiaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.tacGiaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.tacGiaToolStripMenuItem.Text = "Tác Giả";
            this.tacGiaToolStripMenuItem.Click += new System.EventHandler(this.tacGiaToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = global::Presentation.Properties.Resources.Options1;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Image = global::Presentation.Properties.Resources.Options;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.helpToolStripMenuItem.Text = "Help ";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Image = global::Presentation.Properties.Resources.Options;
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.đăngNhậpToolStripMenuItem.Text = "Kết Nối";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentation.Properties.Resources.nen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(804, 521);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Phần Mềm Quản Lý Thư Viện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muonSachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traSachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKhoSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTácGiảToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tacGiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìnhHìnhMượnSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theoLoạiSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theoLoạiThẻĐộcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìnhHìnhSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hỏngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoaiThetoolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
    }
}