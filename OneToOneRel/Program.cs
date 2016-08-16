using System.Linq;

namespace OneToOneRel
{
    public class Program
    {
        static void Main(string[] args)
        {
            var context = new AppObjectContext();
            var reviewManager = new ReviewManager();

            var people = context.People.ToList();
            foreach (var person in people)
            {
                var reviews = reviewManager.GetReviews<Person>(person);

            }

            var vehicles = context.AmphibiousVehicles;
            foreach (var vehicle in vehicles)
            {
                
            }
        }
    }
}
