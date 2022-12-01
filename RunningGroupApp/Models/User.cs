using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RunningGroupApp.Models
{
    public class User 
    {
        [Key]
        public string? Id { get; set; }
        public int? Pace { get; set; }
        public int? Mileage { get; set; }
        //pus ulterior AdressId,nush daca trebuie(luat de pe Git)
        [ForeignKey("Address")]
        public int? AddressId { get; set; }
        public Address? Address{ get; set; }
        public ICollection<Club> Clubs { get; set; }
        public ICollection<Race> Races { get; set; }

    }
}
