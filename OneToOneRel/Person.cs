using System.ComponentModel.DataAnnotations.Schema;

namespace OneToOneRel
{
    public class Person
    {
        // properties
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual Address Address { get; set; }
    }
}
