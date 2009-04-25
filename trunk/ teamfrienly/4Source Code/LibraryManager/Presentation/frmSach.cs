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
       // public int dem = 10;
        public frmSach()
        {
            InitializeComponent();
        }

        public void ShowMaster()
        {
            this.dataGridView1 .AutoGenerateColumns = false;
            string  loaisach = comboxLoaiSach.SelectedValue.ToString();
            this.dataGridView1 .DataSource = SachBUS.SelectSachByLoaiSach(loaisach);
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

            nhaXB.Ten = this.txtTenNhaXB.Text;
            nhaXB.Ma = "NhaXB_00" + taoMaTuDong();
            bool rs1 = NhaXBBus.Insert_NhaXB(nhaXB);

            tacGia.Ma = "TG_00" + taoMaTuDong();
            tacGia.Ten = this.txtTacGia.Text;
            tacGia.NgaySinh = this.dateTimeNgaySinh.Value;
            bool rs2 = TacGiaBus.Insert_TacGia(tacGia);




            sachDTO.Ma = this.txtMaSachInsert.Text ;
            sachDTO.Ten = this.txtNhanDe.Text;
            sachDTO.TacGia = tacGia.Ma;
            sachDTO.LoaiSach = this.comboxLoaiSach.SelectedValue.ToString();
            sachDTO.NgonNgu = this.comboxNgonNgu.SelectedValue.ToString();
            sachDTO.Gia = int.Parse(this.txtGiaSach.Text);


            sachDTO.NhaXB = nhaXB.Ma;


            bool result = SachBUS.InsertSach(sachDTO);
            if (result == true)
            {
                MessageBox.Show("Insert Book have finish!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ShowMaster();
            }
            else
            {
                MessageBox.Show("Fail! When Insert \r\n Check Ma ,Please!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.frmSach_Load(sender,e );
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            
            this.comboxLoaiSach.ValueMember = "Ma";
            this.comboxLoaiSach.DisplayMember = "Ten";
            this.comboxLoaiSach.DataSource = LoaiSachBUS.SelectLoaiSachAll();
            
            this.comboxNgonNgu.ValueMember = "Ma";
            this.comboxNgonNgu.DisplayMember = "Ten";
            this.comboxNgonNgu.DataSource = NgonNguBus.SelectNgonNguAll();
            //this.comboxLoaiSach.SelectedIndex = 1;
            this.txtSoLuong.Text = Convert.ToString(dem_SoLuongSach());
            this.ShowMaster ();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReresh_Click(object sender, EventArgs e)
        {
            this.txtMaSachInsert.Text  = "";
            this.txtGiaSach.Text = "";
            this.txtNhanDe.Text = "";
            this.txtTacGia.Text = "";
            this.txtTenNhaXB.Text = "";


        }

        private void txtGiaSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Ban hay nhan so di!");
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
           /* SachDTO sachDTO = new SachDTO();
            sachDTO.Ten = this.txtNhanDe.Text;
            sachDTO.Gia = int.Parse(this.txtGiaSach.Text);
            sachDTO.NgonNgu = comboxNgonNgu.SelectedValue.ToString();
            sachDTO.LoaiSach = comboxLoaiSach.SelectedValue.ToString();
            sachDTO.TacGia = this.txtTacGia.Text;
            sachDTO.NhaXB = this.txtTenNhaXB.Text;*/
        }

        private void comboMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {/*
            SachDTO sachDTO = new SachDTO();

            sachDTO = SachBUS.SelectSachByMa(comboMaSach.SelectedValue.ToString());
            this.txtNhanDe.Text = sachDTO.Ten;//ten

            this.txtGiaSach.Text = Convert.ToString(sachDTO.Gia);//gia

           

            TacGiaDto tacGiaDTO = new TacGiaDto();
            tacGiaDTO = TacGiaBus.SelectTheByID(sachDTO.TacGia);
            this.txtTacGia.Text = tacGiaDTO.Ten;//TG
            this.dateTimeNgaySinh.Text= Convert .ToString ( tacGiaDTO.NgaySinh);

            NgonNguDto ngonNguDTO = new NgonNguDto();
            ngonNguDTO = NgonNguBus.SelectNgonNguByID(sachDTO .NgonNgu );
            this.comboxNgonNgu.Text = ngonNguDTO.Ten;//NN

            NhaXBDto nhaXB = new NhaXBDto();
            nhaXB = NhaXBBus.SelectNhaXBByID(sachDTO .NhaXB );
            this.txtTenNhaXB.Text  = nhaXB.Ten;//nha XB

           
            
             LoaiSachDTO loaiSachDTO = new LoaiSachDTO();
             loaiSachDTO = LoaiSachBUS.SelectLoaiSachByMa(sachDTO.LoaiSach );
             this.comboxLoaiSach.Text = loaiSachDTO.Ten;//loai sach
          */

        }

      
        // update
        private void buttonCapNhat_Click_1(object sender, EventArgs e)
        {
            SachDTO sachDTO = new SachDTO();
            
            sachDTO.Ma = this.txtMaSachInsert .Text ;
            if (sachDTO.Ma != "")
            {

                sachDTO = SachBUS.SelectSachByMa(sachDTO.Ma);

                sachDTO.Ten = this.txtNhanDe.Text;
                sachDTO.Gia = int.Parse(this.txtGiaSach.Text);
                //  sachDTO .TacGia = this.txtTacGia .Text ;
                //  sachDTO.NgonNgu = comboxNgonNgu.SelectedValue.ToString();
                // sachDTO.LoaiSach = comboxLoaiSach.SelectedValue.ToString();
                // sachDTO.NhaXB = this.txtTenNhaXB.Text;

                NgonNguDto ngonNguDTO = new NgonNguDto();//NN
                ngonNguDTO = NgonNguBus.SelectNgonNguByID(sachDTO.NgonNgu);
                ngonNguDTO.Ma = comboxNgonNgu.SelectedValue.ToString();
                bool rs1 = NgonNguBus.UpdateNgonNgu(ngonNguDTO);
                if (rs1 == false)
                {
                    MessageBox.Show("Fail!\r\nCheck NgonNgu,Please!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                NhaXBDto nhaXB = new NhaXBDto();//NhXB
                nhaXB = NhaXBBus.SelectNhaXBByID(sachDTO.NhaXB);
                nhaXB.Ten = this.txtTenNhaXB.Text;
                bool rs2 = NhaXBBus.Update_NhaXB(nhaXB);
                if (rs2 == false)
                {
                    MessageBox.Show("Fail!\r\nCheck NhaXB,Please!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                TacGiaDto tacGiaDTO = new TacGiaDto();//TG
                tacGiaDTO = TacGiaBus.SelectTheByID(sachDTO.TacGia);
                tacGiaDTO.Ten = this.txtTacGia.Text;
                tacGiaDTO.NgaySinh = DateTime.Parse(this.dateTimeNgaySinh.Text);
                bool rs3 = TacGiaBus.UpdateTacGia(tacGiaDTO);
                if (rs3 == false)
                {
                    MessageBox.Show("Fail!\r\nCheck TacGia,Please!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoaiSachDTO loaiSachDTO = new LoaiSachDTO();//LS
                loaiSachDTO.Ma = comboxLoaiSach.SelectedValue.ToString();
                bool rs4 = TacGiaBus.UpdateTacGia(tacGiaDTO);
                if (rs4 == false)
                {
                    MessageBox.Show("Fail!\r\nCheck LoaiSach,Please!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                bool result = SachBUS.UpdateSach(sachDTO);
                if (result == true)
                {
                    MessageBox.Show("Successful!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.ShowMaster();
                }
                else
                {
                    MessageBox.Show("Fail!\r\nCheck Sach,Please!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Chua Chon thong tin can Update");
           
          
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            SachDTO sachDTO = new SachDTO();

           sachDTO.Ma = this.txtMaSachInsert .Text ;
           sachDTO = SachBUS.SelectSachByMa(sachDTO .Ma );

           MuonSachDTO muonSachDTo = new MuonSachDTO();
       //    muonSachDTo = MuonSachBUS.SelectedMuonSach_byMaSach (sachDTO.Ma);
           bool maS = MuonSachBUS.CheckMuonSachByMaSach(sachDTO.Ma);//////
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
                       MessageBox.Show("Delete MaSach trong MuonSach ko duoc!");
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
            sachDTO1.Ma = this.txtMaSachInsert .Text;
            bool rs = SachBUS.CheckMaSach(sachDTO1.Ma);
            if (rs == true)
            {
                MessageBox.Show("Sucessful,Ma sach nay ton tai!");

                //comboMaSach_SelectedIndexChanged(sender,e);
                SachDTO sachDTO = new SachDTO();

                sachDTO = SachBUS.SelectSachByMa(sachDTO1.Ma);
                this.txtNhanDe.Text = sachDTO.Ten;//ten

                this.txtGiaSach.Text = Convert.ToString(sachDTO.Gia);//gia



                TacGiaDto tacGiaDTO = new TacGiaDto();
                tacGiaDTO = TacGiaBus.SelectTheByID(sachDTO.TacGia);
                this.txtTacGia.Text = tacGiaDTO.Ten;//TG
                this.dateTimeNgaySinh.Text = Convert.ToString(tacGiaDTO.NgaySinh);

                NgonNguDto ngonNguDTO = new NgonNguDto();
                ngonNguDTO = NgonNguBus.SelectNgonNguByID(sachDTO.NgonNgu);
                this.comboxNgonNgu.Text = ngonNguDTO.Ten;//NN

                NhaXBDto nhaXB = new NhaXBDto();
                nhaXB = NhaXBBus.SelectNhaXBByID(sachDTO.NhaXB);
                this.txtTenNhaXB.Text = nhaXB.Ten;//nha XB



                LoaiSachDTO loaiSachDTO = new LoaiSachDTO();
                loaiSachDTO = LoaiSachBUS.SelectLoaiSachByMa(sachDTO.LoaiSach);
                this.comboxLoaiSach.Text = loaiSachDTO.Ten;//loai sach
            }
            else
                MessageBox.Show("Fail, ma sach ko ton tai!");
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (this .dataGridView1.CurrentRow  != null )
            {
               this .txtMaSachInsert.Text = this.dataGridView1 .CurrentRow.Cells ["Ma"].Value .ToString ();
               this .txtNhanDe .Text =this.dataGridView1 .CurrentRow .Cells ["Ten"].Value .ToString ();
               this.txtGiaSach.Text = this.dataGridView1.CurrentRow.Cells["Gia"].Value.ToString();
               this.txtTacGia.Text = this.dataGridView1.CurrentRow.Cells["TacGia"].Value.ToString();
               this.comboxLoaiSach.Text = this.dataGridView1.CurrentRow.Cells["LoaiSach"].Value.ToString();
               this.comboxNgonNgu .Text = this.dataGridView1.CurrentRow.Cells["NgonNgu"].Value.ToString();
               this.txtTenNhaXB.Text = this.dataGridView1.CurrentRow.Cells["NhaXB"].Value.ToString();
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

        private void txtTenNhaXB_Click(object sender, EventArgs e)
        {
            this.txtTenNhaXB.Text = "";
        }

        private void txtTacGia_Click(object sender, EventArgs e)
        {
            this.txtTacGia.Text = "";
        }

        private void txtGiaSach_Click(object sender, EventArgs e)
        {
            this.txtGiaSach.Text = "";
        }
        

       
    }
}