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
    public partial class FdoiMK : Form
    {
        private Account acc;
        public FdoiMK(Account acc)
        {
            this.acc = acc;
            InitializeComponent();
        }

        private void btChangPasswork_Click(object sender, EventArgs e)
        {
            if (!AccountBLL.Intance.VerifyPassword(tbOldPasswork.Text, acc.Password))
            {
                MessageBox.Show("vui lòng kiểm tra mật khẩu cũ", "thông báo");
            } else if (tbNewPasswork.Text != tbAgainNewPasswork.Text)
            {
                MessageBox.Show("vui lòng kiểm tra mật khẩu mới", "thông báo");
            }
            else
            {
                AccountBLL.Intance.changPassWork(acc.AccountID, tbNewPasswork.Text);
                MessageBox.Show("đổi mật khẩu thành công", "thông báo");
            }
        }
    }
}
