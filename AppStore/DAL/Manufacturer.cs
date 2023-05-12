using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Table("Manufacturer")]
    public class Manufacturer
    {
        [Key]
        [Required]
        public int ManufacturerID { get; set; }
        public bool Flag { get; set; } = true;

        public string ManufacturerName { get; set; }
        public string Address { get; set; }
    }
}
