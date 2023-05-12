using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void addOrUpdateInvoice(Invoice hd) => InvoiceDAL.Intance.addOrUpdateInvoice(hd);

        // trả về doanh thu của ngày
        public int revenueByDate(DateTime date)
        {
            int x = 0;
            foreach (var item in InvoiceDAL.Intance.getInvoiceByDate(date))
            {
                x += item.TotalAmount;    
            }
            return x;
        }
       
    }
}
