using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DTO;
using DAO;
using BUS;

namespace Presentation
{
    public partial class frmSach : Form
    {

        public frmSach()
        {
            InitializeComponent();
        }

        public void ShowMaster()
        {
            this.dataGridView1.AutoGenerateColumns = false;
            //string  loaisach = comboxLoaiSach.SelectedValue.ToString();
            // this.dataGridView1 .DataSource = SachBUS.SelectSachByLoaiSach(loaisach);
            this.dataGridView1.DataSource = SachBUS.SelectSachAll();
        }

        private string taoMaTuDong()
        {
            string str = "";
            str = Convert.ToString(DateTime.Now.Second) + Convert.ToString(DateTime.Now.Minute);
            return str;
        }
        private int dem_SoLuongSach()
        {

            List<SachDTO> lst = SachBUS.SelectSachAll();
            return lst.Count;
        }
        private void buttonNhapSach_Click(object sender, EventArgs e)
        {

            SachDTO sachDTO = new SachDTO();
            LoaiSachDTO loaiSachDTO = new LoaiSachDTO();
            NgonNguDto ngongNguDTO = new NgonNguDto();
            NhaXBDto nhaXB = new NhaXBDto();
            TacGiaDto tacGia = new TacGiaDto();

            /* nhaXB.Ten = this.txtTenNhaXB.Text;
             if (this.txtTenNhaXB.Text == "")
             {
                 MessageBox.Show("Bạn chưa nhập tên nhà xuất bản!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
             }*/
            // nhaXB.Ma = "NhaXB_00" + taoMaTuDong();
            // bool rs1 = NhaXBBus.Insert_NhaXB(nhaXB);

            /* tacGia.Ma = "TG_00" + taoMaTuDong();
          // tacGia.Ten = this.txtTacGia.Text;
           if (this.txtTacGia.Text == "")
           {
               MessageBox.Show("Bạn chưa nhập tên tác giả!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               return;
           }*/
            //   tacGia.NgaySinh = this.dateTimeNgaySinh.Value;
            // bool rs2 = TacGiaBus.Insert_TacGia(tacGia);




            sachDTO.Ma = this.txtMaSachInsert.Text;
            if (this.txtMaSachInsert.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã sách!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sachDTO.Ten = this.txtNhanDe.Text;
            if (this.txtNhanDe.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tựa sách!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // sachDTO.TacGia = tacGia.Ma;
            sachDTO.LoaiSach = this.comboxLoaiSach.SelectedValue.ToString();
            sachDTO.NgonNgu = this.comboxNgonNgu.SelectedValue.ToString();
            string textGia = this.txtGiaSach.Text;
            if (this.txtGiaSach.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập giá sách!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sachDTO.Gia = int.Parse(textGia);


            TacGiaDto tg = new TacGiaDto();
            int index = cbb_TacGia.SelectedIndex;

            tg = (TacGiaDto)cbb_TacGia.Items[index];
            sachDTO.TacGia = tg.Ma;


            NhaXBDto nxb = new NhaXBDto();
            index = cbb_nhaXB.SelectedIndex;
            nxb = (NhaXBDto)cbb_nhaXB.Items[index];

            sachDTO.NhaXB = nxb.Ma;
            // sachDTO.NhaXB = nhaXB.Ma;
            //List<SachDTO> lst =  SachBUS.SelectSachAll();
            // int sl = lst.Count;
            bool result = SachBUS.InsertSach(sachDTO);
            if (result == true)
            {
                MessageBox.Show("Insert Book have finish!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtSoLuong.Text = Convert.ToString(dem_SoLuongSach());
                this.ShowMaster();
            }
            else
            {
                MessageBox.Show("Fail!  ID has been exits \r\n Check Ma ,Please!", "Warning Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.frmSach1_Load(sender, e);
        }

        private void frmSach1_Load(object sender, EventArgs e)
        {

            this.comboxLoaiSach.ValueMember = "Ma";
            this.comboxLoaiSach.DisplayMember = "Ten";
            this.comboxLoaiSach.DataSource = LoaiSachBUS.SelectLoaiSachAll();

            this.comboxNgonNgu.ValueMember = "Ma";
            this.comboxNgonNgu.DisplayMember = "Ten";
            this.comboxNgonNgu.DataSource = NgonNguBus.SelectNgonNguAll();

            cbb_nhaXB.DataSource = NhaXBBus.SelectNhaXBAll();
            cbb_nhaXB.DisplayMember = "Ten";
            cbb_nhaXB.ValueMember = "Ma";
            cbb_TacGia.DataSource = TacGiaBus.SelectTacGiaAll();
            cbb_TacGia.DisplayMember = "Ten";
            cbb_TacGia.ValueMember = "Ma";

            this.txtSoLuong.Text = Convert.ToString(dem_SoLuongSach());
            this.ShowMaster();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReresh_Click(object sender, EventArgs e)
        {
            this.txtMaSachInsert.Text = "";
            this.txtGiaSach.Text = "";
            this.txtNhanDe.Text = "";



        }

        private void txtGiaSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Ban hay nhan so di!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }


        // update
        private void buttonCapNhat_Click_1(object sender, EventArgs e)
        {
            SachDTO sachDTO = new SachDTO();

            sachDTO.Ma = this.txtMaSachInsert.Text;//Mã Sách
            if (sachDTO.Ma != "")
            {

                sachDTO = SachBUS.SelectSachByMa(sachDTO.Ma);//
                if (this.txtNhanDe.Text == "")
                {
                    MessageBox.Show("Sách này không có tên sách ư?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                sachDTO.Ten = this.txtNhanDe.Text;//tên Sách
                if (this.txtGiaSach.Text == "")
                {
                    MessageBox.Show("Sách này không có Giá ư?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                sachDTO.Gia = int.Parse(this.txtGiaSach.Text);//Giá sách

                TacGiaDto tg = new TacGiaDto();
                int index = cbb_TacGia.SelectedIndex;
                tg = (TacGiaDto)cbb_TacGia.Items[index];
                sachDTO.TacGia = tg.Ma; // Tác Giả

                NhaXBDto nxb = new NhaXBDto();
                index = cbb_nhaXB.SelectedIndex;
                nxb = (NhaXBDto)cbb_nhaXB.Items[index];

                sachDTO.NhaXB = nxb.Ma;// Nhà XB


                sachDTO.LoaiSach = this.comboxLoaiSach.SelectedValue.ToString();// Loại Sách
                sachDTO.NgonNgu = this.comboxNgonNgu.SelectedValue.ToString();//Ngôn Ngữ


                bool result = SachBUS.UpdateSach(sachDTO);
                if (result == true)
                {
                    MessageBox.Show("Successful Update Book!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ShowMaster();
                }
                else
                {
                    MessageBox.Show("Fail!\r\nCheck ID Sach,Please!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Chưa chọn ID Sách cần Update", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            SachDTO sachDTO = new SachDTO();

            sachDTO.Ma = this.txtMaSachInsert.Text;
            sachDTO = SachBUS.SelectSachByMa(sachDTO.Ma);
            if (this.txtMaSachInsert.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã sách!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MuonSachDTO muonSachDTo = new MuonSachDTO();

            bool maS = MuonSachBUS.CheckMuonSachByMaSach(sachDTO.Ma);
            if (maS == true)// Xoa duoc or chua
            {

                SachMuonDTO sachMuonDTO = new SachMuonDTO();

                bool kq_sm = SachMuonBUS.CheckedSachMuonByID(muonSachDTo.MaMuonSach);
                if (kq_sm == false) //xoa duoc
                {
                    //kt denbu            

                    for (int i = 0; i < 10; i++)
                    {
                        DenBuDTO denBuDTO = new DenBuDTO();
                        bool denbu = DenBuBUS.SelectDenBuByMaMuonSach(muonSachDTo.MaMuonSach);
                        if (denbu == true)
                        {
                            denBuDTO = DenBuBUS.SelectDenBuByMa(muonSachDTo.MaMuonSach);
                            bool rs_db = DenBuBUS.DeleteDenBuByID(denBuDTO.Mamuonsach);
                            // if (rs_db == false)
                            // {
                            //  MessageBox.Show("Delete MaSach trong DenBu ko duoc!");
                            // }
                        }
                        //kt Phat

                        PhatDTO phatDTO = new PhatDTO();
                        phatDTO = PhatBUS.SelectPhatByID(muonSachDTo.MaMuonSach);
                        if (phatDTO.MaMuonSach != 0)
                        {
                            bool rs_p = PhatBUS.DeletePhatByID(phatDTO.MaMuonSach);
                            //if (rs_p == false)
                            //{
                            //    MessageBox.Show("Delete MaSach trong Phat ko duoc!");
                            //}
                        }
                    }

                    bool rs_ms = MuonSachBUS.DeleteMuonSachByMa(muonSachDTo.MaMuonSach);
                    if (rs_ms == false)
                    {
                        MessageBox.Show("Sách này đang được mượn!");
                        return;
                    }

                    //xoa sachMat
                    SachMatDto sachMatDTO = new SachMatDto();
                    sachMatDTO = SachMatBus.SelectSachMatByID(sachDTO.Ma);
                    if (sachMatDTO.Ma != "")
                    {
                        bool rs_sm = SachMatBus.DeleteSachMatByID(sachMatDTO.Ma);
                        if (rs_sm == false)
                        {
                            MessageBox.Show("Delete MaSach trong SachMat ko duoc!");
                        }

                    }
                    SachHongDTO sachHongDTO = new SachHongDTO();
                    sachHongDTO = SachHongBUS.SelectSachHongByID(sachDTO.Ma);
                    if (sachHongDTO.MaSach != "")
                    {
                        bool rs_sh = SachHongBUS.DeleteSachHongByID(sachHongDTO.MaSach);
                        if (rs_sh == false)
                        {
                            MessageBox.Show("Delete MaSach trong SachHong ko duoc!");
                        }

                    }
                    DialogResult rs = MessageBox.Show("Do you want to delete MaSach?" + sachDTO.Ma + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    // DialogResult dr = MessageBox.Show("Do you want to delete EmployeeID " + employeeID + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (rs == DialogResult.Yes)
                    {
                        bool kq = SachBUS.DeleteSachByMa(sachDTO.Ma);
                        if (kq == true)
                        {
                            MessageBox.Show("Delete Successful!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.txtSoLuong.Text = Convert.ToString(dem_SoLuongSach());
                            this.ShowMaster();
                        }
                        else
                        {
                            MessageBox.Show("Fail in delete!");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("MaSach nay co nguoi dang muon, ko the xoa!");
                }
            }
            else
            {
                DialogResult rs = MessageBox.Show("Do you want to delete MaSach?" + sachDTO.Ma + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                // DialogResult dr = MessageBox.Show("Do you want to delete EmployeeID " + employeeID + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rs == DialogResult.Yes)
                {
                    bool kq = SachBUS.DeleteSachByMa(sachDTO.Ma);

                    if (kq == true)
                    {
                        MessageBox.Show("Delete Successful!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.ShowMaster();
                        this.txtSoLuong.Text = Convert.ToString(dem_SoLuongSach());
                    }
                    else
                    {
                        MessageBox.Show("Fail in delete!");
                    }
                }
            }





        }

        private void buttonKiemTra_Click(object sender, EventArgs e)
        {
            SachDTO sachDTO1 = new SachDTO();
            if (this.txtMaSachInsert.Text == "")
            {
                MessageBox.Show("ID's Book hasn't choose !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sachDTO1.Ma = this.txtMaSachInsert.Text;
            bool rs = SachBUS.CheckMaSach(sachDTO1.Ma);
            if (rs == true)
            {
                MessageBox.Show("ID's Book has been exits!", "Check Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);


                SachDTO sachDTO = new SachDTO();

                sachDTO = SachBUS.SelectSachByMa(sachDTO1.Ma);
                this.txtNhanDe.Text = sachDTO.Ten;//ten

                this.txtGiaSach.Text = Convert.ToString(sachDTO.Gia);//gia



                TacGiaDto tacGiaDTO = new TacGiaDto();
                tacGiaDTO = TacGiaBus.SelectTheByID(sachDTO.TacGia);
                this.cbb_TacGia.Text = tacGiaDTO.Ten;//TG

                NgonNguDto ngonNguDTO = new NgonNguDto();
                ngonNguDTO = NgonNguBus.SelectNgonNguByID(sachDTO.NgonNgu);
                this.comboxNgonNgu.Text = ngonNguDTO.Ten;//NN

                NhaXBDto nhaXB = new NhaXBDto();
                nhaXB = NhaXBBus.SelectNhaXBByID(sachDTO.NhaXB);
                this.cbb_nhaXB.Text = nhaXB.Ten;//nha XB

                LoaiSachDTO loaiSachDTO = new LoaiSachDTO();
                loaiSachDTO = LoaiSachBUS.SelectLoaiSachByMa(sachDTO.LoaiSach);
                this.comboxLoaiSach.Text = loaiSachDTO.Ten;//loai sach
            }
            else
            {

                MessageBox.Show("Fail,ID's has not been exits!", "Check Fail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentRow != null)
            {
                this.txtMaSachInsert.Text = this.dataGridView1.CurrentRow.Cells["Ma"].Value.ToString();
                this.txtNhanDe.Text = this.dataGridView1.CurrentRow.Cells["Ten"].Value.ToString();
                this.txtGiaSach.Text = this.dataGridView1.CurrentRow.Cells["Gia"].Value.ToString();
                // this.txtTacGia.Text = this.dataGridView1.CurrentRow.Cells["TacGia"].Value.ToString();
                this.comboxLoaiSach.Text = this.dataGridView1.CurrentRow.Cells["LoaiSach"].Value.ToString();
                this.comboxNgonNgu.Text = this.dataGridView1.CurrentRow.Cells["NgonNgu"].Value.ToString();
                // this.txtTenNhaXB.Text = this.dataGridView1.CurrentRow.Cells["NhaXB"].Value.ToString();
            }

        }

        private void comboxLoaiSach_SelectedValueChanged(object sender, EventArgs e)
        {
            //this.ShowMaster();
        }

        private void txtMaSachInsert_Click(object sender, EventArgs e)
        {
            this.txtMaSachInsert.Text = "";
        }

        private void txtNhanDe_Click(object sender, EventArgs e)
        {
            this.txtNhanDe.Text = "";
        }

        /* private void txtTenNhaXB_Click(object sender, EventArgs e)
         {
             this.txtTenNhaXB.Text = "";
         }

         private void txtTacGia_Click(object sender, EventArgs e)
         {
             this.txtTacGia.Text = "";
         }*/

        private void txtGiaSach_Click(object sender, EventArgs e)
        {
            this.txtGiaSach.Text = "";
        }

        private void btn_ThemNXB_Click(object sender, EventArgs e)
        {

            frmThemNhaXB frm = new frmThemNhaXB();
            frm.ShowDialog();
        }
        private void btn_Themtg_Click_1(object sender, EventArgs e)
        {
            frmThemTacGia frm = new frmThemTacGia();
            frm.ShowDialog();
        }

    }
}