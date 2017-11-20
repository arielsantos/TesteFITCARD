using Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{   

    public class TesteFitcardContext : DbContext
    {
        public TesteFitcardContext()
            : base("TesteFitcardDB")
        {

            //Database.SetInitializer(
            //    //new DropCreateDatabaseAlways<GELComprasContext>()
            //    new MigrateDatabaseToLatestVersion<TesteFitcardContext, GELComprasDAL.Migrations.Configuration>("GELComprasDB")
            //    );
        }

        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<Estabelecimento> Estabelecimento { get; set; }

     
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
