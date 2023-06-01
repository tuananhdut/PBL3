using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InvoiceDetailDAL
    {
        AppStore db;
        private static InvoiceDetailDAL _intance;
        public static InvoiceDetailDAL Intance
        {
            get
            {
                if (_intance == null)
                {
                    _intance = new InvoiceDetailDAL();
                }
                return _intance;
            }
            private set { }
        }

        //contructer
        private InvoiceDetailDAL()
        {
            db = new AppStore();
        }

        // add InvoiceDetail
        public bool addInvoiceDetail(InvoiceDetail ct)
        {
            try
            {
                db.InvoiceDetails.AddOrUpdate(ct);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // trả về danh sách InvoiceDetail theo invoiceID
        public List<InvoiceDetail> getListInvoiceDetailByInvoiceID(int id)
        {
            return db.InvoiceDetails.Where(p => p.InvoiceID == id).ToList();
        }
        public InvoiceDetail getInvoiceDetail(int invoiceId)
        {
            InvoiceDetail d = (from id in db.InvoiceDetails where id.InvoiceID == invoiceId select id).FirstOrDefault();
            return d;
        }
        public InvoiceDetail getInvoiceDetailByProduct(int productId)
        {
            InvoiceDetail d = (from id in db.InvoiceDetails where id.ProductID == productId select id).FirstOrDefault();
            return d;
        }
        public Object getInvoiceDetailByProduct1(int productId)
        {
            Object d = (from id in db.InvoiceDetails
                        where id.ProductID == productId
                        select new
                        {
                            products = id.Product,
                            invoice = id.Invoice,
                        }).FirstOrDefault();
            return d;
        }

        public List<InvoiceDetail> GetInvoiceDetails()
        {
            // var kq = from dl in db.InvoiceDetails select dl
            return db.InvoiceDetails.ToList();

        }
        public void DeleteInvoiceDetail(int id)
        {
            var p = db.InvoiceDetails.Find(id);
            db.InvoiceDetails.Remove(p);
            db.SaveChanges();
        }

        public void Save(InvoiceDetail i)
        {
            db.InvoiceDetails.AddOrUpdate(i);
            db.SaveChanges();
        }
    }
}
