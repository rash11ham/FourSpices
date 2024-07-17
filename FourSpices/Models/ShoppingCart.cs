using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FourSpices.Models
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            Count = 1;
        }

        public int Id { get; set; }
        public string ApplicationUserId { get; set; }

        [NotMapped]//should be used when you don't want to be added to db
        [ForeignKey("ApplicationUserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        public int MenuItemId { get; set; }

        [NotMapped]//should be used when you don't want to be added to db
        [ForeignKey("MenuItemId")]
        public virtual MenuItem MenuItem { get; set; }
        [Range(1,int.MaxValue, ErrorMessage ="You don't have any item in the cart, please add one")]
        //Count is 0 we intialize it to one in the constructor
        public int Count { get; set; }
    }
}
