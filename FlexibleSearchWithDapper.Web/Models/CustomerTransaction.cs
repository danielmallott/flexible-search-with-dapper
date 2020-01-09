using System;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// Customer Transaction Entity.
    /// </summary>
    [Table("Sales.CustomerTransactions")]
    public class CustomerTransaction
    {
        /// <summary>
        /// Customer Transaction Id. Primary Key for this entity.
        /// </summary>
        [Key]
        public int CustomerTransactionId { get; set; }
        
        /// <summary>
        /// Customer Id.
        /// </summary>
        public int CustomerId { get; set; }
        
        /// <summary>
        /// Transaction Type Id.
        /// </summary>
        public int TransactionTypeId { get; set; }
        
        /// <summary>
        /// Invoice Id.
        /// </summary>
        public int? InvoiceId { get; set; }
        
        /// <summary>
        /// Payment Method Id.
        /// </summary>
        public int? PaymentMethodId { get; set; }
        
        /// <summary>
        /// Transaction Date.
        /// </summary>
        public DateTime TransactionDate { get; set; }
        
        /// <summary>
        /// Amount Excluding Tax.
        /// </summary>
        public decimal AmountExcludingTax { get; set; }
        
        /// <summary>
        /// Tax Amount
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
        /// Associated Payment Method.
        /// </summary>
        public PaymentMethod PaymentMethod { get; set; }
        
        /// <summary>
        /// Associated Transaction Type.
        /// </summary>
        public TransactionType TransactionType { get; set; }
    }
}
