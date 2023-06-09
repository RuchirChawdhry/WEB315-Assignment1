using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesLibrary.Models;

namespace LibraryManagementSystem.Pages_Books
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesLibraryContext _context;

        public CreateModel(RazorPagesLibraryContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Library Library { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Library.Add(Library);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
