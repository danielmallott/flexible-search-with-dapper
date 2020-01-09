using System;
using System.Collections.Generic;

namespace FlexibleSearchWithDapper.Web.Core
{
    /// <summary>
    /// Entity One to Many Mapper for use with Dapper.
    /// </summary>
    /// <typeparam name="TParent">Type of the Parent entity.</typeparam>
    /// <typeparam name="TChild">Type of the Child entity.</typeparam>
    /// <typeparam name="TParentKey">Type of the Key of the Parent entity.</typeparam>
    public class EntityOneToManyMapper<TParent,TChild,TParentKey>
    {
        private readonly IDictionary<TParentKey, TParent> _lookup = new Dictionary<TParentKey, TParent>();

        /// <summary>
        /// Add child action. Supplied at Mapper construction.
        /// </summary>
        public Action<TParent, TChild> AddChildAction { get; set; }

        /// <summary>
        /// Function to get the Key from the Parent. Supplied at Mapper construction.
        /// </summary>
        public Func<TParent, TParentKey> ParentKey { get; set; }
        
        /// <summary>
        /// Maps the row. Relies on Dapper to split the row to Parent and Child entities.
        /// </summary>
        /// <param name="parent">Parent entity.</param>
        /// <param name="child">Child entity.</param>
        /// <returns>Mapped Parent entity.</returns>
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