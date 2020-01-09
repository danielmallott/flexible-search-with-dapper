using System;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// Stock Item Stock Group Entity.
    /// </summary>
    [Table("Warehouse.StockItemStockGroups")]
    public class StockItemStockGroup
    {
        /// <summary>
        /// Stock Item Stock Group Id. Primary Key for this entity.
        /// </summary>
        [Key]
        public int StockItemStockGroupId { get; set; }
        
        /// <summary>
        /// Stock Item Id.
        /// </summary>
        public int StockItemId { get; set; }
        
        /// <summary>
        /// Stock Group Id.
        /// </summary>
        public int StockGroupId { get; set; }
        
        /// <summary>
        /// Last Edited By.
        /// </summary>
        public int LastEditedBy { get; set; }
        
        /// <summary>
        /// Last Edited When.
        /// </summary>
        public DateTime LastEditedWhen { get; set; }

        /// <summary>
        /// Last Edited By Navigation.
        /// </summary>
        public Person LastEditedByNavigation { get; set; }
        
        /// <summary>
        /// Associated Stock Group.
        /// </summary>
        public StockGroup StockGroup { get; set; }
        
        /// <summary>
        /// Associated Stock Item.
        /// </summary>
        public StockItem StockItem { get; set; }
    }
}
