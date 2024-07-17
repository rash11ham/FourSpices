using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourSpices.Models
{
    public class PagingInfo
    {
        public int TotalItem { get; set; }

        public int ItemsPerPage { get; set; }

        //tracking page the user is in
        public int CurrentPage { get; set; }

        //Total items well decide how many pages can be there
        public int totalPage => (int)Math.Ceiling((decimal)TotalItem / ItemsPerPage);

        //This will track the page numbers that a user is in, and store it as a url
        public string urlParam { get; set; }
    }
}
