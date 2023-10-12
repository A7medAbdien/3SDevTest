using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using _3SDevTest.Data;
using _3SDevTest.Models;

namespace _3SDevTest.Pages.Users
{
    public class CreateModel : PageModel
    {
        private readonly _3SDevTest.Data.ApplicationDbContext _context;

        public CreateModel(_3SDevTest.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public User User { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Users == null || User == null)
            {
                return Page();
            }

            _context.Users.Add(User);
            _context.SaveChangesAsync();

            return RedirectToPage("/Addresses/Create", new { userId = User.Id });
        }
    }
}
