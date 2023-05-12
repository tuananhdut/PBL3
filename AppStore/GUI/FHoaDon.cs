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
    public partial class FHoaDon : Form
    {
        private Account acc;
        public FHoaDon(Account acc)
        {
            InitializeComponent();
            this.acc = acc;
            setCBBProuctID();
            setCBBCustomerID();
        }
        
        private void setCBBCustomerID()
        {
            //CustomerBLL bll = new CustomerBLL();
            cbbCustomerID.Items.AddRange(CustomerBLL.Intance.getALLCustomer().ToArray());
        }
        
        private void btAddInvoice_Click(object sender, EventArgs e)
        {

             setNullThongTinChung();

            tbInvoiceDate.Text = DateTime.Now.ToString();
            tbEmployeeID.Text = acc.AccountID.ToString();
            tbEmployeeName.Text = acc.FullName;

            // khóa các textbox
            tbInvoiceDate.Enabled = false;
            tbEmployeeID.Enabled = false;
           tbEmployeeName.Enabled = false;

            // khóa các chức năng 
           btUpdateInvoice.Enabled = false;
            btPrintInvoice.Enabled = false;
            btChecking.Enabled = false;
          
        }

    

        private void cbbCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer ct = (Customer)(cbbCustomerID.SelectedItem);
            tbCustomerName.Text = ct.FullName;
            tbAddressCustomer.Text = ct.Address;
            tbPhoneNumber.Text = ct.PhoneNumber;
        }

        private void setCBBProuctID()
        {
            
            cbbProductID.Items.AddRange(ProductBLL.Intance.getALLProduct().ToArray());
        }
        private void cbbProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product p = (Product)(cbbProductID.SelectedItem);
            tbProductName.Text = p.ProductName;
            tbSalePrice.Text = p.SalePrice.ToString();
        }

        private void btExitInvoice_Click(object sender, EventArgs e)
        {
            // mở khóa các chức năng(button)
            btPrintInvoice.Enabled = true;
            btUpdateInvoice.Enabled = true;
            btAddInvoice.Enabled = true;
            btChecking.Enabled = true;

            //
        }
        private void setNullThongTinMatHang()
        {
            cbbProductID.Text = "";
            tbProductName.Text = "";
            tbQuantityProduct.Text = "";
            tbSale.Text = "";
            tbSalePrice.Text = "";
        }

        private void setNullThongTinChung()
        {
            tbInvoiceID.Text = "";
            tbInvoiceDate.Text = "";
            tbCustomerName.Text = "";
            tbEmployeeID.Text = "";
            tbEmployeeName.Text = "";
            tbAddressCustomer.Text = "";
            cbbCustomerID.Text = "";
            tbPhoneNumber.Text = "";
        }
        private readonly List<
            Object> _list = new List<Object>();
        private void btSaveInvoice_Click(object sender, EventArgs e)
        {
            // tạo khách hàng mới hoặc sử dụng lại khách hàng cũ
            if (cbbCustomerID.Text == "")
            {
                if (tbAddressCustomer.Text == "" || tbCustomerName.Text == "" || tbPhoneNumber.Text == "")
                {
                    MessageBox.Show("hãy nhập đầy đủ thông tin");
                }
                else
                {
                    Customer kh = new Customer()
                   {

                        Address = tbAddressCustomer.Text,
                        FullName = tbCustomerName.Text,
                        PhoneNumber = tbPhoneNumber.Text
                    };
                    //add customer
                    //CustomerBLL bll = new CustomerBLL();
                    CustomerBLL.Intance.addAndUpdateCustomer(kh);
                    // gán customerId Cho cbb CustomerID
                    cbbCustomerID.Text = kh.CustomerID.ToString();
                }
            }
            // tạo hóa đơn mới 
            if (tbInvoiceID.Text == "")
            {
                Invoice HD = new Invoice()
                {
                    EmployeeID = Convert.ToInt32(tbEmployeeID.Text),
                    CustomerID = Convert.ToInt32(cbbCustomerID.Text),
                    InvoiceDate = DateTime.Now,
                    TotalAmount = 0
                };

                
                InvoiceBLL.Intance.addOrUpdateInvoice(HD);
                tbInvoiceID.Text = HD.InvoiceID.ToString();
            }


            // tạo chi tiết hóa đơn mới 
            if (cbbProductID.Text==null||tbQuantityProduct.Text==""||tbSale.Text=="")
            {
                MessageBox.Show("hãy nhập đầy đủ thông tin");
            }
            else
            {
                InvoiceDetail CTHD = new InvoiceDetail()
                {
                    ProductID = Convert.ToInt32(cbbProductID.Text),
                    InvoiceID = Convert.ToInt32(tbInvoiceID.Text),
                    Quantity = Convert.ToInt16(tbQuantityProduct.Text),
                    SalePrice = Convert.ToInt32(tbSale.Text)
                };
             
                textBox11.Text = price.ToString();
                InvoiceDetailBLL.Intance.addOrUpdateInvoiceDetail(CTHD);
                loangDTGVInvoiceDetail(CTHD.InvoiceID-1);
            }
            // các textbox thông tin mặt hàng rỗng
            setNullThongTinMatHang();
            
           

            //mở khóa chức năng
            btPrintInvoice.Enabled = true;
            btUpdateInvoice.Enabled = true;
            btAddInvoice.Enabled = true;
            btChecking.Enabled = true;
        }
        public static double price = 0;
        private void loangDTGVInvoiceDetail(int invoiceID)
        {
            dtgvInvoiceDetail.Rows.Clear();
            foreach (var item in InvoiceDetailBLL.Intance.getListInvoiceDetailByInvoiceID(invoiceID))
            {
                dtgvInvoiceDetail.Rows.Add(item.Product.ProductName, item.Product.SalePrice, item.Quantity, item.SalePrice);
            }
        }
        private void btUpdateInvoice_Click(object sender, EventArgs e)
        {
            // khóa chức năng
            btAddInvoice.Enabled = false;
            btPrintInvoice.Enabled = false;
            btChecking.Enabled = false;
        }

        
    }
}
