using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GiaoDien
{
    public partial class FBaoCao : Form
    {
        public FBaoCao()
        {
            InitializeComponent();
            loangChart();
        }

        private void  loangChart()
        {
            cbbTimeStatistics.SelectedIndex = 0;
            cbbTypeStatistics.SelectedIndex = 0;
            object x = new object();
            EventArgs e = new EventArgs();
            btStatistics_Click(x, e);
        }

        private void chart1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                HitTestResult result = chart1.HitTest(e.X, e.Y);
                string str = result.Series.Points[result.PointIndex].YValues[0].ToString();
                MessageBox.Show(str);
            }
            catch (Exception)
            {

            }
        }

        private void btStatistics_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Series.Add(cbbTypeStatistics.Text);
            chart1.Series[0].Points.Clear();
            if (cbbTimeStatistics.SelectedIndex == 0)
            {
                DateTime date = DateTime.Now;
                for (DateTime i = date.AddDays(-6); i <= date; i = i.AddDays(1))
                {
                    string s = i.ToString("dd/MM/yyyy");
                    chart1.Series[0].Points.AddXY(s, InvoiceBLL.Intance.revenueByDate(i));
                }
            }
            else
            if (cbbTimeStatistics.SelectedIndex == 1)
            {
                DateTime date = DateTime.Now;
                for (DateTime i = date.AddDays(-27); i <= date; i = i.AddDays(1))
                {
                    string s = i.ToString("dd/MM/yyyy");
                    chart1.Series[0].Points.AddXY(s, InvoiceBLL.Intance.revenueByDate(i));
                }
            }
            else
            if (cbbTimeStatistics.SelectedIndex == 2)
            {
                DateTime date = DateTime.Now;
                for (DateTime i = date.AddDays(-59); i <= date; i = i.AddDays(1))
                {
                    string s = i.ToString("dd/MM/yyyy");
                    chart1.Series[0].Points.AddXY(s, InvoiceBLL.Intance.revenueByDate(i));
                }
            }
        }
    }
}
