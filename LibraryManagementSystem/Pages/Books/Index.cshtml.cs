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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesLibraryContext _context;

        public IndexModel(RazorPagesLibraryContext context)
        {
            _context = context;
        }

        public IList<Library> Library { get;set; }

        public async Task OnGetAsync()
        {
            Library = await _context.Library.ToListAsync();
        }
    }
}
