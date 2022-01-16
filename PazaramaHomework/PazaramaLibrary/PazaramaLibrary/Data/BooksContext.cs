using Microsoft.EntityFrameworkCore;
using PazaramaLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PazaramaLibrary.Data
{
    public class BooksContext : DbContext
    {
        public BooksContext(DbContextOptions<BooksContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Genre> Genres { get; set; }
    }
}
