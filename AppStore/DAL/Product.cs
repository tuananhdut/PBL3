using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Table("Product")]
    public class Product
    {
        /*public Product()
        {
            this.InvoiceDetails = new HashSet<InvoiceDetail>();
        }*/
        [Key]
        public int ProductID { get; set; }
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        [ForeignKey("Manufacturer")]
        public int ManufacturerID { get; set; }
        public string ProductName { get; set; }
        public int CostPrice { get; set; }
        public bool Flag { get; set; } = true;
        public int SalePrice { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }


        public virtual Category Category { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public override string ToString()
        {
            return ProductID.ToString();
        }
    }
}
