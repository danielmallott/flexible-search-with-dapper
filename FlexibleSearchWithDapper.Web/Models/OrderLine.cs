using System;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// Order Line entity.
    /// </summary>
    [Table("Sales.OrderLines")]
    public class OrderLine
    {
        /// <summary>
        /// Order Line Id. Primary Key of this entity.
        /// </summary>
        [Key]
        public int OrderLineId { get; set; }
        
        /// <summary>
        /// Order Id.
        /// </summary>
        public int OrderId { get; set; }
        
        /// <summary>
        /// Stock Item Id.
        /// </summary>
        public int StockItemId { get; set; }
        
        /// <summary>
        /// Description.
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// Package Type Id.
        /// </summary>
        public int PackageTypeId { get; set; }
        
        /// <summary>
        /// Quantity.
        /// </summary>
        public int Quantity { get; set; }
        
        /// <summary>
        /// Unit Price.
        /// </summary>
        public decimal? UnitPrice { get; set; }
        
        /// <summary>
        /// Tax Rate.
        /// </summary>
        public decimal TaxRate { get; set; }
        
        /// <summary>
        /// Picked Quantity.
        /// </summary>
        public int PickedQuantity { get; set; }
        
        /// <summary>
        /// Picking Completed When.
        /// </summary>
        public DateTime? PickingCompletedWhen { get; set; }
        
        /// <summary>
        /// Last Edited By Id.
        /// </summary>
        public int LastEditedBy { get; set; }
        
        /// <summary>
        /// Last Edited When.
        /// </summary>
        public DateTime LastEditedWhen { get; set; }

        /// <summary>
        /// Last Edited Navigation Property.
        /// </summary>
        public Person LastEditedByNavigation { get; set; }
        
        /// <summary>
        /// Associated Order.
        /// </summary>
        public Order Order { get; set; }
        
        /// <summary>
        /// Associated Package Type.
        /// </summary>
        public PackageType PackageType { get; set; }
        
        /// <summary>
        /// Associated Stock Item.
        /// </summary>
        public StockItem StockItem { get; set; }
    }
}
