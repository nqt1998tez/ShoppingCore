using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCore.Models.Db
{
    [Table("ImportDetail")]
    public class ImportDetail
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImportDetailId { get; set; }
        [ForeignKey("ImportProduct")]
        public int ImportProductId { get; set; }
        public decimal ImportCost { get; set; }

        public string Name { get; set; }


    }
}
