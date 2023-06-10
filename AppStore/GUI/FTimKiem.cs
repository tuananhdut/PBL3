using AppStore.BLL;
using AppStore.BLL.DTO;
using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class FTimKiem : Form
    {
        public FTimKiem()
        {
            InitializeComponent();
            SetCBB_TK();
            setCBBCustomerID();
            setCBBAccountId();
            txtGiaMin.Text = "0";
        }
        private void btSearchCustomer_Click(object sender, EventArgs e)
        {
            List<Customer> li = new List<Customer>();
            try
            {
                int id = Convert.ToInt32(tbCustomerID.Text);
                li = CustomerBLL.Intance.searchCustomer(tbCustomerName.Text, tbCustomerAddress.Text, tbCustomerPhoneNumber.Text,id);
            }
            catch (Exception)
            {
                li = CustomerBLL.Intance.searchCustomer(tbCustomerName.Text, tbCustomerAddress.Text, tbCustomerPhoneNumber.Text);
            }
            finally
            {
                dtgvCustomer.Rows.Clear();
                foreach (var customer in li)
                {
                    dtgvCustomer.Rows.Add(customer.CustomerID, customer.FullName, customer.PhoneNumber, customer.Address);
                }
            }
        }
        private void btResetCustomer_Click(object sender, EventArgs e)
        {
            tbCustomerID.Text = "";
            tbCustomerName.Text = "";
            tbCustomerAddress.Text = "";
            tbCustomerPhoneNumber.Text = "";
            dtgvCustomer.Rows.Clear();
        }

        private void tbCustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn sự kiện KeyPress
                MessageBox.Show("vui lòng nhập số", "thông báo");
            }
        }

        private void btResetEmployss_Click(object sender, EventArgs e)
        {
            tbEmployssName.Text = "";
            tbEmployssID.Text = "";
            tbEmployssAddress.Text = "";
            tbEmployssPhone.Text = "";
            dtgvEmployss.Rows.Clear();
        }

        private void btSearchEmployss_Click(object sender, EventArgs e)
        {
            List<Account> li = new List<Account>();
            try
            {
                int id = Convert.ToInt32(tbEmployssID.Text);
                li = AccountBLL.Intance.searchAccount(tbCustomerName.Text, tbEmployssAddress.Text, tbEmployssPhone.Text,id);
            }
            catch (Exception)
            {
                li = AccountBLL.Intance.searchAccount(tbEmployssName.Text, tbEmployssAddress.Text, tbEmployssPhone.Text);
            }
            finally
            {
                dtgvEmployss.Rows.Clear();
                foreach (var account in li)
                {
                    dtgvEmployss.Rows.Add(account.AccountID, account.FullName, account.PhoneNumber, account.Address);
                }
            }
           
        }
        // Tìm kiếm điện thoại
        //Chỉnh tên cột sau khi binding code
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtgv_DSTKDT.Columns[0].HeaderText = "Mã sản phẩm";
            dtgv_DSTKDT.Columns[1].HeaderText = "Tên sản phẩm";
            dtgv_DSTKDT.Columns[2].HeaderText = "Giá bán";
            dtgv_DSTKDT.Columns[3].HeaderText = "Màu sắc";
            dtgv_DSTKDT.Columns[4].HeaderText = "Số lượng";
            dtgv_DSTKDT.Columns[5].HeaderText = "Hãng";
            dtgv_DSTKDT.Columns[6].HeaderText = "Thể loại";
        }

        private void but_resert_Click(object sender, EventArgs e)
        {
            SetThongTinTK();
        }
        // đặt lại thông tin tìm kiếm 
        private void SetThongTinTK()
        {
            txtTenDT.Text = "";
            txtMaDT.Text = "";
            txtGiaMin.Text = "0";
            txtGiaMax.Text = "";
            cbbMaHang.Text = "";
            cbbMaTL.Text = "";
            txtTenDT.Enabled = true;
            txtMaDT.Enabled = true;
            txtGiaMin.Enabled = true;
            txtGiaMax.Enabled = true;
            cbbMaHang.Enabled = true;
            cbbMaTL.Enabled = true;
            dtgv_DSTKDT.DataSource = null;
        }
        private void setCBBCustomerID()
        {
            //CustomerBLL bll = new CustomerBLL();
            cbb_MaKH.Items.AddRange(CustomerBLL.Intance.getALLCustomer().ToArray());
        }
        private void setCBBAccountId()
        {
            cbb_MaNV.Items.AddRange(AccountBLL.Intance.getALLAcount().ToArray());
        }
        // button tìm kiếm 
        private void but_Search_Click(object sender, EventArgs e)
        {
            List<Product> result = new List<Product>();
            if (txtMaDT.Text == "" && txtTenDT.Text == "" && txtGiaMin.Text == "0" && txtGiaMax.Text == "" && cbbMaHang.Text == "" && cbbMaTL.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm ");
            }
            else
            {
                string MaHang="";
                string MaTL="";
                if (cbbMaHang.Text != "")
                {
                    CBBItem item1 = (CBBItem)cbbMaHang.SelectedItem;
                    MaHang = Convert.ToString(item1.ID);
                }
                if (cbbMaTL.Text != "")
                {
                    CBBItem item2 = (CBBItem)cbbMaTL.SelectedItem;
                    MaTL = Convert.ToString(item2.ID);

                }
                string TenDT = txtTenDT.Text.ToString();
                string MaDT = txtMaDT.Text.ToString();
                string GiaMax = txtGiaMax.Text.ToString();
                string GiaMin = txtGiaMin.Text.ToString();
                
                result = ProductBLL.Intance.TimKiem(TenDT, MaDT, GiaMax, GiaMin, MaHang, MaTL);
                dtgv_DSTKDT.DataSource = result.Select(p => new { p.ProductID, p.ProductName, p.SalePrice, p.Description, p.Quantity, p.Manufacturer.ManufacturerName, p.Category.CategoryName }).ToList();
            }
        }
        private void SetCBB_TK()
        {
            CatagoryBLL cb1 = new CatagoryBLL();
            cbbMaTL.Items.AddRange(cb1.getAllCBBCatagory().ToArray());
            ManufactureBLL cb2 = new ManufactureBLL();
            cbbMaHang.Items.AddRange(cb2.getAllCBBManuFacture().ToArray());
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer ct = (Customer)(cbb_MaKH.SelectedItem);
            txt_TenKH.Text = ct.FullName;
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

            Account account = (Account)(cbb_MaNV.SelectedItem);
            txt_TenNV.Text = account.FullName;
        }

       
         // Tìm kiếm hóa đơn
        private void butResert_Click(object sender, EventArgs e)
        {
            txtMaHoaDon.Text = "";
            txt_TenKH.Text = "";
            txt_TenNV.Text = "";
            cbb_MaKH.Text = "";
            cbb_MaNV.Text = "";
            dtgv_DstkHD.DataSource = null;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            
            if (txtMaHoaDon.Text == "" && cbb_MaKH.Text == "" && cbb_MaNV.Text == "" && txt_TenKH.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm ");
            }
            else
            {
                string MaHoaDon = txtMaHoaDon.Text.ToString();
                string MaKH = cbb_MaKH.Text.ToString();
                string MaNV = cbb_MaNV.Text.ToString();
                string TenKH = txt_TenKH.Text.ToString();
                List<Invoice> result = InvoiceBLL.Intance.TimkiemHoaDon(MaHoaDon, MaKH, MaNV, TenKH);
                dtgv_DstkHD.DataSource = result.Select(p => new { p.InvoiceID, p.CustomerID, p.Customer.FullName, p.EmployeeID, p.InvoiceDate, p.TotalAmount }).ToList();
            }
        }

        private void dtgv_DstkHD_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtgv_DstkHD.Columns[0].HeaderText = "Mã hóa đơn";
            dtgv_DstkHD.Columns[1].HeaderText = "Mã khách hàng";
            dtgv_DstkHD.Columns[2].HeaderText = "Tên khách hàng";
            dtgv_DstkHD.Columns[3].HeaderText = "Mã nhân viên";
            dtgv_DstkHD.Columns[4].HeaderText = "Ngày tạo hóa đơn";
            dtgv_DstkHD.Columns[5].HeaderText = "Tổng tiền";
        }

    }
}
