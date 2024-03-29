using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Presentation
{
    public partial class frmMuonSach : Form
    {
        public frmMuonSach()
        {
            InitializeComponent();
        }
        public String TypeAction;
        public String MaSachMuon;
        private void frmMuonSach1_Load(object sender, EventArgs e)
        {
            btnTraSach.Enabled = false;
            btnMatSach.Enabled = false;

            if (TypeAction == "MuonSach")
            {
                Text = "Mượn sách";
            }
            else if (TypeAction == "TraSach")
            {
                btnMuonSach.Enabled = false;
                btnKTMaSach.Enabled = false;
                txtMaSach.ReadOnly = true;
                Text = "Trả sách";
            }
        }
        private void btnKTMaTHe_Click(object sender, EventArgs e)
        {
            if (KiemTraThe() && TypeAction == "TraSach")
                if (dgvDSMuon.Rows.Count == 0)
                {
                    MessageBox.Show("Độc giả này không có sách để trả.\n Hãy kiểm tra lại mã thẻ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtMaThe.Focus();
                }
        }

        private void btnKTMaSach_Click(object sender, EventArgs e)
        {
            KiemTraSach();
        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            if (KiemTraThe() == false || KiemTraSach() == false)
            {
                return;
            }
            MuonSachDTO dto = new MuonSachDTO();
            dto.MaSach = txtMaSach.Text;
            dto.MaThe = txtMaThe.Text;
            dto.NgayMuon = DateTime.Now;
            dto.NgayHenTra = dto.NgayMuon.AddDays(15);
            MuonSachBUS.InsertMaMuonSach(ref dto);
            CapNhatDS();
        }
        private void btnTraSach_Click(object sender, EventArgs e)
        {
            btnTraSach.Enabled = btnMatSach.Enabled = false;
            MuonSachDTO msDto = MuonSachBUS.LayPhieuMuonSach_byMaSach(txtMaSach.Text);
            msDto.NgayTra = DateTime.Now;
            MuonSachBUS.UpdateMuonSach(msDto);
            //Kiem tra tre han
            int iSongay = DateTime.Compare(msDto.NgayHenTra, msDto.NgayTra);
            if (iSongay < 0)
            {
                int tienPhat = Math.Abs(iSongay) * 1000;
                MessageBox.Show("Sách này đã mượn quá hạn.\nĐộc giả bị phạt " + tienPhat.ToString() + " .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PhatDTO pDto = new PhatDTO();
                pDto.Songay = Math.Abs(iSongay);
                pDto.MaMuonSach = msDto.MaMuonSach;
                pDto.Thanhtien = tienPhat;
                PhatBUS.InsertPhat(pDto);
            }
            //xoa trong bang Sachmuon
            SachMuonBUS.DeleteSachMuonByID(msDto.MaMuonSach);
            CapNhatDS();
            btnTraSach.Enabled = btnMatSach.Enabled = false;
        }
        private void btnMatSach_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là sách này đã bị mất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            MaSachMuon = txtMaSach.Text;
            frmMatSach frm = new frmMatSach();
            frm.Owner = this;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                btnTraSach.Enabled = btnMatSach.Enabled = false;
                CapNhatDS();
            }


        }
        void CapNhatDS()
        {
            dgvDSMuon.DataSource = Bus.LayDS_SachDangMuon_byDocGiaID(txtMaThe.Text);
        }
        bool KiemTraThe()
        {
            String ma = txtMaThe.Text;
            if (ma == "")
            {
                MessageBox.Show("Bạn phải nhập vào mã thẻ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            CapNhatDS();

            TheDTO dto = TheBUS.SelectTheByID(ma);
            if (dto == null || dto.Ma == "")
            {
                MessageBox.Show("Mã thẻ không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Text = "";
                txtLoaiThe.Text = "";
                txtNgayCap.Text = "";
                txtNgayHetHan.Text = "";
                return false;
            }
            else
            {
                txtHoTen.Text = dto.TenDocGia;
                txtLoaiThe.Text = LoaiTheBUS.SelectLoaiTheByID(dto.LoaiThe).TenLoai;
                txtNgayCap.Text = dto.NgayCap.ToString("dd/MM/yyyy");
                txtNgayHetHan.Text = dto.NgayHetHan.ToString("dd/MM/yyyy");
                if (TheBUS.KiemTraThe(txtMaThe.Text) == false)
                {
                    MessageBox.Show("Thẻ này đã hết hạn sử dụng. Không thể mượn sách được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                return true;
            }
        }
        bool KiemTraSach()
        {
            String ma = txtMaSach.Text;
            if (ma == "")
            {
                MessageBox.Show("Bạn phải nhập vào mã sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            SachDTO dto = SachBUS.SelectSachByMa(ma);
            if (dto == null || dto.Ma == "")
            {
                MessageBox.Show("Mã sách không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenSach.Text = "";
                txtTacGia.Text = "";
                txtNgonNgu.Text = "";
                txtNhaXB.Text = "";

                return false;
            }
            else
            {
                txtTenSach.Text = dto.Ten;
                txtTacGia.Text = TacGiaBus.SelectTheByID(dto.TacGia).Ten;
                txtNgonNgu.Text = NgonNguBus.SelectNgonNguByID(dto.NgonNgu).Ten;
                txtNhaXB.Text = NhaXBBus.SelectNhaXBByID(dto.NhaXB).Ten;

                String str = SachBUS.KiemTraSach(txtMaSach.Text);
                if (str != "")
                {
                    MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                return true;
            }
        }

        private void dgvDSMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (TypeAction == "MuonSach")
            {
                return;
            }
            if (TypeAction == "TraSach")
            {
                btnTraSach.Enabled = true;
                btnMatSach.Enabled = true;
            }
            String MaSach = dgvDSMuon.SelectedRows[0].Cells["MaSach"].Value.ToString();
            SachDTO dto = SachBUS.SelectSachByMa(MaSach);
            txtMaSach.Text = MaSach;
            txtTenSach.Text = dto.Ten;
            txtTacGia.Text = TacGiaBus.SelectTheByID(dto.TacGia).Ten;
            txtNgonNgu.Text = NgonNguBus.SelectNgonNguByID(dto.NgonNgu).Ten;
            txtNhaXB.Text = NhaXBBus.SelectNhaXBByID(dto.NhaXB).Ten;

        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}