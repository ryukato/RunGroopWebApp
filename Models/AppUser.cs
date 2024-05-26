
using System.ComponentModel.DataAnnotations;

namespace RunGroopWebApp.Models {
    public class AppUser {
        [Key]
        public string Id {get; set;}
        public string UserName { get; set;}
        public string Email { get; set;}

        public Boolean EmailConfirmed {get; set;}
        public int? Pace { get; set;}
        public int? Mileage { get; set;}
        public Address? Address { get; set;} 

        public ICollection<Club> Clubs { get; set;}

        public ICollection<Race> Races { get; set;}
    } 
}