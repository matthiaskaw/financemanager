using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace financemanager.Modell
{
    public class BilanceContext : DbContext
    {
        public DbSet<VRTransaction> VRTransactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Bilance;Trusted_Connection=True");
        }

    }
}
