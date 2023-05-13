using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Table("InvoiceDetail")]
    public class InvoiceDetail
    {
        [Key]
        [Required]
        public int InvoiceDetailID { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        [ForeignKey("Invoice")]
        public int InvoiceID { get; set; }
        public int Quantity { get; set; }
        public bool Fag { get; set; } = true;
        public int SalePrice { get; set; }


        public virtual Invoice Invoice { get; set; }
        public virtual Product Product { get; set; }
    }
}
