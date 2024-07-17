using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourSpices.Models.ViewModels
{
    public class OrderListViewModel
    {
        public IList<ConfirmedOrderViewModel> Orders { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
