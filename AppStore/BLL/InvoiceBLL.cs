using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class InvoiceBLL
    {
        private static InvoiceBLL _intance;
        public static InvoiceBLL Intance
        {
            get
            {
                if (_intance == null)
                {
                    _intance = new InvoiceBLL();
                }
                return _intance;
            }
            private set { }
        }
        private InvoiceBLL()
        {
           
        }

        // add invoice
        public bool addInvoice(Invoice hd) => InvoiceDAL.Intance.addInvoice(hd);
        public Invoice getInvoiceById(int id)
        {
            return InvoiceDAL.Intance.getInvoiceById(id);
        }
        public List<Invoice> getAllInvoice()
        {
            return InvoiceDAL.Intance.getAllInvoices();
        }
        public double revenueByDate(DateTime date)
        {
            double x = 0;
            foreach (var item in InvoiceDAL.Intance.getInvoiceByDate(date))
            {
                x += item.TotalAmount;
            }
            return x;
        }
        // Tìm kiếm hóa đơn
        public List<Invoice> TimkiemHoaDon(string MaHoaDon, string MaKH, string MaNV, string TenKH, string Day, string Month, string Year)
        {
            List<Invoice> result = new List<Invoice>();
            result = InvoiceDAL.Intance.getAllInvoices().ToList();
            if (MaHoaDon != "")
            {
                int MaHD = Convert.ToInt32(MaHoaDon);
                result = result.Where(p => p.InvoiceID == MaHD).ToList();

            }
            if (MaKH != "")
            {
                int Ma = Convert.ToInt32(MaKH);
                result = result.Where(p => p.CustomerID == Ma).ToList();
            }
            if (MaNV != "")
            {
                int ID = Convert.ToInt32(MaNV);
                result = result.Where(p => p.EmployeeID == ID).ToList();
            }
            if (TenKH != "")
            {
                result = result.Where(p => p.Customer.FullName.IndexOf(TenKH, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }
            if (Convert.ToInt32(Day) > 0)
            {
                int day = Convert.ToInt32(Day);
                result = result.Where(p => p.InvoiceDate.Day == day).ToList();
            }
            if (Convert.ToInt32(Month) > 0)
            {
                int month = Convert.ToInt32(Month);
                result = result.Where(p => p.InvoiceDate.Month == month).ToList();
            }
            if (Convert.ToInt32(Year) > 0)
            {
                int year = Convert.ToInt32(Year);
                result = result.Where(p => p.InvoiceDate.Year == year).ToList();
            }
            return result;
        }

    }
}
