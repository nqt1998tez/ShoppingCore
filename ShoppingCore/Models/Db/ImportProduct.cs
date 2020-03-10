using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCore.Models.Db
{
    [Table("ImportProduct")]
    public class ImportProduct
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImportProductId { get; set; }

        public DateTime ImportDate { get; set; }
        public bool Deleted { get; set; }
        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }
    }
}
