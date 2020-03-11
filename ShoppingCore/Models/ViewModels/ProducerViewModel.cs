using ShoppingCore.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCore.Models.ViewModels
{
    public class ProducerViewModel
    {
        public int ProducerId { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public string Logo { get; set; }

        public ProducerViewModel(Producer Producer)
        {
            this.Name = Producer.Name;
            this.Info = Producer.Info;
            this.Logo = Producer.Logo;
        }
        public ProducerViewModel()
        {

        }


    }

}
