using _3SDevTest.Models;

namespace _3SDevTest.Utilities
{
    public class UserFullName
    {
        public static string GetFullNameByUser(User user)
        {
            //if(user.MiddleName != null)
            //{
            //    return user.FirstName + " " + user.MiddleName + " " + user.LastName;
            //}
            return user.FirstName + " " + user.LastName;
        }
    }
}

