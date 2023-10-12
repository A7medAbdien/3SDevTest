using System.ComponentModel.DataAnnotations.Schema;

namespace _3SDevTest.Models
{
    public class Address
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        public string Governate { get; set; }

        public int CityId { get; set; }
        [ForeignKey(nameof(CityId))]
        public City City { get; set; }

        public string Street { get; set; }
        public int BuildingNumber { get; set; }
        public int FlatNumber { get; set; }
    }

    public class Governate {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class City {
        public int Id { get; set; }

        public int GovernateId { get; set; }
        [ForeignKey(nameof(GovernateId))]
        public Governate Governate { get; set; }

        public string Name { get; set; }
    }
}
