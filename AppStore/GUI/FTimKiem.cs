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
            //CustomerBLL bll = new CustomerBLL();
            cbb_MaKH.Items.AddRange(AccountBLL.Intance.getALLAcount().ToArray());
        }
        // button tìm kiếm 
        private void but_Search_Click(object sender, EventArgs e)
        {
            List<Product> result = new List<Product>();
            if (txtMaDT.Text == "" && txtTenDT.Text == "" && txtGiaMin.Text == "" && txtGiaMax.Text == "" && cbbMaHang.Text == "" && cbbMaTL.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm ");
            }
            else
            {
                CBBItem item1 = (CBBItem)cbbMaHang.SelectedItem;
                CBBItem item2 = (CBBItem)cbbMaTL.SelectedItem;
                string TenDT = txtTenDT.Text.ToString();
                string MaDT = txtMaDT.Text.ToString();
                string GiaMax = txtGiaMax.Text.ToString();
                string GiaMin = txtGiaMin.Text.ToString();
                string MaHang = item1.ID.ToString();
                string MaTL = item2.ID.ToString();
                result = ProductBLL.Intance.TimKiem(TenDT, MaDT, GiaMax, GiaMin, MaHang, MaTL);
                dtgv_DSTKDT.DataSource = result.Select(p => new { p.ProductID, p.ProductName, p.CostPrice, p.Description, p.Quantity, p.Manufacturer.ManufacturerName, p.Category.CategoryName }).ToList();
            }
        }
        private void SetCBB_TK()
        {
            CatagoryBLL cb1 = new CatagoryBLL();
            cbbMaTL.Items.AddRange(cb1.getAllCBBCatagory().ToArray());
            ManufactureBLL cb2 = new ManufactureBLL();
            cbbMaHang.Items.AddRange(cb2.getAllCBBManuFacture().ToArray());
        }

        private void cbbMaTL_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int ID = Convert.ToInt32(cbbMaTL.Text);
            //Category find = CatagoryBLL.Intance.getCategoryBLL(ID);
        }

        private void cbbMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int ID = Convert.ToInt32(cbbMaHang.Text);
            //Manufacturer find = ManufactureBLL.Intance.getManufactureBLL(ID);
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
            //// getl allcount
            //var account = AccountBLL.Intance.getAllcountByName(txt_TenKH.Text, int.Parse(cbbMaKH.Text));
            //Account a = account.First();
            //// get All Customer 
            //var employee = CustomerBLL.Intance.getAllCustomerByName(txt_TenNV.Text, int.Parse(cbbMaKH.Text));
            //Customer c = employee.First();
            //var invoice = InvoiceBLL.Intance.getInvoiceById(int.Parse(txt_MaHD.Text));
            //dtgv_DstkHD.DataSource = InvoiceBLL.Intance.getInvoiceByCusidAndAccountId(a.AccountID, c.CustomerID, invoice.InvoiceID);
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
                DateTime time = dateTimePicker1.Value;
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
