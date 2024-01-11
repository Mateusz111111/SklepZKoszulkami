using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace SklepZKoszulkami.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public string Club {  get; set; }
        [Required]
        public string Brand { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
        public string Season { get; set; }
        [ValidateNever]
        public string ImageUrl { get; set; }
    }
}
