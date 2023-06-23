using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesLibrary.Models;
using Microsoft.AspNetCore.Mvc.Rendering;


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
        // search
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        //selectList STEP
        public SelectList BookCategory { get; set; } // uses "using Microsoft.AspNetCore.Mvc.Rendering;"
        [BindProperty(SupportsGet = true)]
        public string Category { get; set; }

        public async Task OnGetAsync()
        {
            // SELECT LIST SEARCH
            // DROP DOWN
            // BOOK CATEGORY
            IQueryable<string> genreQuery = from m in _context.Library
                                    orderby m.BookCategory
                                    select m.BookCategory;


            var libraries = from m in _context.Library
                        select m;


            if (!string.IsNullOrEmpty(SearchString))
            {
                libraries = libraries.Where(s => s.BookName.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(Category))
            {
                libraries = libraries.Where(x => x.BookCategory == Category);
            }

            BookCategory = new SelectList(await genreQuery.Distinct().ToListAsync());

            Library = await libraries.ToListAsync();
        }
    }
}
