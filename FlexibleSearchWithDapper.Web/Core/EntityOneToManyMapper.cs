using System;
using System.Collections.Generic;

namespace FlexibleSearchWithDapper.Web.Core
{
    public class EntityOneToManyMapper<TParent,TChild,TParentKey>
    {
        private readonly IDictionary<TParentKey, TParent> _lookup = new Dictionary<TParentKey, TParent>();

        public Action<TParent, TChild> AddChildAction { get; set; }

        public Func<TParent, TParentKey> ParentKey { get; set; }


        public virtual TParent Map(TParent parent, TChild child)
        {
            var found = true;
            var primaryKey = ParentKey(parent);

            if (!_lookup.TryGetValue(primaryKey, out var entity))
            {
                _lookup.Add(primaryKey, parent);
                entity = parent;
                found = false;
            }

            AddChildAction(entity, child);

            return !found ? entity : default(TParent);

        }
    }
}