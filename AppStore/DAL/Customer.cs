using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Customer : Person
    {
        public Customer()
        {
            this.Invoices = new HashSet<Invoice>();
        }
        [Key]
        public int CustomerID { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }

        public override string ToString()
        {
            return CustomerID.ToString();
        }
    }
}
