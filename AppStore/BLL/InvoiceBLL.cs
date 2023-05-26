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

    }
}
