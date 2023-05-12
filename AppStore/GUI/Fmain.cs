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
    public partial class Fmain : Form
    {
        private Form formshow;
        private Account acc;
        public Fmain(Account acc)
        {
            InitializeComponent();
            this.acc = acc;
            setFormByAuthorization();
        }

        private void setFormByAuthorization()
        {
            switch ((Authorization)acc.Position)
            {
                case Authorization.Admin:

                    break;
                case Authorization.User:
                    btBaoCao.Visible = false;
                    break;
            }
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
            panelBody.Controls.Add(f1);
            panelBody.Tag = f1;
            f1.BringToFront();
            f1.Show();
        }

        private void btDoanhMuc(object sender, EventArgs e)
        {
            lbSwich.Text = btDanhMuc.Text;
            FDoanhMuc f1 = new FDoanhMuc((Authorization)this.acc.Position);
            openPanelBody(f1);
        }

        private void btHoaDon_Click(object sender, EventArgs e)
        {
            lbSwich.Text = btHoaDon.Text;
            FHoaDon f1 = new FHoaDon(acc);
            openPanelBody(f1);
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            lbSwich.Text = btTimKiem.Text;
            FTimKiem f1 = new FTimKiem();
            openPanelBody(f1);
        }

        private void btBaoCao_Click(object sender, EventArgs e)
        {
            lbSwich.Text = btBaoCao.Text;
            FBaoCao f1 = new FBaoCao();
            openPanelBody(f1);
        }

        private void btTaiKhoan_Click(object sender, EventArgs e)
        {
            lbSwich.Text = btTaiKhoan.Text;
            FQuanLyTaiKhoan f1 = new FQuanLyTaiKhoan(acc);
            openPanelBody(f1);
        }
    }
}
