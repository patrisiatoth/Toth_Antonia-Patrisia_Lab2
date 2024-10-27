using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Toth_Antonia_Patrisia_Lab2.Models;

namespace Toth_Antonia_Patrisia_Lab2.Data
{
    public class Toth_Antonia_Patrisia_Lab2Context : DbContext
    {
        public Toth_Antonia_Patrisia_Lab2Context (DbContextOptions<Toth_Antonia_Patrisia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Toth_Antonia_Patrisia_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Toth_Antonia_Patrisia_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Toth_Antonia_Patrisia_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Toth_Antonia_Patrisia_Lab2.Models.Category> Category { get; set; } = default!;
    }
}
