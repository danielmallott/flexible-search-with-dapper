using System;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// Stock Item Transaction Entity.
    /// </summary>
    [Table("Warehouse.StockItemTransactions")]
    public class StockItemTransaction
    {
        /// <summary>
        /// Stock Item Transaction Id. Primary Key of this entity.
        /// </summary>
        [Key]
        public int StockItemTransactionId { get; set; }
        
        /// <summary>
        /// Stock Item Id.
        /// </summary>
        public int StockItemId { get; set; }
        
        /// <summary>
        /// Transaction Type Id.
        /// </summary>
        public int TransactionTypeId { get; set; }
        
        /// <summary>
        /// Customer Id.
        /// </summary>
        public int? CustomerId { get; set; }
        
        /// <summary>
        /// Invoice Id.
        /// </summary>
        public int? InvoiceId { get; set; }
        
        /// <summary>
        /// Supplier Id.
        /// </summary>
        public int? SupplierId { get; set; }
        
        /// <summary>
        /// Purchase Order Id.
        /// </summary>
        public int? PurchaseOrderId { get; set; }
        
        /// <summary>
        /// Transaction Occurred When.
        /// </summary>
        public DateTime TransactionOccurredWhen { get; set; }
        
        /// <summary>
        /// Quantity.
        /// </summary>
        public decimal Quantity { get; set; }
        
        /// <summary>
        /// Last Edited By.
        /// </summary>
        public int LastEditedBy { get; set; }
        
        /// <summary>
        /// Last Edited When.
        /// </summary>
        public DateTime LastEditedWhen { get; set; }

        /// <summary>
        /// Associated Customer.
        /// </summary>
        public Customer Customer { get; set; }
        
        /// <summary>
        /// Associated Invoice.
        /// </summary>
        public Invoice Invoice { get; set; }
        
        /// <summary>
        /// Last Edited By Navigation.
        /// </summary>
        public Person LastEditedByNavigation { get; set; }
        
        /// <summary>
        /// Associated Purchase Order.
        /// </summary>
        public PurchaseOrder PurchaseOrder { get; set; }
        
        /// <summary>
        /// Associated Stock Item.
        /// </summary>
        public StockItem StockItem { get; set; }
        
        /// <summary>
        /// Associated Supplier.
        /// </summary>
        public Supplier Supplier { get; set; }
        
        /// <summary>
        /// Associated Transaction Type.
        /// </summary>
        public TransactionType TransactionType { get; set; }
    }
}
