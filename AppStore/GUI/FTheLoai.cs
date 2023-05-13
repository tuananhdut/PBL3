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

        private void btAdd_TL_Click(object sender, EventArgs e)
        {
            gbTTTL.Enabled = true;
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
                if (txtMaTL.Text!="")
                {
                   add.CategoryID= Convert.ToInt32(txtMaTL.Text.ToString());
                }
                CatagoryBLL.Intance.AddorUpdateBLL(add);
                gbTTTL.Enabled = false;
                btDel_DT.Enabled = true;
                btEdit_DT.Enabled = true;
            }
            ViewTL();
        }
        private void ViewTL()
        {
            dtgv_DSTL.DataSource = CatagoryBLL.Intance.GetCategoriesBLL();
        }

        private void btEdit_DT_Click(object sender, EventArgs e)
        {

            if (dtgv_DSTL.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dtgv_DSTL.CurrentRow;
                int edit = Convert.ToInt32(r.Cells[0].Value);
                Category a = CatagoryBLL.Intance.getCategoryBLL(edit);
                txtMaTL.Text=Convert.ToString(a.CategoryID);
                txtTenTL.Text=Convert.ToString(a.CategoryName);
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
                DataGridViewRow r = dtgv_DSTL.CurrentRow;
                int del = Convert.ToInt32(r.Cells[0].Value);
                CatagoryBLL.Intance.DeleteBLL(del);
            }
            else
            {
                MessageBox.Show("Vui long chon dong muon xoa");
            }
            ViewTL();
        }
    }
}
