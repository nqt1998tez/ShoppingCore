using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCore.Models.Db
{
    [Table("Supplier")]
    public class Supplier
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

    }

}
