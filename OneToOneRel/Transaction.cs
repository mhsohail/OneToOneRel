using System;

namespace OneToOneRel
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual TransactionReview TransactionReview { get; set; }
    }
}
