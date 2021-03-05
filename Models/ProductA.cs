using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurentProjectCore21.Models
{
    public class ProductA
    {
        [Key]
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Name Is Required")]
        public string Name { get; set; }
        public DateTime IssueDate { get; set; }
        [Required(ErrorMessage = "Price Is Required")]
        public decimal Price { get; set; }
        public string ImageName { get; set; }
        public string ImageUrl { get; set; }
        
        [NotMapped]
        public IFormFile UploadImage { get; set; }
        
    }
}
