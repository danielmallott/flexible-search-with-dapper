using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// Buying Group entity.
    /// </summary>
    [Table("Sales.BuyingGroups")]
    public class BuyingGroup
    {
        /// <summary>
        /// Instantiates a new <see cref="BuyingGroup"/>.
        /// </summary>
        public BuyingGroup()
        {
            Customers = new HashSet<Customer>();
            SpecialDeals = new HashSet<SpecialDeal>();
        }

        /// <summary>
        /// Buying Group Id. Primary Key for this entity.
        /// </summary>
        [ExplicitKey]
        public int BuyingGroupId { get; set; }
        
        /// <summary>
        /// Buying Group Name.
        /// </summary>
        public string BuyingGroupName { get; set; }
        
        /// <summary>
        /// Last Edited By
        /// </summary>
        public int LastEditedBy { get; set; }
        
        /// <summary>
        /// Valid From.
        /// </summary>
        public DateTime ValidFrom { get; set; }
        
        /// <summary>
        /// Valid To.
        /// </summary>
        public DateTime ValidTo { get; set; }

        /// <summary>
        /// Associated Last Edited By.
        /// </summary>
        public Person LastEditedByNavigation { get; set; }
        
        /// <summary>
        /// Associated Customers.
        /// </summary>
        public ICollection<Customer> Customers { get; set; }
        
        /// <summary>
        /// Associated Special Deals.
        /// </summary>
        public ICollection<SpecialDeal> SpecialDeals { get; set; }
    }
}
