using System.ComponentModel.DataAnnotations.Schema;

namespace OneToOneRel
{
    public class Address
    {
        // properties
        public int Id { get; set; }
        public string Location { get; set; }

        public virtual Person Person { get; set; }
    }
}
