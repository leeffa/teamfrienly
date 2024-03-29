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
            //
            txtNgayCapNgay.MaxLength = 2;
            txtNgayCapThang.MaxLength = 2;
            txtNgayCapNam.MaxLength = 4;
            txtNgayHetHanNgay.MaxLength = 2;
            txtNgayHetHanThang.MaxLength = 2;
            txtNgayHetHanNam.MaxLength = 4;
            txtNgaySinhNgay.MaxLength = 2;
            txtNgaySinhThang.MaxLength = 2;
            txtNgaySinhNam.MaxLength = 4;
            //
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
            if (txtNgaySinhNgay.Text == "" || txtNgaySinhThang.Text == "" || txtNgaySinhNam.Text == "" || txtNgayHetHanNgay.Text == "" || txtNgayHetHanThang.Text == "" || txtNgayHetHanNam.Text == "" || txtNgaySinhNgay.Text == "" || txtNgaySinhThang.Text == "" || txtNgaySinhNam.Text == "")
            {
                MessageBox.Show("Bạn phải nhập ngày tháng đầy đủ");
                return;
            }
  
                        //kiem tra nam nhuan và số ngày của tháng 2
            if (txtNgayCapThang.Text == "2" && int.Parse(txtNgayCapNgay.Text) > 29 && DateTime.IsLeapYear(int.Parse(txtNgayCapNam.Text)) == true)
            {
                MessageBox.Show("Tháng 2 không có nhiều hơn 29 ngày", "Năm:" + txtNgayCapNam.Text);
            }

            else if (txtNgayCapThang.Text == "2" && int.Parse(txtNgayCapNgay.Text) > 28 && DateTime.IsLeapYear(int.Parse(txtNgayCapNam.Text)) == false)
            {
                MessageBox.Show("Tháng 2 không có nhiều hơn 28 ngày", "Năm:" + txtNgayCapNam.Text);
            }
            //ngay het han
            else if (txtNgayHetHanThang.Text == "2" && int.Parse(txtNgayHetHanNgay.Text) > 29 && DateTime.IsLeapYear(int.Parse(txtNgayHetHanNam.Text)) == true)
            {
                MessageBox.Show("Tháng 2 không có nhiều hơn 29 ngày", "Năm:" + txtNgayHetHanNam.Text);
            }
            else if (txtNgayHetHanThang.Text == "2" && int.Parse(txtNgayHetHanNgay.Text) > 28 && DateTime.IsLeapYear(int.Parse(txtNgayHetHanNam.Text)) == false)
            {
                MessageBox.Show("Tháng 2 không có nhiều hơn 28 ngày", "Năm:" + txtNgayHetHanNam.Text);
            }
            //ngay sinh
            else if (txtNgaySinhThang.Text == "2" && int.Parse(txtNgaySinhNgay.Text) > 29 && DateTime.IsLeapYear(int.Parse(txtNgaySinhNam.Text)) == true)
            {
                MessageBox.Show("Tháng 2 không có nhiều hơn 29 ngày", "Năm:" + txtNgaySinhNam.Text);
            }
            else if (txtNgaySinhThang.Text == "2" && int.Parse(txtNgaySinhNgay.Text) > 28 && DateTime.IsLeapYear(int.Parse(txtNgaySinhNam.Text)) == false)
            {
                MessageBox.Show("Tháng 2 không có nhiều hơn 28 ngày", "Năm:" + txtNgaySinhNam.Text);
            }

            if (txtMaThe.Text == "")
            {
                MessageBox.Show("Bạn phải nhập Mã thẻ");
                return;
            }
 

            try
            {
                the.Ma = this.txtMaThe.Text;
                the.LoaiThe = cbLoaiThe.SelectedValue.ToString();
                the.NgayCap = DateTime.Parse(txtNgayCapThang.Text + "/" + txtNgayCapNgay.Text + "/" + txtNgayCapNam.Text);
                the.NgayHetHan = DateTime.Parse(txtNgayHetHanThang.Text + "/" + txtNgayHetHanNgay.Text + "/" + txtNgayHetHanNam.Text);
                the.TenDocGia = this.txtTenDocGia.Text;
                the.NgaySinh = DateTime.Parse(txtNgaySinhThang.Text + "/" + txtNgaySinhNgay.Text + "/" + txtNgaySinhNam.Text);
                if (txtNgayCapThang.Text == "2" && int.Parse(txtNgayCapNam.Text) > 28 && DateTime.IsLeapYear(int.Parse(txtNgayCapNam.Text)) == true)
                {
                    MessageBox.Show("Tháng 2 không có nhiều hơn 29 ngày");
                }

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
            if (txtNgaySinhNgay.Text == "" || txtNgaySinhThang.Text == "" || txtNgaySinhNam.Text == "" || txtNgayHetHanNgay.Text == "" || txtNgayHetHanThang.Text == "" || txtNgayHetHanNam.Text == "" || txtNgaySinhNgay.Text == "" || txtNgaySinhThang.Text == "" || txtNgaySinhNam.Text == "")
            {
                MessageBox.Show("Bạn phải nhập ngày tháng đầy đủ");
                return;
            }

            //kiem tra nam nhuan và số ngày của tháng 2
            if (txtNgayCapThang.Text == "2" && int.Parse(txtNgayCapNgay.Text) > 29 && DateTime.IsLeapYear(int.Parse(txtNgayCapNam.Text)) == true)
            {
                MessageBox.Show("Tháng 2 không có nhiều hơn 29 ngày", "Năm:" + txtNgayCapNam.Text);
            }
            
            else if (txtNgayCapThang.Text == "2" && int.Parse(txtNgayCapNgay.Text) > 28 && DateTime.IsLeapYear(int.Parse(txtNgayCapNam.Text)) == false)
            {
                MessageBox.Show("Tháng 2 không có nhiều hơn 28 ngày", "Năm:" + txtNgayCapNam.Text);
            }
            //ngay het han
            else if (txtNgayHetHanThang.Text == "2" && int.Parse(txtNgayHetHanNgay.Text) > 29 && DateTime.IsLeapYear(int.Parse(txtNgayHetHanNam.Text)) == true)
            {
                MessageBox.Show("Tháng 2 không có nhiều hơn 29 ngày", "Năm:" + txtNgayHetHanNam.Text);
            }
            else if (txtNgayHetHanThang.Text == "2" && int.Parse(txtNgayHetHanNgay.Text) > 28 && DateTime.IsLeapYear(int.Parse(txtNgayHetHanNam.Text)) == false)
            {
                MessageBox.Show("Tháng 2 không có nhiều hơn 28 ngày", "Năm:" + txtNgayHetHanNam.Text);
            }
            //ngay sinh
            else if (txtNgaySinhThang.Text == "2" && int.Parse(txtNgaySinhNgay.Text) > 29 && DateTime.IsLeapYear(int.Parse(txtNgaySinhNam.Text)) == true)
            {
                MessageBox.Show("Tháng 2 không có nhiều hơn 29 ngày", "Năm:" + txtNgaySinhNam.Text);
            }
            else if (txtNgaySinhThang.Text == "2" && int.Parse(txtNgaySinhNgay.Text) > 28 && DateTime.IsLeapYear(int.Parse(txtNgaySinhNam.Text)) == false)
            {
                MessageBox.Show("Tháng 2 không có nhiều hơn 28 ngày", "Năm:" + txtNgaySinhNam.Text);
            }

            if (txtMaThe.Text=="")
            {
                MessageBox.Show("Bạn phải nhập Mã thẻ");
                return;
            }
  
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
        // ngay thang khong cho nhap chu va cac ki tu khac so
        private void txtNgayCapNgay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)!=true)
                e.Handled = true;
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtNgayCapThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) != true)
                e.Handled = true;
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

        }

        private void txtNgayHetHanNgay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) != true)
                e.Handled = true;
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

        }

        private void txtNgaySinhNgay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) != true)
                e.Handled = true;
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

        }
        // ma the khong duoc co khoang trang
        private void txtMaThe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) == true)
                e.Handled = true;
 
        }
        //ten khong cho nhap so
        private void txtTenDocGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) != true)
                e.Handled = true;
            if (char.IsControl(e.KeyChar) ||char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        
    }
}