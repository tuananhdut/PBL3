using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // add  invoiceDetail
        public void addOrUpdateInvoiceDetail(InvoiceDetail invoiceDetail) => InvoiceDetailDAL.Intance.addOrUpdateInvoiceDetail(invoiceDetail);

        //
        public List<InvoiceDetail> getListInvoiceDetailByInvoiceID(int id)
        {
            return InvoiceDetailDAL.Intance.getListInvoiceDetailByInvoiceID(id);
        }


    }
}
