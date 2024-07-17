using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FourSpices.Models
{
    public class MenuItem
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Spicyness { get; set; }

        //We could use list but lets try enum
        //enum is a static list
        public enum ESpicy { NA=0,NotSpicy=1,Miled=2,Hot=3 }

        //Store a string path of the image in DB
        public string Image { get; set; }

        [Display(Name="Category")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")] //The name of foreign key
        public virtual Category Category { get; set; } // What table the foreign key should refer to

        [Display(Name = "SubCategory")] 
        public int SubCategoryId { get; set; }

        [ForeignKey("SubCategoryId")] //The name of foreign key
        public virtual SubCategory SubCategory { get; set; } // What table the foreign key should refer to

        //I want the price to be at least 1 doller
        [Range(1,int.MaxValue, ErrorMessage = " Price should be more than ${1}")]
        public double Price { get; set; }


    }
}
