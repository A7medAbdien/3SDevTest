namespace _3SDevTest.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        public string MobileNumber { get; set; }
        public string Email{ get; set; }
        public Address AddressList { get; set; }
    }
}
