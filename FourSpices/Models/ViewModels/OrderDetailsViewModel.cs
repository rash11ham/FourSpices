using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourSpices.Models.ViewModels
{
    public class OrderDetailsViewModel
    {
        public List<ShoppingCart> ListCart { get; set; }
        public OrderHeader OrderHeader { get; set; }
    }
}
