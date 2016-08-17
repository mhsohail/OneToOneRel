using System.Data.Entity.ModelConfiguration;

namespace OneToOneRel
{
    public class TransactionReviewConfiguration : EntityTypeConfiguration<TransactionReview>
    {
        public TransactionReviewConfiguration()
        {
            ToTable("TransactionReview");
            HasKey(x => new { x.Id });

            this.HasRequired(x => x.Transaction)
                .WithOptional(x => x.TransactionReview);

            this.HasRequired(x => x.Review)
                .WithOptional(x => x.TransactionReview);
        }
    }
}
