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
        public List<Invoice> getInvoiceByDate(DateTime date)
        {
            return db.Invoices
                .Where(p => p.InvoiceDate.Day == date.Day && p.InvoiceDate.Month == date.Month && p.InvoiceDate.Year == date.Year).ToList();
        }
        public List<Invoice> getInvoiceByCusidAndAccountId(int id, int id1,int id2)
        {
            return db.Invoices
                .Where(p => p.CustomerID == id && p.Account.AccountID == id1 && p.InvoiceID == id2 ).ToList();
        }
        public Invoice GetInvoiceByCustomerIdAndEmployeeId(int cusId,int EmId)
        {
            return db.Invoices.Where(i => i.CustomerID == cusId && i.EmployeeID == EmId).FirstOrDefault();
        }
        public void Saveme()
        {
            db.SaveChanges();
        }
        public dynamic ExcelExport()
        {
            var query = (from i in db.Invoices
                         select new
                         {
                             cusId = i.CustomerID,
                             invoiceId = i.InvoiceID,
                             totalAmount = i.TotalAmount,
                             customerName = i.Customer.FullName,
                             account = i.Account
                         }).ToList();
            return query;
        }
    }
}
