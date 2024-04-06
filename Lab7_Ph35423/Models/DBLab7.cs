using Microsoft.EntityFrameworkCore;

namespace Bai1.Models
{
    public class DBLab7 : DbContext
    {
       
        public DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-ATAN102\TRONGTAN;Initial Catalog=Lab7_C#4;Integrated Security=True;TrustServerCertificate=true");
            //optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=DuAn1_C#;Integrated Security=True ; TrustServerCertificate=true");
        }

    }
}
