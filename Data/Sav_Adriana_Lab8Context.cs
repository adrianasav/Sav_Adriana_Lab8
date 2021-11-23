using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sav_Adriana_Lab8.Models;

namespace Sav_Adriana_Lab8.Data
{
    public class Sav_Adriana_Lab8Context : DbContext
    {
        public Sav_Adriana_Lab8Context (DbContextOptions<Sav_Adriana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Sav_Adriana_Lab8.Models.Book> Book { get; set; }

        public DbSet<Sav_Adriana_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Sav_Adriana_Lab8.Models.Category> Category { get; set; }
    }
}
