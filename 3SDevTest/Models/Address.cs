using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _3SDevTest.Models
{
    public class Address
    {
        public int Id { get; set; }
        [Required]
        [ValidateNever]
        [DisplayName("User")]
        public int UserId { get; set; }
        [ValidateNever]
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        [Required]
        [DisplayName("Governante")]
        public int GovernateId { get; set; }

        [Required]
        [ValidateNever]
        [DisplayName("City")]
        public int CityId { get; set; }
        [ValidateNever]
        [ForeignKey(nameof(CityId))]
        public City City { get; set; }

        [Required]
        public string Street { get; set; }
        [Required]
        [DisplayName("Building Number")]
        public int BuildingNumber { get; set; }
        [Required]
        [DisplayName("Flat Number")]
        public int FlatNumber { get; set; }
    }

    public class Governate {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class City {
        public int Id { get; set; }
        [ValidateNever]
        [DisplayName("Goverante")]
        public int GovernateId { get; set; }
        [ValidateNever]
        [ForeignKey(nameof(GovernateId))]
        public Governate Governate { get; set; }

        public string Name { get; set; }
    }
}
