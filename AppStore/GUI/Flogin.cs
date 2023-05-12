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
    public partial class Flogin : Form
    {
        public Flogin()
        {
            InitializeComponent();
        }

        // ShowPasswork
        private void cbViewPasswork_CheckedChanged(object sender, EventArgs e)
        {
            if (cbViewPasswork.Checked == true) 
                tbPasswork.UseSystemPasswordChar = false;
            else 
                tbPasswork.UseSystemPasswordChar = true;
        }

        //
        private void btOk_Click(object sender, EventArgs e)
        {
            Account acc = AccountBLL.Intance.CheckAccount(tbUsername.Text, tbPasswork.Text);
            if (acc!=null)
            {
                MessageBox.Show("đăng nhập thành công");
                Fmain f1 = new Fmain(acc);
                this.Hide();
                f1.ShowDialog();
                this.Close();
            }   
            else
            {
                MessageBox.Show("Tai Khoản hoặc mật khẩu sai");
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            tbUsername.Text = AccountBLL.Intance.HashPassword(tbPasswork.Text);
        }
    }
}
