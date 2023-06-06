using BLL;
using DAL;
//using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            setCBBInvoiceId();
            dtgvInvoiceDetail.Columns.Add("column1", "tên sản phẩm");
            dtgvInvoiceDetail.Columns.Add("column2", "địa chỉ");
            dtgvInvoiceDetail.Columns.Add("column3", "tên khách hàng");
            dtgvInvoiceDetail.Columns.Add("column4", "số lượng");
            dtgvInvoiceDetail.Columns.Add("column5", "giá bán");
            dtgvInvoiceDetail.Columns.Add("column6", "tổng tiền");
            dtgvInvoiceDetail.Columns.Add("column7", "di  động");
            dtgvInvoiceDetail.Columns.Add("column8", "mã  chi tiết hóa đơn");
        }
        
        private void setCBBCustomerID()
        {
            //CustomerBLL bll = new CustomerBLL();
            cbbCustomerID.Items.AddRange(CustomerBLL.Intance.getALLCustomer().ToArray());
        }
        public double TotalPrice()
        {
            double b = 0;
            foreach (DataGridViewRow item in this.dtgvInvoiceDetail.SelectedRows)
            {
                b += double.Parse(item.Cells[5].Value.ToString());
            }
            return b;
        }
        private void btAddInvoice_Click(object sender, EventArgs e)
        {

            setNullThongTinChung();

            tbInvoiceDate.Text = DateTime.Now.ToString();
            tbEmployeeID.Text = acc.AccountID.ToString();
            tbEmployeeName.Text = acc.FullName;

            //  khóa các textbox
            tbInvoiceDate.Enabled = false;
            tbEmployeeID.Enabled = false;
            tbEmployeeName.Enabled = false;

            // khóa các chức năng 
            btUpdateInvoice.Enabled = false;
            btPrintInvoice.Enabled = false;
            btChecking.Enabled = false;

        }
        private void setCBBInvoiceId()
        {
            

            cbbInvoiceID.Items.AddRange(InvoiceBLL.Intance.getAllInvoice().ToArray());
            cbbInvoiceID.DisplayMember = "InvoiceID";


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
            
            cbbProductID.Items.AddRange(ProductBLL.Intance.GetProductsBLL().ToArray());
        }
        private void cbbProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product p = (Product)(cbbProductID.SelectedItem);
            tbProductName.Text = p.ProductName;
            tbSalePrice.Text = p.SalePrice.ToString();
        }
        private void Export(string file)
        {
         
            /*ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;
            using (ExcelPackage pck = new ExcelPackage())
            {
                pck.Workbook.Worksheets.Add("InvoideDetail").Cells[1, 1].LoadFromCollection(InvoiceDetailBLL.Intance.getAllInvoiceDetail(), true);
                pck.SaveAs(new FileInfo(file));
            }*/
        }
        private void btExitInvoice_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dtgvInvoiceDetail.SelectedRows)
            {
                if (item.Selected)
                {

                    dtgvInvoiceDetail.Rows.RemoveAt(item.Index);
                    InvoiceDetailBLL.Intance.delteInvoiceDetail(int.Parse(item.Cells[7].Value.ToString()));
                    tbAddressCustomer.Text = "";
                    tbCustomerName.Text = "";
                    tbSale.Text = "";
                    tbQuantityProduct.Text = "";

                }
            }

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
                    // CustomerBLL bll = new CustomerBLL();
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

               // InvoiceBLL bLL = new InvoiceBLL();
                InvoiceBLL.Intance.addInvoice(HD);
                tbInvoiceID.Text = HD.InvoiceID.ToString();
            }


            // tạo chi tiết hóa đơn mới 
            if (cbbProductID.Text == null || tbQuantityProduct.Text == "" || tbSale.Text == "")
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
                    SalePrice = Convert.ToInt32(tbSale.Text),

                };


                MessageBox.Show("ok");
                // InvoiceDetailBLL bLL1 = new InvoiceDetailBLL();
                InvoiceDetailBLL.Intance.AddInvoiceDetail(CTHD);
                double tinhtien = priceBeforDiscount(int.Parse(tbSalePrice.Text), int.Parse(tbQuantityProduct.Text), int.Parse(tbSale.Text));
                price += tinhtien;
                MessageBox.Show(tinhtien.ToString());

                this.dtgvInvoiceDetail.Rows.Add(tbProductName.Text, tbAddressCustomer.Text, tbCustomerName.Text, tbQuantityProduct.Text, tbSale.Text, tinhtien.ToString(), tbPhoneNumber.Text, CTHD.InvoiceID.ToString());
                tbTotalAmount.Text = price.ToString();
                textBox11.Text = tinhtien.ToString();

            };



            // các textbox thông tin mặt hàng rỗng
            setNullThongTinMatHang();



            //mở khóa chức năng
            btPrintInvoice.Enabled = true;
            btUpdateInvoice.Enabled = true;
            btAddInvoice.Enabled = true;
            btChecking.Enabled = true;
        }
        // tinh tien 
        public double priceBeforDiscount(int priceProduct, int quantity, int discount)
        {

            return priceProduct * quantity * discount * 0.01;
        }

        public static double price = 0;
        private void loangDTGVInvoiceDetail(int invoiceID)
        {
            dtgvInvoiceDetail.DataSource = InvoiceDetailBLL.Intance.getListInvoiceDetailByInvoiceID(invoiceID);
            //dtgvInvoiceDetail.Rows.Clear();

            /*    foreach (InvoiceDetail item in InvoiceDetailBLL.Intance.getListInvoiceDetailByInvoiceID(invoiceID))
                {
                    dtgvInvoiceDetail.Rows.Add( item.Product.ProductName, item.Quantity, item.SalePrice);
                }*/
        }

        System.Data.DataTable table = new System.Data.DataTable();
        int indexRow;
        private void btUpdateInvoice_Click(object sender, EventArgs e)
        {
            DataGridViewRow newRowData = dtgvInvoiceDetail.Rows[indexRow];
            newRowData.Cells[0].Value = tbProductName.Text;
            newRowData.Cells[1].Value = tbAddressCustomer.Text;
            newRowData.Cells[2].Value = tbCustomerName.Text;
            newRowData.Cells[3].Value = tbQuantityProduct.Text;
            newRowData.Cells[4].Value = tbSale.Text;
            newRowData.Cells[5].Value = tbTotalAmount.Text;
            newRowData.Cells[6].Value = tbPhoneNumber.Text;
            tbInvoiceDate.Text = DateTime.Now.ToString();
            tbEmployeeID.Text = acc.AccountID.ToString();
            tbEmployeeName.Text = acc.FullName;

            foreach (DataGridViewRow item in this.dtgvInvoiceDetail.SelectedRows)
            {
                if (item.Selected)
                {

                    dtgvInvoiceDetail.Rows.RemoveAt(item.Index);
                }
            }

        
            Customer c = CustomerBLL.Intance.getCustomerByPhone(tbPhoneNumber.Text);
            cbbCustomerID.Text = c.CustomerID.ToString();
            tbPhoneNumber.Text = c.PhoneNumber.ToString();
            tbCustomerName.Text = c.FullName.ToString();
            tbAddressCustomer.Text = c.Address.ToString();


            Product p = ProductBLL.Intance.getProdcutByName(tbProductName.Text);
            cbbProductID.Text = p.ProductID.ToString();
            tbSalePrice.Text = p.SalePrice.ToString();
        }

        private void cbbInvoiceID_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgvInvoiceDetail.Rows.Clear();
            // addColumnToDtg();
            Invoice p = (Invoice)(cbbInvoiceID.SelectedItem);
            
            var kq = InvoiceDetailBLL.Intance.getListInvoiceDetailByInvoiceID(p.InvoiceID);
            foreach (var item in kq)
            {
                // addColumnToDtg();
                double tien = priceBeforDiscount(int.Parse(item.SalePrice.ToString()), int.Parse(item.SalePrice.ToString()), item.Product.CostPrice);
                this.dtgvInvoiceDetail.Rows.Add(item.Product.ProductName, item.Invoice.Customer.Address, item.Invoice.Customer.FullName.ToString(), item.Quantity.ToString(), item.Product.CostPrice.ToString(), tien.ToString(), item.Invoice.Customer.PhoneNumber);
                textBox11.Text = tien.ToString();
            }
        }

        private void btPrintInvoice_Click(object sender, EventArgs e)
        {
            Export(@"D:\\pbl_3\\PBL3_appstore\\xuatfile.xlsx");
        }

        private void dtgvInvoiceDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dtgvInvoiceDetail.Rows[indexRow];
            tbProductName.Text = row.Cells[0].Value.ToString();
            tbAddressCustomer.Text = row.Cells[1].Value.ToString();
            tbCustomerName.Text = row.Cells[2].Value.ToString();
            tbQuantityProduct.Text = row.Cells[3].Value.ToString();
            tbSale.Text = row.Cells[4].Value.ToString();
            tbPhoneNumber.Text = row.Cells[6].Value.ToString();
        }
    }
}
