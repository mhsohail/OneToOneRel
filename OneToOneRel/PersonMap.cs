using System.Data.Entity.ModelConfiguration;

namespace OneToOneRel
{
    public class PersonMap : EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            ToTable("Person");
            HasKey(p => p.Id);

        }
    }
}
