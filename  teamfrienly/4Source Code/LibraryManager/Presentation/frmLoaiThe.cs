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
    public partial class frmLoaiThe : Form
    {
        public frmLoaiThe()
        {
            InitializeComponent();
        }

        void CapNhat()
        {
            this.cmbMaLoai.DisplayMember = "Ma";
            this.cmbMaLoai.ValueMember = "Ma";
            this.cmbMaLoai.DataSource = LoaiTheBUS.SelectLoaiThe();
            cmbMaLoai.SelectedIndex = 0;
        }
        private void frmLoaiThe_Load(object sender, EventArgs e)
        {
            CapNhat();
            this.MaximizeBox = false;        
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbMaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = ((DataTable)cmbMaLoai.DataSource);
            txtTenThe.Text = dt.Rows[cmbMaLoai.SelectedIndex][1].ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LoaiTheDTO temp = new LoaiTheDTO();
            temp.Ma = cmbMaLoai.Text;
            temp.TenLoai = txtTenThe.Text;
            if (LoaiTheBUS.InsertLoaiThe(temp)==false)
            {
                MessageBox.Show("Loại thẻ này đã tồn tại.Hãy nhập mã loại khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CapNhat();
            
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LoaiTheDTO temp = new LoaiTheDTO();
            temp.Ma = cmbMaLoai.Text;
            temp.TenLoai = txtTenThe.Text;
            if (LoaiTheBUS.UpdateLoaiThe(temp) == false)
            {
                MessageBox.Show("Cập nhật không thành công.Hãy kiểm tra mã loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CapNhat();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String id = cmbMaLoai.Text;
            if (LoaiTheBUS.DeleteLoaiTheByID(id) == false)
            {
                MessageBox.Show("Mã loại thẻ không tồn tại.Hãy kiểm tra mã loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CapNhat();
        }
    }
}