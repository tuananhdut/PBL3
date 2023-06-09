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
        public List<Invoice> getInvoiceByCusidAndAccountId(int id, int id1, int id2)
        {
            return InvoiceDAL.Intance.getInvoiceByCusidAndAccountId(id, id1,id2);
        }
        public Invoice GetInvoiceByCustomerIdAndEmployeeId(int cusId, int EmId)
        {
            return InvoiceDAL.Intance.GetInvoiceByCustomerIdAndEmployeeId(cusId, EmId);
        }
        public void Save()
        {
            InvoiceDAL.Intance.Saveme();
        }
        public dynamic ExcelExport()
        {
            return InvoiceDAL.Intance.ExcelExport();
        }
    }
}
