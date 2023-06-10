using AppStore.BLL;
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
    public partial class Hang : Form
    {
        public Hang()
        {
            InitializeComponent();
            ViewHang();
        }

        private void btAdd_DT_Click(object sender, EventArgs e)
        {
            txt_DiaChi.Enabled = true;
            txt_TenHang.Enabled = true;
            btAdd_DT.Enabled = false;
            btDel_DT.Enabled = false;
            btEdit_DT.Enabled = false;
        }

        private void btSave_DT_Click(object sender, EventArgs e)
        {
            if (txt_TenHang.Text == "" || txt_DiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin thiếu ");
            }
            else
            {
                Manufacturer add = new Manufacturer()
                {
                    ManufacturerName = txt_TenHang.Text.ToString(),
                    Address = txt_DiaChi.Text.ToString(),
                };
                if (txt_MaHang.Text != "")
                {
                    add.ManufacturerID = Convert.ToInt32(txt_MaHang.Text.ToString());
                }
                ManufactureBLL.Intance.AddorUpdateBLL(add);
                SetTTHang();
            }
            ViewHang();
        }
        // Set Thông tin hãng về null
        private void SetTTHang()
        {
            txt_MaHang.Text = "";
            txt_TenHang.Text = "";
            txt_DiaChi.Text = "";
            btAdd_DT.Enabled = true;
            btDel_DT.Enabled = true;
            btEdit_DT.Enabled = true;
            txt_DiaChi.Enabled = false;
            txt_TenHang.Enabled = false;
        }
        private void ViewHang()
        {
            dtgv_DSHSX.DataSource = ManufactureBLL.Intance.GetManufacturesBLL().Select(p => new {p.ManufacturerID,p.ManufacturerName,p.Address }).ToList();
        }
        private void btEdit_DT_Click(object sender, EventArgs e)
        {
            txt_TenHang.Enabled = true;
            txt_DiaChi.Enabled = true;
            if (dtgv_DSHSX.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dtgv_DSHSX.CurrentRow;
                int edit = Convert.ToInt32(r.Cells[0].Value);
                Manufacturer a = ManufactureBLL.Intance.getManufactureBLL(edit);
                txt_DiaChi.Text = a.Address.ToString();
                txt_TenHang.Text = a.ManufacturerName.ToString();
                txt_MaHang.Text = a.ManufacturerID.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng muốn sửa");
            }
            ViewHang();
        }

        private void btDel_DT_Click(object sender, EventArgs e)
        {
            if (dtgv_DSHSX.SelectedRows.Count > 0)
            {
                DialogResult re = MessageBox.Show("Có muốn xóa không ?", "Xác nhận xóa ", MessageBoxButtons.OKCancel);
                if (re == DialogResult.OK)
                {
                    DataGridViewRow r = dtgv_DSHSX.CurrentRow;
                    int del = Convert.ToInt32(r.Cells[0].Value);
                    ManufactureBLL.Intance.DeleteBLL(del);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng muốn xóa ");
            }
            ViewHang();
        }

        private void btExitDT_Click(object sender, EventArgs e)
        {
            SetTTHang();
        }

        private void dtgv_DSHSX_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtgv_DSHSX.Columns[0].HeaderText = "ID Hãng";
            dtgv_DSHSX.Columns[1].HeaderText = "Tên Hãng ";
            dtgv_DSHSX.Columns[2].HeaderText = "Địa chỉ";
        }
    }
}
