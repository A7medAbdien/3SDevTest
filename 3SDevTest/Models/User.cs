using _3SDevTest.Utilities;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _3SDevTest.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        [RegularExpression(@"^[\u0621-\u064Aa-zA-Z ]+$", ErrorMessage = "Use Arabic or English letters only please")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [MaxLength(40)]
        [RegularExpression(@"^[\u0621-\u064Aa-zA-Z ]+$", ErrorMessage = "Use Arabic or English letters only please")]
        [DisplayName("Middle Name")]
        public string MiddleName { get; set; }

        [Required]
        [MaxLength(20)]
        [RegularExpression(@"^[\u0621-\u064Aa-zA-Z ]+$", ErrorMessage = "Use Arabic or English letters only please")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [MinAge(20)]
        [DisplayName("Birth Date")]
        public DateTime BirthDate { get; set; }

        [Required]
        [RegularExpression(@"^\+02[12][0-9]{9}$", ErrorMessage = "Format example +021006158123")]
        [DisplayName("Mobile Number")]
        public string MobileNumber { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email{ get; set; }

        //[ValidateNever]
        //public int? AddressListId { get; set; }

        //[ForeignKey(nameof(AddressListId))]
        //[ValidateNever]
        //public IEnumerable<Address> AddressList { get; set; }
    }
}
