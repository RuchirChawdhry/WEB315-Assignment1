using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesLibrary.Models;

namespace LibraryManagementSystem.Pages_Books
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesLibraryContext _context;

        public DeleteModel(RazorPagesLibraryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Library Library { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Library = await _context.Library.FirstOrDefaultAsync(m => m.ID == id);

            if (Library == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Library = await _context.Library.FindAsync(id);

            if (Library != null)
            {
                _context.Library.Remove(Library);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
