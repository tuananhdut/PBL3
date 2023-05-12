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
        public void addOrUpdateInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            db.InvoiceDetails.AddOrUpdate(invoiceDetail);
            db.SaveChanges();
        }

        // trả về danh sách InvoiceDetail theo invoiceID
        public List<InvoiceDetail> getListInvoiceDetailByInvoiceID(int id)
        {
            return db.InvoiceDetails.Where(p=>p.InvoiceID == id ).ToList();
        }
    }
}
