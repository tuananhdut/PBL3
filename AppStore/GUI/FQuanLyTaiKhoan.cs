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
    public partial class FQuanLyTaiKhoan : Form
    {
        private Account acc;
        public FQuanLyTaiKhoan(Account acc)
        {
            this.acc = acc;
            InitializeComponent();
            loangForm();
        }
        private void loangForm()
        {
            tbAccountID.Text = acc.AccountID.ToString();
            tbAccountAddress.Text = acc.Address;
            tbAccountName.Text = acc.FullName;
            tbUsername.Text = acc.Username;
            tbAccountPhone.Text = acc.PhoneNumber;
        }
        private void btEditAccount_Click(object sender, EventArgs e)
        {
            tbAccountAddress.Enabled = true;
            tbAccountName.Enabled = true;
            tbAccountPhone.Enabled = true;
            btSaveAccount.Enabled = true;
            btEditAccount.Enabled = false;
            tbUsername.Enabled = true;
        }

        private void btSaveAccount_Click(object sender, EventArgs e)
        {
            if (tbAccountAddress.Text == "" || tbAccountName.Text == "" || tbUsername.Text=="" || tbAccountPhone.Text=="")
            {
                MessageBox.Show("vui lòng nhập đầy đủ thông tin", "Thông Báo");
            } else
            {
                Account account = new Account()
                {
                    AccountID = Convert.ToInt32(tbAccountID.Text),
                    Address = tbAccountAddress.Text,
                    FullName = tbAccountName.Text,
                    Username = tbUsername.Text,
                    Position = acc.Position,
                    PhoneNumber = tbAccountPhone.Text
                };
                try
                {
                    AccountBLL.Intance.addOrUpdateAccount(account);
                    MessageBox.Show("Đổi Thông Tin Thành công", "Thông Báo");
                    btSaveAccount.Enabled = false;
                    btEditAccount.Enabled = true;
                    tbAccountAddress.Enabled = false;
                    tbAccountName.Enabled = false;
                    tbAccountPhone.Enabled = false;
                    tbUsername.Enabled = false;
                }
                catch (ArgumentException ex)
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

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btChangPasswork_Click(object sender, EventArgs e)
        {
            FdoiMK f = new FdoiMK(acc);
            f.ShowDialog();
        }
    }
}
