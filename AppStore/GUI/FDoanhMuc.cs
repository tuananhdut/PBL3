
using AppStore.BLL;
using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class FDoanhMuc : Form
    {
        private Authorization PhanQuyen;
        private Form formshow;
        public FDoanhMuc(Authorization PhanQuyen)
        {
            InitializeComponent();
            this.PhanQuyen = PhanQuyen;
            setFormByAuthorization();
            loangDTGVCustomer();
            loangDTGVAccount();
            ViewDanhMucDT();
            SetCBB_DT();
        }
        private void openPanelBody(Form f1)
        {
            if (formshow != null)
            {
                formshow.Close();
            }
            formshow = f1;
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None;
            f1.Dock = DockStyle.Fill;
            panel1.Controls.Add(f1);
            panel1.Tag = f1;
            f1.BringToFront();
            f1.Show();
        }
        private void setFormByAuthorization()
        {
            switch (PhanQuyen)
            {
                case Authorization.Admin:
                    break;
                case Authorization.User:
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage4);
                    break;
            }
        }
        //
        // Danh muc Dien thoai
        private void setThongTinDT()
        {
            txtProductID_DT.Text = "";
            txtCostPrice_DT.Text = "";
            txtSalePrice_DT.Text = "";
            txtQuantity_DT.Text = "";
            txtDescription_DT.Text = "";
            txtProductName_DT.Text = "";
            txtManufacturer_DT.Text = "";
            txtCatagory_DT.Text = "";
            cbbCategory_DT.Text = "";
            cbbManufacturer_DT.Text = "";
        }
        private void btAdd_DT_Click(object sender, EventArgs e)
        {
            gb_TTDT.Enabled = true;
            btDel_DT.Enabled = false;
            btEdit_DT.Enabled = false;
            btAdd_DT.Enabled = false;
            setThongTinDT();
        }

        private void btExitDT_Click(object sender, EventArgs e)
        {
            setThongTinDT();
            gb_TTDT.Enabled = false;
            btDel_DT.Enabled = true;
            btEdit_DT.Enabled = true;
            btAdd_DT.Enabled = true;
        }
        
        private void btDel_DT_Click_1(object sender, EventArgs e)
        {
            if (dtgvProduct_DT.SelectedRows.Count > 0)
            {
                
                DialogResult re = MessageBox.Show("Bạn có muốn xóa sản phẩm không?", "Xác nhận xóa", MessageBoxButtons.OKCancel);
                if (re == DialogResult.OK)
                {
                    DataGridViewRow r = dtgvProduct_DT.CurrentRow;
                    int del = Convert.ToInt32(r.Cells[0].Value);
                    ProductBLL.Intance.DeleteBLL(del);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng xóa");
            }
            ViewDanhMucDT();
        }
        private void btEdit_DT_Click(object sender, EventArgs e)
        {
            gb_TTDT.Enabled = true;
            txtProductID_DT.Enabled = false;
            btAdd_DT.Enabled = false;
            if (dtgvProduct_DT.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dtgvProduct_DT.CurrentRow;
                int up = Convert.ToInt32(r.Cells[0].Value);
                Product edit = new Product();
                edit = ProductBLL.Intance.GetProductBLL(up);
                txtProductID_DT.Text = Convert.ToString(edit.ProductID);
                txtProductName_DT.Text = Convert.ToString(edit.ProductName);
                cbbCategory_DT.Text = Convert.ToString(edit.CategoryID);
                cbbManufacturer_DT.Text = Convert.ToString(edit.ManufacturerID);
                txtCostPrice_DT.Text = Convert.ToString(edit.CostPrice);
                txtSalePrice_DT.Text = Convert.ToString(edit.SalePrice);
                txtQuantity_DT.Text = Convert.ToString(edit.Quantity);
                txtDescription_DT.Text = Convert.ToString(edit.Description);
                txtCatagory_DT.Text = Convert.ToString(edit.Category.CategoryName);
                txtManufacturer_DT.Text = Convert.ToString(edit.Manufacturer.ManufacturerName);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng muốn cập nhật");
            }
        }
        private void btSave_DT_Click_1(object sender, EventArgs e)
        {
            if (txtProductName_DT.Text == "" || txtCostPrice_DT.Text == "" || txtSalePrice_DT.Text == "" || txtQuantity_DT.Text == "" || txtDescription_DT.Text == "" || txtCatagory_DT.Text == "" || txtManufacturer_DT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ");
            }
            else
            {
                DialogResult re = MessageBox.Show("Bạn có muốn lưu không?", "Xác nhận lưu", MessageBoxButtons.OKCancel);
                if (re == DialogResult.OK)
                {
                    Product save = new Product()
                    {
                        CategoryID = Convert.ToInt32(cbbCategory_DT.Text),
                        ManufacturerID = Convert.ToInt32(cbbManufacturer_DT.Text),
                        ProductName = Convert.ToString(txtProductName_DT.Text),
                        CostPrice = Convert.ToInt32(txtCostPrice_DT.Text),
                        SalePrice = Convert.ToInt32(txtSalePrice_DT.Text),
                        Quantity = Convert.ToInt32(txtQuantity_DT.Text),
                        Description = Convert.ToString(txtDescription_DT.Text),
                    };
                    if (txtProductID_DT.Text != "")
                    {
                        save.ProductID = Convert.ToInt32(txtProductID_DT.Text);
                    }
                    ProductBLL.Intance.AddOrUpdateBLL(save);
                    gb_TTDT.Enabled = false;
                    btDel_DT.Enabled = true;
                    btEdit_DT.Enabled = true;
                    btAdd_DT.Enabled = true;
                    txtProductName_DT.Enabled = true;
                    setThongTinDT();
                    ViewDanhMucDT();
                }else
                {
                    gb_TTDT.Enabled = false;
                    btDel_DT.Enabled = true;
                    btEdit_DT.Enabled = true;
                    btAdd_DT.Enabled = true;
                    txtProductName_DT.Enabled = true;
                    setThongTinDT();
                    ViewDanhMucDT();
                }
                
            }
          

        }

        private void ViewDanhMucDT()
        {
            dtgvProduct_DT.DataSource = ProductBLL.Intance.IndanhsachBLL();
        }
        private void cbbCategory_DT_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(cbbCategory_DT.Text);
            Category find = CatagoryBLL.Intance.getCategoryBLL(ID);
            txtCatagory_DT.Text = find.CategoryName;
        }
        private void cbbManufacturer_DT_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(cbbManufacturer_DT.Text);
            Manufacturer find = ManufactureBLL.Intance.getManufactureBLL(ID);
            txtManufacturer_DT.Text = find.ManufacturerName;
        }
        // Set Combox Danh muc Dien thoai hang va the loai
        private void SetCBB_DT()
        {
            CatagoryBLL cb1 = new CatagoryBLL();
            cbbCategory_DT.Items.AddRange(cb1.getAllCBBCatagory().ToArray());
            ManufactureBLL cb2 = new ManufactureBLL();
            cbbManufacturer_DT.Items.AddRange(cb2.getAllCBBManuFacture().ToArray());
        }
        //
        // Danh Muc Hang
        private void button1_Click_1(object sender, EventArgs e)
        {
            Hang f1 = new Hang();
            openPanelBody(f1);
        }
        //Danh muc The Loai
        private void button2_Click(object sender, EventArgs e)
        {
            FTheLoai f1 = new FTheLoai();
            openPanelBody(f1);
        }
        //
        // khách hàng
        //
        private void loangDTGVCustomer()
        {
            dtgv_KH.Rows.Clear();
            foreach (var customer in CustomerBLL.Intance.getALLCustomer())
            {
                dtgv_KH.Rows.Add(customer.CustomerID, customer.FullName, customer.PhoneNumber, customer.Address);
            }
        }
        private void showCustomerInformation()
        {
            tbSDT_KH.Enabled = true;
            tbCustomerName_KH.Enabled = true;
            tbAddress_KH.Enabled = true;
        }
        private void hideCustomerInformation()
        {
            tbSDT_KH.Enabled = false;
            tbCustomerName_KH.Enabled = false;
            tbAddress_KH.Enabled = false;
        }
        private void btAddKH_Click(object sender, EventArgs e)
        {
            // mở button lưu 
            btSave_Kh.Enabled = true;

            // mở các tb để nhập
            showCustomerInformation();

            // xóa các dữ liệu cũ 
            tbCustomerID_KH.Text = "";
            tbAddress_KH.Text = "";
            tbAddress_KH.Text = "";
            tbCustomerName_KH.Text = "";
            tbSDT_KH.Text = "";


            // khóa các hành động khác
            btEdit_Kh.Enabled = false;
            btDelete_KH.Enabled = false;
        }
        private void btSave_Kh_Click(object sender, EventArgs e)
        {
            if (tbSDT_KH.Text ==""||tbAddress_KH.Text==""||tbCustomerName_KH.Text == "")
            {
                MessageBox.Show("vui lòng nhập đầy đủ thông tin");
            } else
            {
                Customer kh = new Customer()
                {
                    FullName = tbCustomerName_KH.Text,
                    Address = tbAddress_KH.Text,
                    PhoneNumber = tbSDT_KH.Text
                };
                if (tbCustomerID_KH.Text != "") kh.CustomerID = Convert.ToInt32(tbCustomerID_KH.Text);
                CustomerBLL.Intance.addAndUpdateCustomer(kh);
                MessageBox.Show("thêm hoặc sửa thành công","Thông Báo");
                tbCustomerID_KH.Text = kh.CustomerID.ToString();

                //mở các hành động khác
                btEdit_Kh.Enabled = true;
                btDelete_KH.Enabled = true;
                btAddKH.Enabled = true;

                //cập nhật lại danh sách
                loangDTGVCustomer();

                // khóa hành động lưu 
                btSave_Kh.Enabled = false;

                //khóa các tb để nhập
                hideCustomerInformation();
            }
        }
        private void btEdit_Kh_Click(object sender, EventArgs e)
        {
            if (dtgv_KH.SelectedRows.Count == 1)
            {
                // mở button save 
                btSave_Kh.Enabled = true;

                // xử lý
                int id = Convert.ToInt32(dtgv_KH.SelectedRows[0].Cells[0].Value);
                Customer customer = CustomerBLL.Intance.getCustomerByID(id);
                tbCustomerName_KH.Text = customer.FullName;
                tbCustomerID_KH.Text = customer.CustomerID.ToString();
                tbAddress_KH.Text = customer.Address;
                tbSDT_KH.Text = customer.PhoneNumber;
            }
            else
            {
                MessageBox.Show("vui lòng chọn 1 ô trên bảng");
            }

            // mở khóa các text box
            showCustomerInformation();

            // khóa các sự kiện khác 
            btAddKH.Enabled = false;
            btDelete_KH.Enabled = false;
        }
        private void btExitKH_Click(object sender, EventArgs e)
        {
            btAddKH.Enabled = true;
            btDelete_KH.Enabled = true;
            btEdit_Kh.Enabled = true;

            // các text boxt trống
            tbCustomerID_KH.Text = "";
            tbAddress_KH.Text = "";
            tbAddress_KH.Text = "";
            tbCustomerName_KH.Text = "";
            tbSDT_KH.Text = "";
        }
        private void btDelete_KH_Click(object sender, EventArgs e)
        {
            if (dtgv_KH.SelectedRows.Count == 1)
            {
                CustomerBLL.Intance.removeCustomer(Convert.ToInt32(dtgv_KH.SelectedRows[0].Cells[0].Value));
                loangDTGVCustomer();
            }
            else
            {
                MessageBox.Show("vui lòng chọn 1 ô trên bảng");
            }
        }
        //
        // nhân viên
        //
        private void loangDTGVAccount()
        {
            dtgv_NV.Rows.Clear();
            foreach (var row in AccountBLL.Intance.getALLAcount())
            {
                dtgv_NV.Rows.Add(row.AccountID, row.FullName, (Authorization)row.Position, row.PhoneNumber, row.Address);
            }
        }
        private void setNullEmployeeInformation()
        {
            tbUsenameNV.Text = "";
            tbEmployeeID_NV.Text = "";
            tbFullname_NV.Text = "";
            tbAddress_NV.Text = "";
            tbPhoneNumber_NV.Text = "";
        }
        private void UnlockingEmployeeInformation()
        {
            tbUsenameNV.Enabled = true;
            tbPhoneNumber_NV.Enabled = true;
            tbFullname_NV.Enabled = true;
            tbAddress_NV.Enabled = true;
            btResetPasswork.Enabled = true;
            btChangePosition.Enabled = true;
        }
        private void lockingEmployeeInformation()
        {
            tbUsenameNV.Enabled = false;
            tbPhoneNumber_NV.Enabled = false;
            tbFullname_NV.Enabled = false;
            btResetPasswork.Enabled = false;
            tbAddress_NV.Enabled = false;
            btChangePosition.Enabled = false;
        }
        private void btAdd_NV_Click(object sender, EventArgs e)
        {
            // đưa thông tin khách hàng bằng null
            setNullEmployeeInformation();

            // mở khóa các tb thông tin khách hàng
            UnlockingEmployeeInformation();
            btChangePosition.Enabled = false;
            btResetPasswork.Enabled = false;

            //khóa chức năng khác
            btEditNV.Enabled = false;
            btDeleteNV.Enabled = false;
            btShowNV.Enabled = false;

            // mở khóa bt save
            btSaveNV.Enabled = true;
        }
        private void btSaveNV_Click(object sender, EventArgs e)
        {
         
            // xử lý 
            if (tbAddress_NV.Text == "" || tbFullname_NV.Text == "" || tbAddress_NV.Text == "")
            {
                MessageBox.Show("vui lòng nhập đủ thông tin");
            } else
            {
                try
                { 
                    // xử lý 
                    Account account = new Account();
                    account.Address = tbAddress_NV.Text;
                    account.FullName = tbFullname_NV.Text;
                    account.Username = tbUsenameNV.Text;
                    account.PhoneNumber = tbPhoneNumber_NV.Text;
                    if (tbEmployeeID_NV.Text != "")
                    {
                        account.AccountID = Convert.ToInt32(tbEmployeeID_NV.Text);
                    }
                    AccountBLL.Intance.addOrUpdateAccount(account);
                    tbEmployeeID_NV.Text = account.AccountID.ToString();
                    loangDTGVAccount();

                    // khóa các tb thông tin nhân viên 
                    lockingEmployeeInformation();

                    //khóa bt save
                    btSaveNV.Enabled = false;

                    // mở khóa các chức năng khác
                    btEditNV.Enabled = true;
                    btDeleteNV.Enabled = true;
                    btShowNV.Enabled = true;
                    btAdd_NV.Enabled = true;

                }
                catch (ArgumentException ex )
                {
                    if (ex.ParamName.Equals("UsenameExeption"))
                    {
                        MessageBox.Show(ex.Message);
                    }
                    else
                    if (ex.ParamName.Equals("FullnameExeption"))
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void btEditNV_Click(object sender, EventArgs e)
        {
            if (dtgv_NV.SelectedRows.Count == 1)
            {
                // mở khóa các tb thông tin khách hàng
                UnlockingEmployeeInformation();

                //khóa chức năng khác
                btDeleteNV.Enabled = false;
                btShowNV.Enabled = false;
                btAdd_NV.Enabled = false;

                // mở khóa bt save
                btSaveNV.Enabled = true;

                // xử lý   
                int id = Convert.ToInt32(dtgv_NV.SelectedRows[0].Cells[0].Value);
                Account acc = AccountBLL.Intance.GetAccountByID(id);
                tbEmployeeID_NV.Text = acc.AccountID.ToString();
                tbFullname_NV.Text = acc.FullName.ToString();
                tbPhoneNumber_NV.Text =acc.PhoneNumber;
                tbAddress_NV.Text = acc.Address;
                tbUsenameNV.Text = acc.Username;

            }
            else
            {
                MessageBox.Show("vui lòng chọn 1 ô trên bảng");
            }
        }
        private void btExitNV_Click(object sender, EventArgs e)
        {
            //setNullEmployeeInformation
            setNullEmployeeInformation();

            //khóa Information
            lockingEmployeeInformation();

            //khóa bt save
            btSaveNV.Enabled = false;

            // mở khóa các chức năng khác
            btEditNV.Enabled = true;
            btDeleteNV.Enabled = true;
            btShowNV.Enabled = true;
            btAdd_NV.Enabled = true;
        }
        private void btDeleteNV_Click(object sender, EventArgs e)
        {
            if (dtgv_NV.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dtgv_NV.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                AccountBLL.Intance.removeAccountByID(id);
                loangDTGVAccount();
            }
            else
            {
                MessageBox.Show("vui lòng chọn 1 ô trên bảng");
            }
        }
        private void tbSDT_KH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn sự kiện KeyPress
                MessageBox.Show("vui lòng nhập số", "thông báo");
            }
        }
        private void tbPhoneNumber_NV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn sự kiện KeyPress
                MessageBox.Show("vui lòng nhập số", "thông báo");
            }
        }

        private void btResetPasswork_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn reset lại mật khẩu không?", "Xác nhận", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                AccountBLL.Intance.resetPasswork(Convert.ToInt32(tbEmployeeID_NV.Text));
                MessageBox.Show("Reset mật khẩu thành công", "Thông Báo");
            }
        }

        private void btChangePosition_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn chuyển nhân viên này thành quản lý không?", "Xác nhận", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                AccountBLL.Intance.changePosition(Convert.ToInt32(tbEmployeeID_NV.Text));
                MessageBox.Show("Chức vụ của nhân viên này thành quản lý", "Thông Báo");
                loangDTGVAccount();
            }
        }

        private void dtgvProduct_DT_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtgvProduct_DT.Columns[0].HeaderText = "Mã điện thoại";
            dtgvProduct_DT.Columns[1].HeaderText = "Tên điện thoại";
            dtgvProduct_DT.Columns[2].HeaderText = "Giá nhập";
            dtgvProduct_DT.Columns[3].HeaderText = "Giá bán";
            dtgvProduct_DT.Columns[4].HeaderText = "Màu sắc";
            dtgvProduct_DT.Columns[5].HeaderText = "Số Lượng";
            dtgvProduct_DT.Columns[6].HeaderText = "Hãng";
            dtgvProduct_DT.Columns[7].HeaderText = "Thể loại";


        }
    }
}
