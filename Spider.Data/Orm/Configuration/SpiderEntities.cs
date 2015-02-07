using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Spider.Data.Orm.Configuration
{
    public class SpiderEntities : DbContext
    {
        public SpiderEntities()
        {
            Database.Connection.ConnectionString = "server=ERH8;database=SpiderDb;trusted_connection=true";
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> User { get; set; }

        public DbSet<Thumbnail> Thumbnail { get; set; }

        public DbSet<Video> Video { get; set; }

    }
}
