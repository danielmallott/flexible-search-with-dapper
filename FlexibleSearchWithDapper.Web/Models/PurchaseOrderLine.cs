using System;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// Purchase Order Line Entity.
    /// </summary>
    [Table("Purchasing.PurchaseOrderLines")]
    public class PurchaseOrderLine
    {
        /// <summary>
        /// Purchase Order Line Id. Primary Key for this entity.
        /// </summary>
        [Key]
        public int PurchaseOrderLineId { get; set; }
        
        /// <summary>
        /// Purchase Order Id.
        /// </summary>
        public int PurchaseOrderId { get; set; }
        
        /// <summary>
        /// Stock Item Id.
        /// </summary>
        public int StockItemId { get; set; }
        
        /// <summary>
        /// Ordered Outers.
        /// </summary>
        public int OrderedOuters { get; set; }
        
        /// <summary>
        /// Description.
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// Received Outers.
        /// </summary>
        public int ReceivedOuters { get; set; }
        
        /// <summary>
        /// Package Type Id.
        /// </summary>
        public int PackageTypeId { get; set; }
        
        /// <summary>
        /// Expected Unit Price Per Outer.
        /// </summary>
        public decimal? ExpectedUnitPricePerOuter { get; set; }
        
        /// <summary>
        /// Last Receipt Date.
        /// </summary>
        public DateTime? LastReceiptDate { get; set; }
        
        /// <summary>
        /// Is Order Line Finalized.
        /// </summary>
        public bool IsOrderLineFinalized { get; set; }
        
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
        /// Associated Package Type.
        /// </summary>
        public PackageType PackageType { get; set; }
        
        /// <summary>
        /// Associated Purchase Order.
        /// </summary>
        public PurchaseOrder PurchaseOrder { get; set; }
        
        /// <summary>
        /// Associated Stock Item.
        /// </summary>
        public StockItem StockItem { get; set; }
    }
}
