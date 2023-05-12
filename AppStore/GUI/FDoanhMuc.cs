
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
        // điện thoại
        //
        private void KhoaThongTinDT()
        {
            cbbCategory_DT.Enabled = false;
            tbCatagory_DT.Enabled = false;
            cbbManufacturer_DT.Enabled = false;
            tbManufacturer_DT.Enabled = false;
            tbCostPrice_DT.Enabled = false;
            tbQuantity_DT.Enabled = false;
            tbSalePrice_DT.Enabled = false;
            tbDescription_DT.Enabled = false;
            tbProductName_DT.Enabled = false;
        }
        private void MoThongTinDT()
        {
            cbbCategory_DT.Enabled = true;
            cbbManufacturer_DT.Enabled = true;
            tbCostPrice_DT.Enabled = true;
            tbQuantity_DT.Enabled = true;
            tbSalePrice_DT.Enabled = true;
            tbDescription_DT.Enabled = true;
            tbProductName_DT.Enabled = true;
        }
        private void btEdit_DT_Click(object sender, EventArgs e)
        {
            MoThongTinDT();
        }
        private void setThongTinDT()
        {
            tbProductID_DT.Text = "";
            cbbCategory_DT.Text = "";
            tbCatagory_DT.Text = "";
            cbbManufacturer_DT.Text = "";
            tbManufacturer_DT.Text = "";
            tbCostPrice_DT.Text = "";
            tbQuantity_DT.Text = "";
            tbSalePrice_DT.Text = "";
            tbDescription_DT.Text = "";
            tbProductName_DT.Text = "";
        }
        private void btAdd_DT_Click(object sender, EventArgs e)
        {
            setThongTinDT();
            MoThongTinDT();
            tbProductID_DT.Enabled = true;
            tbProductName_DT.Enabled = true;
        }
        private void btExitDT_Click(object sender, EventArgs e)
        {
            setThongTinDT();
            MoThongTinDT();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Hang f1 = new Hang();
            openPanelBody(f1);
        }
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
        }
        private void lockingEmployeeInformation()
        {
            tbUsenameNV.Enabled = false;
            tbPhoneNumber_NV.Enabled = false;
            tbFullname_NV.Enabled = false;
            tbAddress_NV.Enabled = false;
        }
        private void btAdd_NV_Click(object sender, EventArgs e)
        {
            // đưa thông tin khách hàng bằng null
            setNullEmployeeInformation();

            // mở khóa các tb thông tin khách hàng
            UnlockingEmployeeInformation();

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
    }
}
