﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using _3SDevTest.Data;
using _3SDevTest.Models;

namespace _3SDevTest.Pages.Addresses
{
    public class CreateModel : PageModel
    {
        private readonly _3SDevTest.Data.ApplicationDbContext _context;
        private int _userId;
        public CreateModel(_3SDevTest.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int userId)
        {
            ViewData["UserId"] = userId;
            _userId = userId;
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Address Address { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (Address != null)
            {
                Address.UserId = _userId;
            }
            if (!ModelState.IsValid || _context.Addresses == null || Address == null)
            {
                return Page();
            }

            _context.Addresses.Add(Address);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}