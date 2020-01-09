using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// Purchase Order Entity.
    /// </summary>
    [Table("Purchasing.PurchaseOrders")]
    public class PurchaseOrder
    {
        /// <summary>
        /// Instantiates a new <see cref="PurchaseOrder"/>.
        /// </summary>
        public PurchaseOrder()
        {
            PurchaseOrderLines = new HashSet<PurchaseOrderLine>();
            StockItemTransactions = new HashSet<StockItemTransaction>();
            SupplierTransactions = new HashSet<SupplierTransaction>();
        }

        /// <summary>
        /// Purchase Order Id. Primary Key of this entity.
        /// </summary>
        [Key]
        public int PurchaseOrderId { get; set; }
        
        /// <summary>
        /// Supplier Id.
        /// </summary>
        public int SupplierId { get; set; }
        
        /// <summary>
        /// Order Date.
        /// </summary>
        public DateTime OrderDate { get; set; }
        
        /// <summary>
        /// Delivery Method Id.
        /// </summary>
        public int DeliveryMethodId { get; set; }
        
        /// <summary>
        /// Contact Person Id.
        /// </summary>
        public int ContactPersonId { get; set; }
        
        /// <summary>
        /// Expected Delivery Date.
        /// </summary>
        public DateTime? ExpectedDeliveryDate { get; set; }
        
        /// <summary>
        /// Supplier Reference.
        /// </summary>
        public string SupplierReference { get; set; }
        
        /// <summary>
        /// Is Order Finalized.
        /// </summary>
        public bool IsOrderFinalized { get; set; }
        
        /// <summary>
        /// Comments.
        /// </summary>
        public string Comments { get; set; }
        
        /// <summary>
        /// Internal Comments.
        /// </summary>
        public string InternalComments { get; set; }
        
        /// <summary>
        /// Last Edited By.
        /// </summary>
        public int LastEditedBy { get; set; }
        
        /// <summary>
        /// Last Edited When.
        /// </summary>
        public DateTime LastEditedWhen { get; set; }

        /// <summary>
        /// Associated Contact Person.
        /// </summary>
        public Person ContactPerson { get; set; }
        
        /// <summary>
        /// Associated Delivery Method.
        /// </summary>
        public DeliveryMethod DeliveryMethod { get; set; }
        
        /// <summary>
        /// Last Edited By Navigation.
        /// </summary>
        public Person LastEditedByNavigation { get; set; }
        
        /// <summary>
        /// Associated Supplier.
        /// </summary>
        public Supplier Supplier { get; set; }
        
        /// <summary>
        /// Associated Purchase Order Lines.
        /// </summary>
        public ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; }
        
        /// <summary>
        /// Associated Stock Item Transactions.
        /// </summary>
        public ICollection<StockItemTransaction> StockItemTransactions { get; set; }
        
        /// <summary>
        /// Associated Supplier Transactions.
        /// </summary>
        public ICollection<SupplierTransaction> SupplierTransactions { get; set; }
    }
}
