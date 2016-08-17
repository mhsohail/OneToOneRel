namespace OneToOneRel
{
    public class TransactionReview
    {
        public int Id { get; set; }
        public int TransactionId { get; set; }
        public int ReviewId { get; set; }

        public virtual Transaction Transaction { get; set; }
        public virtual Review Review { get; set; }
    }
}
