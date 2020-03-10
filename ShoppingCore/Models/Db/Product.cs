using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCore.Models.Db
{
    [Table("Product")]
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public int? QuantityExists { get; set; }
        public int? View { get; set; }
        public int? Comment { get; set; }
        public int? Vote { get; set; }
        public bool NewProduct { get; set; }
        [ForeignKey("Supplier")]
        public int? SupplierId { get; set; }
        [ForeignKey("Caterogy")]
        public int? CategoryId { get; set; }
        [ForeignKey("Producer")]
        public int? ProducerId { get; set; }


    }
}
