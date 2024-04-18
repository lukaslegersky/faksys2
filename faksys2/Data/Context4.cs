using faksys2.Lidi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace faksys2.Data
{
    public class Context4 : DbContext
    {
        public DbSet<Od> Ods { get; set; }


        public Context4()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = MyDBd.db");
        }
    }
}
