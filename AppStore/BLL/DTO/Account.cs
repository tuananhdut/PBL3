using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Table("Account")]
    public class Account : Person
    {
        [Key]
        [Required]
        public int AccountID { get; set; }
        public int Position { get; set; } = 1;
        public string Username { get; set; }
        public string Password { get; set; } = "MFiOo6+2RArvarIP0FJHfO/KqDYOeGsKExzEwn4oSLKQHe5N";
        public virtual ICollection<Invoice> Invoices { get; set; }
        public override string ToString()
        {
            return AccountID.ToString();
        }
    }
}
