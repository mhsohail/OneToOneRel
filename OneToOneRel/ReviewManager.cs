using System;
using System.Collections.Generic;
using System.Linq;

namespace OneToOneRel
{
    public class ReviewManager
    {
        private AppObjectContext context = null;
        public ReviewManager()
        {
            context = new AppObjectContext();
        }

        public IList<Review> GetReviews<T>(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            var entity_props = typeof(T).GetProperties();
            var IdProp = entity_props.Where(p => p.Name.Equals("Id")).FirstOrDefault();

            //int entityId = entity.Id; // in case of some base class
            var entityId = int.Parse(IdProp.GetValue(entity).ToString()); // in case of no base class

            string entityName = typeof(T).Name;

            var query = from sm in context.Reviews
                        where sm.EntityId == entityId &&
                        sm.EntityName == entityName
                        select sm;
            var storeMappings = query.ToList();
            return storeMappings;
        }
    }
}
