using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using _3SDevTest.Data;
using _3SDevTest.Models;

namespace _3SDevTest.Pages.Addresses
{
    public class IndexModel : PageModel
    {
        private readonly _3SDevTest.Data.ApplicationDbContext _context;

        public IndexModel(_3SDevTest.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Address> Address { get;set; } = default!;

        public async Task OnGetAsync()
        {

            if (_context.Addresses != null)
            {
                Address = await _context.Addresses
                .Include(a => a.City)
                .Include(a => a.User).ToListAsync();
            }
        }

        public Governate? GetGovernanceById(int id)
        {
            if (_context.Governates != null)
            {
                return _context.Governates.FirstOrDefault(u => u.Id == id);
            }
            return null;
        }

        public string GetFullNameByUser(User user)
        {
            //if(user.MiddleName != null)
            //{
            //    return user.FirstName + " " + user.MiddleName + " " + user.LastName;
            //}
            return user.FirstName + " " + user.LastName;
        }
    }
}
