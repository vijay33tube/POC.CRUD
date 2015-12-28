using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using GEP.Core.Models.Mapping;

namespace GEP.Core.Models
{
    public partial class pubsContext : BaseDbContext
    {
        static pubsContext()
        {
            Database.SetInitializer<pubsContext>(null);
        }

        public pubsContext()
            : base("Name=pubsContext")
        {
        }

        public DbSet<author> authors { get; set; }
        public DbSet<discount> discounts { get; set; }
        public DbSet<employee> employees { get; set; }
        public DbSet<job> jobs { get; set; }
        public DbSet<pub_info> pub_info { get; set; }
        public DbSet<publisher> publishers { get; set; }
        public DbSet<roysched> royscheds { get; set; }
        public DbSet<sale> sales { get; set; }
        public DbSet<store> stores { get; set; }
        public DbSet<titleauthor> titleauthors { get; set; }
        public DbSet<title> titles { get; set; }
        public DbSet<titleview> titleviews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new authorMap());
            modelBuilder.Configurations.Add(new discountMap());
            modelBuilder.Configurations.Add(new employeeMap());
            modelBuilder.Configurations.Add(new jobMap());
            modelBuilder.Configurations.Add(new pub_infoMap());
            modelBuilder.Configurations.Add(new publisherMap());
            modelBuilder.Configurations.Add(new royschedMap());
            modelBuilder.Configurations.Add(new saleMap());
            modelBuilder.Configurations.Add(new storeMap());
            modelBuilder.Configurations.Add(new titleauthorMap());
            modelBuilder.Configurations.Add(new titleMap());
            modelBuilder.Configurations.Add(new titleviewMap());
        }
    }
}
