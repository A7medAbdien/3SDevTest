using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using _3SDevTest.Data;
using _3SDevTest.Models;

namespace _3SDevTest.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly _3SDevTest.Data.ApplicationDbContext _context;

        public IndexModel(_3SDevTest.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Users != null)
            {
                User = await _context.Users.ToListAsync();
            }
        }
    }
}
