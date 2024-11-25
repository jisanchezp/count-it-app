using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CountIt.DAL.Data
{
    internal class CountItDbContext : DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }

        public CountItDbContext(DbContextOptions<CountItDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
