﻿using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
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
    }
}
