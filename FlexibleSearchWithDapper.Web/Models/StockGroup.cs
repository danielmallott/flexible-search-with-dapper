using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// Stock Group Entity.
    /// </summary>
    [Table("Warehouse.StockGroups")]
    public class StockGroup
    {
        /// <summary>
        /// Instantiates a new <see cref="StockGroup"/>.
        /// </summary>
        public StockGroup()
        {
            SpecialDeals = new HashSet<SpecialDeal>();
            StockItemStockGroups = new HashSet<StockItemStockGroup>();
        }

        /// <summary>
        /// Stock Group Id. Primary Key for this entity.
        /// </summary>
        [Key]
        public int StockGroupId { get; set; }
        
        /// <summary>
        /// Stock Group Name.
        /// </summary>
        public string StockGroupName { get; set; }
        
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
        /// Associated Special Deals.
        /// </summary>
        public ICollection<SpecialDeal> SpecialDeals { get; set; }
        
        /// <summary>
        /// Associated Stock Item Stock Groups.
        /// </summary>
        public ICollection<StockItemStockGroup> StockItemStockGroups { get; set; }
    }
}
