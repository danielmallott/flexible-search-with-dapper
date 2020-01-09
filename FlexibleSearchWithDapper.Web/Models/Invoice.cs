using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// Invoice Entity.
    /// </summary>
    [Table("Sales.Invoices")]
    public class Invoice
    {
        /// <summary>
        /// Instantiates a new <see cref="Invoice"/>.
        /// </summary>
        public Invoice()
        {
            CustomerTransactions = new HashSet<CustomerTransaction>();
            InvoiceLines = new HashSet<InvoiceLine>();
            StockItemTransactions = new HashSet<StockItemTransaction>();
        }

        /// <summary>
        /// Invoice Id. Primary Key for this entity.
        /// </summary>
        [Key]
        public int InvoiceId { get; set; }
        
        /// <summary>
        /// Customer Id.
        /// </summary>
        public int CustomerId { get; set; }
        
        /// <summary>
        /// Bill To Customer Id.
        /// </summary>
        public int BillToCustomerId { get; set; }
        
        /// <summary>
        /// Order Id.
        /// </summary>
        public int? OrderId { get; set; }
        
        /// <summary>
        /// Delivery Method Id.
        /// </summary>
        public int DeliveryMethodId { get; set; }
        
        /// <summary>
        /// Contact Person Id.
        /// </summary>
        public int ContactPersonId { get; set; }
        
        /// <summary>
        /// Accounts Person Id.
        /// </summary>
        public int AccountsPersonId { get; set; }
        
        /// <summary>
        /// Salesperson Person Id.
        /// </summary>
        public int SalespersonPersonId { get; set; }
        
        /// <summary>
        /// Packed By Person Id.
        /// </summary>
        public int PackedByPersonId { get; set; }
        
        /// <summary>
        /// Invoice Date.
        /// </summary>
        public DateTime InvoiceDate { get; set; }
        
        /// <summary>
        /// Customer Purchase Order Number.
        /// </summary>
        public string CustomerPurchaseOrderNumber { get; set; }
        
        /// <summary>
        /// Is Credit Note.
        /// </summary>
        public bool IsCreditNote { get; set; }
        
        /// <summary>
        /// Credit Note Reason.
        /// </summary>
        public string CreditNoteReason { get; set; }
        
        /// <summary>
        /// Comments.
        /// </summary>
        public string Comments { get; set; }
        
        /// <summary>
        /// Delivery Instructions.
        /// </summary>
        public string DeliveryInstructions { get; set; }
        
        /// <summary>
        /// Internal Comments.
        /// </summary>
        public string InternalComments { get; set; }
        
        /// <summary>
        /// Total Dry Items.
        /// </summary>
        public int TotalDryItems { get; set; }
        
        /// <summary>
        /// Total Chiller Iterms.
        /// </summary>
        public int TotalChillerItems { get; set; }
        
        /// <summary>
        /// Delivery Run.
        /// </summary>
        public string DeliveryRun { get; set; }
        
        /// <summary>
        /// Run Position.
        /// </summary>
        public string RunPosition { get; set; }
        
        /// <summary>
        /// Returned Delivery Data.
        /// </summary>
        public string ReturnedDeliveryData { get; set; }
        
        /// <summary>
        /// Confirmed Delivery Time.
        /// </summary>
        public DateTime? ConfirmedDeliveryTime { get; set; }
        
        /// <summary>
        /// Confirmed Received By.
        /// </summary>
        public string ConfirmedReceivedBy { get; set; }
        
        /// <summary>
        /// Last Edited By.
        /// </summary>
        public int LastEditedBy { get; set; }
        
        /// <summary>
        /// Last Edited When.
        /// </summary>
        public DateTime LastEditedWhen { get; set; }

        /// <summary>
        /// Associated Accounts Person.
        /// </summary>
        public Person AccountsPerson { get; set; }
        
        /// <summary>
        /// Associated Bill To Customer.
        /// </summary>
        public Customer BillToCustomer { get; set; }
        
        /// <summary>
        /// Associated Contact Person.
        /// </summary>
        public Person ContactPerson { get; set; }
        
        /// <summary>
        /// Associated Customer.
        /// </summary>
        public Customer Customer { get; set; }
        
        /// <summary>
        /// Associated Delivery Method.
        /// </summary>
        public DeliveryMethod DeliveryMethod { get; set; }
        
        /// <summary>
        /// Last Edited By Navigation.
        /// </summary>
        public Person LastEditedByNavigation { get; set; }
        
        /// <summary>
        /// Associated Order.
        /// </summary>
        public Order Order { get; set; }
        
        /// <summary>
        /// Associated Packed By Person.
        /// </summary>
        public Person PackedByPerson { get; set; }
        
        /// <summary>
        /// Associated Salesperson Person.
        /// </summary>
        public Person SalespersonPerson { get; set; }
        
        /// <summary>
        /// Associated Customer Transactions.
        /// </summary>
        public ICollection<CustomerTransaction> CustomerTransactions { get; set; }
        
        /// <summary>
        /// Associated Invoice Lines.
        /// </summary>
        public ICollection<InvoiceLine> InvoiceLines { get; set; }
        
        /// <summary>
        /// Associated Stock Item Transactions.
        /// </summary>
        public ICollection<StockItemTransaction> StockItemTransactions { get; set; }
    }
}
