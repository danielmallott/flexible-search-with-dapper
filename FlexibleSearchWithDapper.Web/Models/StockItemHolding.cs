using System;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// Stock Item Holding Entity.
    /// </summary>
    [Table("Warehouse.StockItemHoldings")]
    public class StockItemHolding
    {
        /// <summary>
        /// Stock Item Id. Primary Key for this entity.
        /// </summary>
        [ExplicitKey]
        public int StockItemId { get; set; }
        
        /// <summary>
        /// Quantity On Hand.
        /// </summary>
        public int QuantityOnHand { get; set; }
        
        /// <summary>
        /// Bin Location.
        /// </summary>
        public string BinLocation { get; set; }
        
        /// <summary>
        /// Last Stocktake Quantity
        /// </summary>
        public int LastStocktakeQuantity { get; set; }
        
        /// <summary>
        /// Last Cost Price.
        /// </summary>
        public decimal LastCostPrice { get; set; }
        
        /// <summary>
        /// Reorder Level.
        /// </summary>
        public int ReorderLevel { get; set; }
        
        /// <summary>
        /// Target Stock Level.
        /// </summary>
        public int TargetStockLevel { get; set; }
        
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
        /// Associated Stock Item.
        /// </summary>
        public StockItem StockItem { get; set; }
    }
}
