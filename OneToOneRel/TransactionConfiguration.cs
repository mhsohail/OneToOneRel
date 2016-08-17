using System.Data.Entity.ModelConfiguration;

namespace OneToOneRel
{
    public class TransactionConfiguration : EntityTypeConfiguration<Transaction>
    {
        public TransactionConfiguration()
        {
            ToTable("Transaction");
            HasKey(x => new { x.Id });
        }
    }
}
