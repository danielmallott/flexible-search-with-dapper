using System;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// Order Search Model.
    /// </summary>
    public class OrderSearchModel
    {
        /// <summary>
        /// Customer Id to search for.
        /// </summary>
        public int? CustomerId { get; set; }
        
        /// <summary>
        /// Sales Person Id to search for.
        /// </summary>
        public int? SalesPersonId { get; set; }
        
        /// <summary>
        /// Contact Person Id to search for.
        /// </summary>
        public int? ContactPersonId { get; set; }
        
        /// <summary>
        /// Order Date to search for.
        /// </summary>
        public DateTime? OrderDate { get; set; }
        
        /// <summary>
        /// Expected Delivery Date to search for.
        /// </summary>
        public DateTime? ExpectedDeliveryDate { get; set; }
        
        /// <summary>
        /// Customer Purchase Order Number to search for.
        /// </summary>
        public string CustomerPurchaseOrderNumber { get; set; }
        
        /// <summary>
        /// Stock Item Id to search for.
        /// </summary>
        public int? StockItemId { get; set; }
        
        /// <summary>
        /// Description to search for.
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// Quantity to search for.
        /// </summary>
        public int? Quantity { get; set; }
        
        /// <summary>
        /// Unit Price to search for.
        /// </summary>
        public decimal? UnitPrice { get; set; }
    }
}