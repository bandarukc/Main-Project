using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web;
using System.IO;


namespace BootstrapSite1.Domain.Entities
{
    public class Product
    {
        [HiddenInput(DisplayValue = false)]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Description is Required")]
        public string Description { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive Price")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Category is Required")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Image is Required")]
        public string Image { get;set; }
        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }
        
    }
}
