using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InvoiceDAL
    {
        AppStore db;
        private static InvoiceDAL _intance;
        public static InvoiceDAL Intance
        {
            get
            {
                if (_intance == null)
                {
                    _intance = new InvoiceDAL();
                }
                return _intance;
            }
            private set { }
        }

        //contructer
        private InvoiceDAL()
        {
            db = new AppStore();
        }

        // add invoice
        public void addOrUpdateInvoice(Invoice hd)
        {
            db.Invoices.AddOrUpdate(hd);
            db.SaveChanges();
        }

        public List<Invoice> getInvoiceByDate(DateTime date)
        {
            return db.Invoices
                .Where(p => p.InvoiceDate.Day == date.Day && p.InvoiceDate.Month == date.Month && p.InvoiceDate.Year == date.Year).ToList();
        }
     
    }
}
