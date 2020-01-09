using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// Customer Category Entity.
    /// </summary>
    [Table("Sales.CustomerCategories")]
    public class CustomerCategory
    {
        /// <summary>
        /// Instantiates a new <see cref="CustomerCategory"/>.
        /// </summary>
        public CustomerCategory()
        {
            Customers = new HashSet<Customer>();
            SpecialDeals = new HashSet<SpecialDeal>();
        }

        /// <summary>
        /// Customer Category Id. Primary Key for this entity.
        /// </summary>
        [Key]
        public int CustomerCategoryId { get; set; }
        
        /// <summary>
        /// Customer Category Name.
        /// </summary>
        public string CustomerCategoryName { get; set; }
        
        /// <summary>
        /// Last Edited By.
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
        /// Last Edited By Navigation.
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
