using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurentProjectCore21.ViewModels
{
    public class ProductListViewModel
    {
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Name Is Required")]
        public string Name { get; set; }
        public DateTime IssueDate { get; set; }
        [Required(ErrorMessage = "Team Is Required")]
        public decimal Price { get; set; }
        public string ImageName { get; set; }
        public string ImageUrl { get; set; }
        
       
        
    }
}
