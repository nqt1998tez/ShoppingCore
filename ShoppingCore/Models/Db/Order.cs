using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCore.Models.Db
{
    [Table("Order")]
    public class Order
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public bool DeliveryStatus { get; set; }
        public bool Pay { get; set; }
        public int Promotion { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        public int Deleted { get; set; }
        public int Canceled { get; set; }

    }
}
