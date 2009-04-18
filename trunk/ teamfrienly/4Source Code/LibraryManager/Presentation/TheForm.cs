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
    public partial class TheForm : Form
    {
        public TheForm()
        {
            InitializeComponent();
        }
        public void ShowTatCaThe()
        {
            this.dgvThe.AutoGenerateColumns = false;
            string loaithe =  cbLoaiThe.SelectedValue.ToString();
            this.dgvThe.DataSource = TheBUS.SelectTheByLoaiThe(loaithe);
            
        
        }

        private void TheForm_Load(object sender, EventArgs e)
        {
            this.cbLoaiThe.ValueMember = "Ma";
            this.cbLoaiThe.DisplayMember = "TenLoai";
            this.cbLoaiThe.DataSource = LoaiTheBUS.SelectLoaiTheAll();

            this.ShowTatCaThe();          

        }

        private void cbLoaiThe_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ShowTatCaThe();

        }
 

        private void dgvThe_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgvThe.CurrentRow != null)
            {
                this.txtMaThe.Text = this.dgvThe.CurrentRow.Cells["MaThe"].Value.ToString();
                this.txtTenDocGia.Text = this.dgvThe.CurrentRow.Cells["TenDocGia"].Value.ToString();
                this.txtNgayCapNgay.Text = DateTime.Parse(this.dgvThe.CurrentRow.Cells["NgayCap"].Value.ToString()).Day.ToString();
                this.txtNgayCapThang.Text = DateTime.Parse(this.dgvThe.CurrentRow.Cells["NgayCap"].Value.ToString()).Month.ToString();
                this.txtNgayCapNam.Text = DateTime.Parse(this.dgvThe.CurrentRow.Cells["NgayCap"].Value.ToString()).Year.ToString();
                this.txtNgayHetHanNgay.Text = DateTime.Parse(this.dgvThe.CurrentRow.Cells["NgayHetHan"].Value.ToString()).Day.ToString();
                this.txtNgayHetHanThang.Text=DateTime.Parse(this.dgvThe.CurrentRow.Cells["NgayHetHan"].Value.ToString()).Month.ToString();
                this.txtNgayHetHanNam.Text = DateTime.Parse(this.dgvThe.CurrentRow.Cells["NgayHetHan"].Value.ToString()).Year.ToString();
                this.txtNgaySinhNgay.Text = DateTime.Parse(this.dgvThe.CurrentRow.Cells["NgaySinh"].Value.ToString()).Day.ToString();
                this.txtNgaySinhThang.Text = DateTime.Parse(this.dgvThe.CurrentRow.Cells["NgaySinh"].Value.ToString()).Month.ToString();
                this.txtNgaySinhNam.Text = DateTime.Parse(this.dgvThe.CurrentRow.Cells["NgaySinh"].Value.ToString()).Year.ToString();
            }


        }

        private void btLamLai_Click(object sender, EventArgs e)
        {
            txtTenDocGia.Text = "";
            txtMaThe.Text = "";
            txtNgayCapNgay.Text = "";
            txtNgayCapThang.Text = "";
            txtNgayCapNam.Text = "";
            txtNgayHetHanNgay.Text = "";
            txtNgayHetHanThang.Text = "";
            txtNgayHetHanNam.Text = "";
            txtNgaySinhNgay.Text = "";
            txtNgaySinhThang.Text = "";
            txtNgaySinhNam.Text = "";
            
        }
        

        private void btThem_Click(object sender, EventArgs e)
        {

            TheDTO the = new TheDTO();
            try
            {
                the.Ma = this.txtMaThe.Text;
                the.LoaiThe = cbLoaiThe.SelectedValue.ToString();
                the.NgayCap = DateTime.Parse(txtNgayCapThang.Text + "/" + txtNgayCapNgay.Text + "/" + txtNgayCapNam.Text);
                the.NgayHetHan = DateTime.Parse(txtNgayHetHanThang.Text + "/" + txtNgayHetHanNgay.Text + "/" + txtNgayHetHanNam.Text);
                the.TenDocGia = this.txtTenDocGia.Text;
                the.NgaySinh = DateTime.Parse(txtNgaySinhThang.Text + "/" + txtNgaySinhNgay.Text + "/" + txtNgaySinhNam.Text);

                bool result = TheBUS.InsertThe(the);
                if (result == true)
                {
                    MessageBox.Show("Thành Công!", "Thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ShowTatCaThe();
                }
                else
                {
                    MessageBox.Show("Không thành công!\r\nChọn Mã Thẻ khác!", "Thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            	
            }


        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            TheDTO the = new TheDTO();

            try
            {
                the.Ma = this.txtMaThe.Text;
                the.LoaiThe = cbLoaiThe.SelectedValue.ToString();
                the.NgayCap = DateTime.Parse(txtNgayCapThang.Text + "/" + txtNgayCapNgay.Text + "/" + txtNgayCapNam.Text);
                the.NgayHetHan = DateTime.Parse(txtNgayHetHanThang.Text + "/" + txtNgayHetHanNgay.Text + "/" + txtNgayHetHanNam.Text);
                the.TenDocGia = this.txtTenDocGia.Text;
                the.NgaySinh = DateTime.Parse(txtNgaySinhThang.Text + "/" + txtNgaySinhNgay.Text + "/" + txtNgaySinhNam.Text);
                //
                bool result = TheBUS.UpdateThe(the);
                if (result == true)
                {
                    MessageBox.Show("Thành Công!", "Cập Nhật", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ShowTatCaThe();
                }
                else
                {
                    MessageBox.Show("Không thành công!\r\nChọn Mã Thẻ khác!", "Cập Nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvThe.CurrentRow != null)
                {
                    String mathe = this.dgvThe.CurrentRow.Cells["MaThe"].Value.ToString();
                    DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa thẻ có Mã " + mathe + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        bool result = TheBUS.DeleteTheByID(mathe);
                        if (result == true)
                        {
                            MessageBox.Show("Thành công!", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ShowTatCaThe();
                        }
                        else
                        {
                            MessageBox.Show("Không thành công!\r\nKiểm tra lại mã thẻ!", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!\r\nHãy chọn một thẻ!", "Xóa6", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}