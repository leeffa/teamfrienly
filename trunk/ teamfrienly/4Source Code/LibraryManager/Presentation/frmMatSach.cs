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
    public partial class frmMatSach : Form
    {
        public frmMatSach()
        {
            InitializeComponent();
        }

        private void frmMatSach_Load(object sender, EventArgs e)
        {
            String maSach = ((frmMuonSach)Owner).MaSachMuon;
            SachDTO dto = SachBUS.SelectSachByMa(maSach);
            txtMaSach.Text = dto.Ma;
            txtTenSach.Text = dto.Ten;
            txtTacGia.Text = dto.TacGia;
            txtNgonNgu.Text = dto.NgonNgu;
            txtNhaXB.Text = dto.NhaXB;
            txtGia.Text = dto.Gia.ToString();
            txtTienPhat.Text= (dto.Gia + 50000).ToString();
        }
   
        private void btnOK_Click(object sender, EventArgs e)
        {
            SachMatDto smDto = new SachMatDto();
            smDto.Ma = txtMaSach.Text;
            SachMatBus.Insert_SachMat(smDto);
            // tinh tien den bu
            DenBuDTO dbDto = new DenBuDTO();
            MuonSachDTO mDto = MuonSachBUS.LayPhieuMuonSach_byMaSach(txtMaSach.Text);
            SachDTO sDto = SachBUS.SelectSachByMa(mDto.MaSach);
            dbDto.Mamuonsach = mDto.MaMuonSach;
            dbDto.Sotien = sDto.Gia + 50000;
            DenBuBUS.InsertDenBu(dbDto);

            //xoa trong sach muon
            SachMuonBUS.DeleteSachMuonByID(mDto.MaMuonSach);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}