using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCore.Models.ViewModels
{
    public class MenuViewModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public List<ProducerViewModel> Producers { get; set; }
        public MenuViewModel()
        {
            this.Producers = new List<ProducerViewModel>();
        }
    }
}
