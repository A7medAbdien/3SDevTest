﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using _3SDevTest.Data;
using _3SDevTest.Models;
using _3SDevTest.Utilities;
using Microsoft.EntityFrameworkCore;

namespace _3SDevTest.Pages.Addresses
{
    public class CreateModel : PageModel
    {
        private readonly _3SDevTest.Data.ApplicationDbContext _context;
        public CreateModel(_3SDevTest.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int userId)
        {
            if (_context.Addresses != null && _context.Users != null)
            {
                AddressesList = _context.Addresses
                .Include(a => a.City)
                .Where(a => a.User.Id == userId)
                .ToList();

                User =  _context.Users
                    .FirstOrDefault(u => u.Id == userId);
            }

            ViewData["UserId"] =  userId;
            ViewData["Governates"] = new SelectList(_context.Governates, "Id", "Name");
            ViewData["Cities"] = _context.Cities.Select(c => new
            {
                c.Id,
                c.Name,
                c.GovernateId
            }).ToList();

            return Page();
        }

        [BindProperty]
        public Address Address { get; set; } = default!;
        public new User? User { get; set; }
        public List<Address> AddressesList { get; set; }


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid || _context.Addresses == null || Address == null)
            {
                return Page();
            }
            _context.Addresses.Add(Address);
            await _context.SaveChangesAsync();

            return RedirectToPage(new { userId = Address.UserId });
        }

        public Governate? GetGovernanceById(int id)
        {
            return GetGovernate.GetGovernateById(id, _context.Governates);
        }
    }
}
