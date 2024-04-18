using faksys2.Lidi;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faksys2.Data
{
    public class Context2 : DbContext
    {
        public DbSet<Odberatell> Odberatells { get; set; }


        public Context2()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = MyDBb.db");
        }
    }
}
