using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// Supplier Category Entity.
    /// </summary>
    [Table("Purchasing.SupplierCategories")]
    public class SupplierCategory
    {
        /// <summary>
        /// Instantiates a new <see cref="SupplierCategory"/>.
        /// </summary>
        public SupplierCategory()
        {
            Suppliers = new HashSet<Supplier>();
        }

        /// <summary>
        /// Supplier Category Id. Primary Key for this entity.
        /// </summary>
        [Key]
        public int SupplierCategoryId { get; set; }
        
        /// <summary>
        /// Supplier Category Name.
        /// </summary>
        public string SupplierCategoryName { get; set; }
        
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
        /// Associated Suppliers.
        /// </summary>
        public ICollection<Supplier> Suppliers { get; set; }
    }
}
