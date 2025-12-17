using Microsoft.EntityFrameworkCore;
using Myoffice_ACPD.Model;

namespace Myoffice_ACPD.Model
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Myoffice_ACPD.Model.MyOffice_ACPD> MyOffice_ACPD { get; set; } = default!;



        //public DbSet<MyOffice_ACPD> MyOffice_ACPDs { get; set; }
        //public DbSet<MyOffice_ExcuteionLog> MyOffice_ExcuteionLogs { get; set; }




    }
}
