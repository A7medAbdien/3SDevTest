using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _3SDevTest.Models
{
    public class Address
    {
        public int Id { get; set; }
        [Required]
        [ValidateNever]
        public int UserId { get; set; }
        [ValidateNever]
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        [Required]
        public string Governate { get; set; }

        [Required]
        [ValidateNever]
        public int CityId { get; set; }
        [ValidateNever]
        [ForeignKey(nameof(CityId))]
        public City City { get; set; }

        [Required]
        public string Street { get; set; }
        [Required]
        public int BuildingNumber { get; set; }
        [Required]
        public int FlatNumber { get; set; }
    }

    public class Governate {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class City {
        public int Id { get; set; }
        [ValidateNever]
        public int GovernateId { get; set; }
        [ValidateNever]
        [ForeignKey(nameof(GovernateId))]
        public Governate Governate { get; set; }

        public string Name { get; set; }
    }
}
