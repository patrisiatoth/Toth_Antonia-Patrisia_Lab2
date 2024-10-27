﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Toth_Antonia_Patrisia_Lab2.Data;
using Toth_Antonia_Patrisia_Lab2.Models;

namespace Toth_Antonia_Patrisia_Lab2.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Toth_Antonia_Patrisia_Lab2.Data.Toth_Antonia_Patrisia_Lab2Context _context;

        public DetailsModel(Toth_Antonia_Patrisia_Lab2.Data.Toth_Antonia_Patrisia_Lab2Context context)
        {
            _context = context;
        }

        public Book Book { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book.Include(b => b.Author) .Include(b=>b.Publisher) .Include(b=>b.BookCategories) .FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            else
            {
                Book = book;
            }
            return Page();
        }
    }
}
