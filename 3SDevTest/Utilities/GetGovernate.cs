using _3SDevTest.Models;
using Microsoft.EntityFrameworkCore;

namespace _3SDevTest.Utilities
{
    public class GetGovernate
    {
        public static Governate? GetGovernateById(int id, DbSet<Governate> governates )
        {
            if (governates != null)
            {
                return governates.FirstOrDefault(u => u.Id == id);
            }
            return null;
        }
    }
}

