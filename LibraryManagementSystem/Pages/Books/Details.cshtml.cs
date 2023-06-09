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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesLibraryContext _context;

        public DetailsModel(RazorPagesLibraryContext context)
        {
            _context = context;
        }

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
    }
}
