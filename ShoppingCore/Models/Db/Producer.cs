using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCore.Models.Db
{
    [Table("Producer")]
    public class Producer
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProducerId { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public string Logo { get; set; }

    }
}
