using AppStore.BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
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
            SetBang();
        }

        private void btAdd_DT_Click(object sender, EventArgs e)
        {
            gb_HangSX.Enabled = true;
            btAdd_DT.Enabled = false;
            btDel_DT.Enabled= false;
            btEdit_DT.Enabled= false;
            
        }

        private void btSave_DT_Click(object sender, EventArgs e)
        {
            if(txt_TenHang.Text=="" || txt_DiaChi.Text == "")
            {
                MessageBox.Show("Vui long nhap du thong tin");
            }else
            {
                Manufacturer add = new Manufacturer()
                {
                    ManufacturerName = txt_TenHang.Text.ToString(),
                    Address = txt_DiaChi.Text.ToString(),
                };
                if (txt_MaHang.Text != "")
                {
                    add.ManufacturerID = Convert.ToInt32(txt_MaHang.Text);
                }
                ManufactureBLL.Intance.AddorUpdateBLL(add);
                SetTTHang();
            }
            SetBang();
        }
        // Set Thông tin hãng về null
        private void SetTTHang()
        {
            txt_MaHang.Text = "";
            txt_TenHang.Text = "";
            txt_DiaChi.Text = "";
            btAdd_DT.Enabled = true;
            btDel_DT.Enabled= true;
            btEdit_DT.Enabled= true;
            gb_HangSX.Enabled = false;
        }
        // In bảng ra datagirdview
        private void SetBang()
        {
            dtgv_DSHSX.DataSource = ManufactureBLL.Intance.GetManufacturesBLL();
        }
        private void btDel_DT_Click(object sender, EventArgs e)
        {
            if(dtgv_DSHSX.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dtgv_DSHSX.CurrentRow;
                int del = Convert.ToInt32(r.Cells[0].Value);
                ManufactureBLL.Intance.DeleteBLL(del);
            }else
            {
                MessageBox.Show("Vui Long chon dong xoa");
            }
            SetBang();
        }

        private void btEdit_DT_Click(object sender, EventArgs e)
        {
            gb_HangSX.Enabled = true;
            if (dtgv_DSHSX.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dtgv_DSHSX.CurrentRow;
                int edit = Convert.ToInt32(r.Cells[0].Value);
                Manufacturer a = ManufactureBLL.Intance.getManufactureBLL(edit);
                txt_DiaChi.Text = a.Address.ToString();
                txt_TenHang.Text = a.ManufacturerName.ToString();
                txt_MaHang.Text = a.ManufacturerName.ToString();
            }
            else
            {
                MessageBox.Show("Vui Long chon dong xoa");
            }
            SetBang();
        }
    }
}
