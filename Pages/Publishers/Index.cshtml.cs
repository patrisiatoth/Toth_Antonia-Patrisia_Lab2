﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Toth_Antonia_Patrisia_Lab2.Data;
using Toth_Antonia_Patrisia_Lab2.Models;

namespace Toth_Antonia_Patrisia_Lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Toth_Antonia_Patrisia_Lab2.Data.Toth_Antonia_Patrisia_Lab2Context _context;

        public IndexModel(Toth_Antonia_Patrisia_Lab2.Data.Toth_Antonia_Patrisia_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
