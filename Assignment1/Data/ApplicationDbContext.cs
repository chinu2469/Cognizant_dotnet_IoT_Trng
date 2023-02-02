using Assignment1.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<CustDashboard>? CustDashboards { get; set; }
        //public DbSet<PM> PMs { get; set; }

        public virtual DbSet<PmModel> Pms { get; set; }

       
    }
}
//    Scaffold-DbContext "" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -t dbo.PMs -f

