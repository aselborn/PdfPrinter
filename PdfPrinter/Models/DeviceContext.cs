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
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<DeviceContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Appartment> AppartmentObject { get; set; }

    }
}
