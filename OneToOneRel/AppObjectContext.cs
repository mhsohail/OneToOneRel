using System.Data.Entity;

namespace OneToOneRel
{
    public class AppObjectContext : DbContext
    {
        public AppObjectContext() : base("AppConnectionString")
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AmphibiousVehicle> AmphibiousVehicles { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new AddressMap());
            modelBuilder.Configurations.Add(new AmphibiousVehicleConfiguration());
            modelBuilder.Configurations.Add(new ReviewConfiguration());
        }
    }
}
