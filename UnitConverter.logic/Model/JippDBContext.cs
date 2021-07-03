using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace UnitConverter.logic.Model
{
    public class JippDBContext: DbContext
    {
        public DbSet<Statistics> Statistics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=JippDB;Integrated Security=True");
        }


    }
}
