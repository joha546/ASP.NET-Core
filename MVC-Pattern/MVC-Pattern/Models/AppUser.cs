using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;
using Microsoft.AspNetCore.Identity;

namespace MVC_Pattern.Models
{
    public class AppUser : IdentityUser
    {
        public int Pace { get; set; }
        public int Mileage { get; set; }
        public Address? Address { get; set; }
    }
}
