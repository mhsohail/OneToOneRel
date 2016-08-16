using System.Data.Entity.ModelConfiguration;

namespace OneToOneRel
{
    public class AddressMap : EntityTypeConfiguration<Address>
    {
        public AddressMap()
        {
            ToTable("Address");
            HasKey(p => p.Id);
            Property(a => a.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            
            HasRequired(p => p.Person)
                .WithOptional(a => a.Address);
        }
    }
}
