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
            dtgvInvoiceDetail.Columns.Add("column1", "tên sản phẩm");
            dtgvInvoiceDetail.Columns.Add("column2", "địa chỉ");
            dtgvInvoiceDetail.Columns.Add("column3", "tên khách hàng");
            dtgvInvoiceDetail.Columns.Add("column4", "số lượng");
            dtgvInvoiceDetail.Columns.Add("column5", "giá bán");
            dtgvInvoiceDetail.Columns.Add("column6", "tổng tiền");
            dtgvInvoiceDetail.Columns.Add("column6", "di  động");
            dtgvInvoiceDetail.Columns.Add("column6", "mã  chi tiết hóa đơn");
            setCBBProuctID();
            setCBBCustomerID();
            setCBBInvoiceId();
        }
        private void setCBBInvoiceId()
        {
            cbbInvoiceID.Items.AddRange(InvoiceBLL.Intance.getAllInvoice().ToArray());
            cbbInvoiceID.DisplayMember = "InvoiceID";


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

            //  khóa các textbox
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
            
            cbbProductID.Items.AddRange(ProductBLL.Intance.GetProductsBLL().ToArray());
        }
        private void cbbProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product p = (Product)(cbbProductID.SelectedItem);
            tbProductName.Text = p.ProductName;
            tbSalePrice.Text = p.SalePrice.ToString();
        }

        private void btExitInvoice_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dtgvInvoiceDetail.SelectedRows)
            {
                if (item.Selected)
                {

                    dtgvInvoiceDetail.Rows.RemoveAt(item.Index);
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
            ExportFile((System.Data.DataTable)dtgvInvoiceDetail.DataSource, "tổng kết", "allproduct");
        }
        public void ExportFile(System.Data.DataTable dataTable, string sheetName, string title)
        {
            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần Tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            //head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Mã nhân viên";

            cl1.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Họ tên";

            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "số điện thoại";
            cl3.ColumnWidth = 12.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "địa chỉ";

            cl4.ColumnWidth = 10.5;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "sản phẩm";

            cl5.ColumnWidth = 20.5;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            cl6.Value2 = "Chức vụ";

            cl6.ColumnWidth = 18.5;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

            cl7.Value2 = "Tình trạng";

            cl7.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "G3");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 6;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng theo datatable

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + dataTable.Rows.Count - 2;

            int columnEnd = dataTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột mã nhân viên

            //Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            //Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            //Căn giữa cả bảng 
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }
    }
}
