﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Toth_Antonia_Patrisia_Lab2.Data;
using Toth_Antonia_Patrisia_Lab2.Models;

namespace Toth_Antonia_Patrisia_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Toth_Antonia_Patrisia_Lab2.Data.Toth_Antonia_Patrisia_Lab2Context _context;

        public IndexModel(Toth_Antonia_Patrisia_Lab2.Data.Toth_Antonia_Patrisia_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;
        public SelectList Authors { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                .Include(b => b.Publisher)
                .Include(b => b.Author)
                .ToListAsync();

            Authors = new SelectList(await _context.Author.ToListAsync(), "ID", "FirstName");
        }
    }
}
