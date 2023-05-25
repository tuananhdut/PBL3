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
        public bool addInvoice(Invoice hd)
        {
            try
            {
                db.Invoices.AddOrUpdate(hd);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Invoice getInvoiceById(int id)
        {
            Invoice i = db.Invoices.Find(id);
            return i;
        }
        public List<Invoice> getAllInvoices()
        {
            return db.Invoices.ToList();
        }

    }
}
