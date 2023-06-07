using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class InvoiceDetailBLL
    {
        private static InvoiceDetailBLL _intance;
        public static InvoiceDetailBLL Intance
        {
            get
            {
                if (_intance == null)
                {
                    _intance = new InvoiceDetailBLL();
                }
                return _intance;
            }
            private set { }
        }
        private InvoiceDetailBLL()
        {
        }

        public bool AddInvoiceDetail(InvoiceDetail ct) => InvoiceDetailDAL.Intance.addInvoiceDetail(ct);

        //
        public List<InvoiceDetail> getListInvoiceDetailByInvoiceID(int id)
        {
            return InvoiceDetailDAL.Intance.getListInvoiceDetailByInvoiceID(id);
        }
        public InvoiceDetail getInvoiceFromProduct(int id)
        {
            return InvoiceDetailDAL.Intance.getInvoiceDetailByProduct(id);
        }

        public List<InvoiceDetail> getAllInvoiceDetail()
        {
            return InvoiceDetailDAL.Intance.GetInvoiceDetails();
        }
        public void delteInvoiceDetail(int id)
        {
            InvoiceDetailDAL.Intance.DeleteInvoiceDetail(id);
        }
        public InvoiceDetail getInvoiceByProductIdAndInvoiceId(int productId,int invoiceId)
        {
            return InvoiceDetailDAL.Intance.getInvoiceByProductIdAndInvoiceId(productId, invoiceId);
        }
    }
}
