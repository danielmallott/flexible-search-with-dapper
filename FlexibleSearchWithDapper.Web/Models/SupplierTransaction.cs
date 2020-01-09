using System;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// Supplier Transaction Entity.
    /// </summary>
    [Table("Purchasing.SupplierTransactions")]
    public class SupplierTransaction
    {
        /// <summary>
        /// Supplier Transaction Id. Primary Key of this entity.
        /// </summary>
        [Key]
        public int SupplierTransactionId { get; set; }
        
        /// <summary>
        /// Supplier Id.
        /// </summary>
        public int SupplierId { get; set; }
        
        /// <summary>
        /// Transaction Type Id.
        /// </summary>
        public int TransactionTypeId { get; set; }
        
        /// <summary>
        /// Purchase Order Id.
        /// </summary>
        public int? PurchaseOrderId { get; set; }
        
        /// <summary>
        /// Payment Method Id.
        /// </summary>
        public int? PaymentMethodId { get; set; }
        
        /// <summary>
        /// Supplier Invoice Number.
        /// </summary>
        public string SupplierInvoiceNumber { get; set; }
        
        /// <summary>
        /// Transaction Date.
        /// </summary>
        public DateTime TransactionDate { get; set; }
        
        /// <summary>
        /// Amount Excluding Tax.
        /// </summary>
        public decimal AmountExcludingTax { get; set; }
        
        /// <summary>
        /// Tax Amount.
        /// </summary>
        public decimal TaxAmount { get; set; }
        
        /// <summary>
        /// Transaction Amount.
        /// </summary>
        public decimal TransactionAmount { get; set; }
        
        /// <summary>
        /// Outstanding Balance.
        /// </summary>
        public decimal OutstandingBalance { get; set; }
        
        /// <summary>
        /// Finalization Date.
        /// </summary>
        public DateTime? FinalizationDate { get; set; }
        
        /// <summary>
        /// Is Finalized.
        /// </summary>
        public bool? IsFinalized { get; set; }
        
        /// <summary>
        /// Last Edited By.
        /// </summary>
        public int LastEditedBy { get; set; }
        
        /// <summary>
        /// Last Edited When.
        /// </summary>
        public DateTime LastEditedWhen { get; set; }

        /// <summary>
        /// Late Edited By Navigation.
        /// </summary>
        public Person LastEditedByNavigation { get; set; }
        
        /// <summary>
        /// Associated Payment Method.
        /// </summary>
        public PaymentMethod PaymentMethod { get; set; }
        
        /// <summary>
        /// Associated Purchase Order.
        /// </summary>
        public PurchaseOrder PurchaseOrder { get; set; }
        
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
