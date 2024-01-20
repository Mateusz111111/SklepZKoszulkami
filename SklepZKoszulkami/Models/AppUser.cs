using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SklepZKoszulkami.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        public string? Name { get; set; }
        public string? Ulica { get; set; }
        public string? NumerMieszkania { get; set; }
        public string? Miasto { get; set; }
        public string? Wojewodztwo { get; set; }
        public string? KodPocztowy { get; set; }
    }
}
