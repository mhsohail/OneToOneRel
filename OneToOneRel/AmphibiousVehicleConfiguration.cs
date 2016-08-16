using System.Data.Entity.ModelConfiguration;

namespace OneToOneRel
{
    public class AmphibiousVehicleConfiguration : EntityTypeConfiguration<AmphibiousVehicle>
    {
        public AmphibiousVehicleConfiguration()
        {
            ToTable("AmphibiousVehicle");
            HasKey(x => x.Id);
        }
    }
}
