using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurentProjectCore21.ViewModels
{
    public class CreateProductModel
    {
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Product Name Is Required")]
        [DataType(DataType.Text)]
        [Display(Name = "Product Name")]
        [StringLength(50, ErrorMessage = "Product Name Must be within 50 Charecter")]
        public string Name { get; set; } 
        public DateTime IssueDate { get; set; }
        [Required(ErrorMessage = "Price Is Required")]       
        public decimal Price { get; set; }
        public string ImageName { get; set; }
        public string ImageUrl { get; set; }      
        
        public IFormFile ImageFile { get; set; }
     
    }
}
