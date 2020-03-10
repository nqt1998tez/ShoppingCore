﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCore.Models.Db
{
    [Table("Category")]
    public class Category
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string AliasName { get; set; }
        public string Brand { get; set; }

    }
}
