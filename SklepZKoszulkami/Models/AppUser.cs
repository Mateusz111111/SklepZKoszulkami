using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SklepZKoszulkami.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Ulica { get; set; }
        [Required]
        public string NumerMieszkania { get; set; }
        [Required]
        public string Miasto {  get; set; }
        [Required]
        public string Wojewodztwo { get; set; }
        [Required]
        public string KodPocztowy {  get; set; }
        
    }
}
