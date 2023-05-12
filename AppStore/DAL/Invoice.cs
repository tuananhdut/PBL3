using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Table("Invoice")]
    public class Invoice
    {
        public Invoice()
        {
            this.InvoiceDetails = new HashSet<InvoiceDetail>();
        }

        [Key]
        public int InvoiceID { get; set; }
        public bool Flag { get; set; } = true;
        [ForeignKey("Account")]
        public int EmployeeID { get; set; }
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public int TotalAmount { get; set; }
        public virtual Account Account { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
