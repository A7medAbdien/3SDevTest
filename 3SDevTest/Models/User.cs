using System.ComponentModel.DataAnnotations.Schema;

namespace _3SDevTest.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string MobileNumber { get; set; }
        public string Email{ get; set; }
        //public int AddressListId { get; set; }
        //[ForeignKey(nameof(AddressListId))]
        //public Address AddressList { get; set; }
    }
}
