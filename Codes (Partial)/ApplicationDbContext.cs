using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thirdEntityFramworkTry
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=YOUSEFPC\SQLEXPRESS; Initial Catalog=thirdEntityFramworkTry12Aug; Integrated Security=True; TrustServerCertificate=True;");
            //@"Data Source=YOUSEFPC\SQLEXPRESS; Initial Catalog=master;Integrated Security=True;"
        }
        public DbSet<Employee> Employees { get; set; }

    }
}
