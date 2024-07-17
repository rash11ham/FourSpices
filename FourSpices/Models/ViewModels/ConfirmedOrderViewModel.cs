using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourSpices.Models.ViewModels
{
    public class ConfirmedOrderViewModel
    {
        public OrderHeader OrderHeader { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
    }
}
