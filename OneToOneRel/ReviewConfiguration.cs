using System.Data.Entity.ModelConfiguration;

namespace OneToOneRel
{
    public class ReviewConfiguration : EntityTypeConfiguration<Review>
    {
        public ReviewConfiguration()
        {
            ToTable("Review");
            HasKey(x => new { x.Id });
        }
    }
}
