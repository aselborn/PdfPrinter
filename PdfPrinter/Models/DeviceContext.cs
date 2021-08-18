using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.CodeFirst;

namespace PdfPrinter.Models
{
    public class DeviceContext : DbContext
    {
        public DeviceContext()
        {
            Database.SetInitializer<DeviceContext>(null);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<DeviceContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Appartment> AppartmentObject { get; set; }
        public DbSet<Renter> RenterObject { get; set; }

        public DbSet<Fastighet> FastighetObject { get; set; }
    }
}
