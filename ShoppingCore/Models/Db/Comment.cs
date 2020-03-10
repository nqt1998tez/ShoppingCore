using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCore.Models.Db
{
    [Table("Comment")]
    public class Comment
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommentId { get; set; }
        public string Text { get; set; }
        [ForeignKey("Member")]
        public int MemberId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }

    }
}
