using AppStore.BLL;
using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class FTheLoai : Form
    {
        public FTheLoai()
        {
            InitializeComponent();
            ViewTL();
        }

        private void btAdd_DT_Click(object sender, EventArgs e)
        {
            txtMaTL.Text = "";
            txtTenTL.Text = "";
            txtTenTL.Enabled = true;            
            btDel_DT.Enabled = false;
            btEdit_DT.Enabled = false;
        }

        private void btSave_DT_Click(object sender, EventArgs e)
        {
            if (txtTenTL.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                Category add = new Category()
                {
                    CategoryName = txtTenTL.Text.ToString(),
                };
                if (txtMaTL.Text != "")
                {
                    add.CategoryID = Convert.ToInt32(txtMaTL.Text.ToString());
                }
                CatagoryBLL.Intance.AddorUpdateBLL(add);
                txtTenTL.Enabled = false;
                btDel_DT.Enabled = true;
                btEdit_DT.Enabled = true;
                txtMaTL.Text = "";
                txtTenTL.Text = "";
            }
            ViewTL();
        }
        private void ViewTL()
        {
            dtgv_DSTL.DataSource = CatagoryBLL.Intance.GetCategoriesBLL().Select(p => new { p.CategoryID,p.CategoryName}).ToList();
        }


        private void btEdit_DT_Click(object sender, EventArgs e)
        {
            if (dtgv_DSTL.SelectedRows.Count > 0)
            {
                txtTenTL.Enabled = true;
                DataGridViewRow r = dtgv_DSTL.CurrentRow;
                int edit = Convert.ToInt32(r.Cells[0].Value);
                Category a = CatagoryBLL.Intance.getCategoryBLL(edit);
                txtMaTL.Text = Convert.ToString(a.CategoryID);
                txtTenTL.Text = Convert.ToString(a.CategoryName);
            }
            else
            {
                MessageBox.Show("Vui long chon dong muon sua");
            }

        }

        private void btDel_DT_Click(object sender, EventArgs e)
        {
            if (dtgv_DSTL.SelectedRows.Count > 0)
            {
                DialogResult re = MessageBox.Show("Có muốn xóa không ?", "Xác nhận xóa ", MessageBoxButtons.OKCancel);
                if (re == DialogResult.OK)
                {
                    DataGridViewRow r = dtgv_DSTL.CurrentRow;
                    int del = Convert.ToInt32(r.Cells[0].Value);
                    ManufactureBLL.Intance.DeleteBLL(del);
                }
            }
            else
            {
                MessageBox.Show("Vui long chon dong muon xoa");
            }
            ViewTL();
        }

        private void btExitDT_Click(object sender, EventArgs e)
        {
            txtMaTL.Text = "";
            txtTenTL.Text = "";
            gbTTTL.Enabled = false;
            btDel_DT.Enabled = true;
            btEdit_DT.Enabled = true;
        }

        private void dtgv_DSTL_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtgv_DSTL.Columns[0].HeaderText = "Mã thể loại";
            dtgv_DSTL.Columns[1].HeaderText = "Tên thể loại";


        }
    }
}
