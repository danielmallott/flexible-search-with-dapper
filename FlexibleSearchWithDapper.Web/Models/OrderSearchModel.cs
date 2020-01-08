using System;

namespace FlexibleSearchWithDapper.Web.Models
{
    public class OrderSearchModel
    {
        public int? CustomerID { get; set; }
        public int? SalesPersonID { get; set; }
        public int? ContactPersonID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
        public string CustomerPurchaseOrderNumber { get; set; }
        public int? StockItemID { get; set; }
        public string Description { get; set; }
        public int? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}