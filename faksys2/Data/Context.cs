using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using faksys2.Lidi;


namespace faksys2.Data
{
    public class Context : DbContext
    {
        public DbSet<Lid> Lids { get; set; }


        public Context()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = MyDBA.db");
        }
    }
}
