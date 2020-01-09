using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// Customer Entity.
    /// </summary>
    [Table("Sales.Customers")]
    public class Customer
    {
        /// <summary>
        /// Instantiates a new <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            CustomerTransactions = new HashSet<CustomerTransaction>();
            InverseBillToCustomer = new HashSet<Customer>();
            InvoicesBillToCustomer = new HashSet<Invoice>();
            InvoicesCustomer = new HashSet<Invoice>();
            Orders = new HashSet<Order>();
            SpecialDeals = new HashSet<SpecialDeal>();
            StockItemTransactions = new HashSet<StockItemTransaction>();
        }

        /// <summary>
        /// Customer Id. Primary Key for this entity.
        /// </summary>
        [Key]
        public int CustomerId { get; set; }
        
        /// <summary>
        /// Customer Name.
        /// </summary>
        public string CustomerName { get; set; }
        
        /// <summary>
        /// Bill To Customer Id.
        /// </summary>
        public int BillToCustomerId { get; set; }
        
        /// <summary>
        /// Customer Category Id.
        /// </summary>
        public int CustomerCategoryId { get; set; }
        
        /// <summary>
        /// Buying Group Id.
        /// </summary>
        public int? BuyingGroupId { get; set; }
        
        /// <summary>
        /// Primary Contact Person Id.
        /// </summary>
        public int PrimaryContactPersonId { get; set; }
        
        /// <summary>
        /// Alternate Contact Person Id.
        /// </summary>
        public int? AlternateContactPersonId { get; set; }
        
        /// <summary>
        /// Delivery Method Id.
        /// </summary>
        public int DeliveryMethodId { get; set; }
        
        /// <summary>
        /// Delivery City Id.
        /// </summary>
        public int DeliveryCityId { get; set; }
        
        /// <summary>
        /// Postal City Id.
        /// </summary>
        public int PostalCityId { get; set; }
        
        /// <summary>
        /// Credit Limit.
        /// </summary>
        public decimal? CreditLimit { get; set; }
        
        /// <summary>
        /// Account Opened Date.
        /// </summary>
        public DateTime AccountOpenedDate { get; set; }
        
        /// <summary>
        /// Standard Discount Percentage.
        /// </summary>
        public decimal StandardDiscountPercentage { get; set; }
        
        /// <summary>
        /// Is Statement Sent.
        /// </summary>
        public bool IsStatementSent { get; set; }
        
        /// <summary>
        /// Is On Credit Hold.
        /// </summary>
        public bool IsOnCreditHold { get; set; }
        
        /// <summary>
        /// Payment Days.
        /// </summary>
        public int PaymentDays { get; set; }
        
        /// <summary>
        /// Phone Number.
        /// </summary>
        public string PhoneNumber { get; set; }
        
        /// <summary>
        /// Fax Number.
        /// </summary>
        public string FaxNumber { get; set; }
        
        /// <summary>
        /// Delivery Run.
        /// </summary>
        public string DeliveryRun { get; set; }
        
        /// <summary>
        /// Run Position.
        /// </summary>
        public string RunPosition { get; set; }
        
        /// <summary>
        /// Website URL.
        /// </summary>
        public string WebsiteUrl { get; set; }
        
        /// <summary>
        /// Delivery Address Line 1.
        /// </summary>
        public string DeliveryAddressLine1 { get; set; }
        
        /// <summary>
        /// Deliver Address Line 2.
        /// </summary>
        public string DeliveryAddressLine2 { get; set; }
        
        /// <summary>
        /// Delivery Postal Code.
        /// </summary>
        public string DeliveryPostalCode { get; set; }
        
        /// <summary>
        /// Postal Address Line 1.
        /// </summary>
        public string PostalAddressLine1 { get; set; }
        
        /// <summary>
        /// Postal Address Line 2.
        /// </summary>
        public string PostalAddressLine2 { get; set; }
        
        /// <summary>
        /// Postal Postal Code.
        /// </summary>
        public string PostalPostalCode { get; set; }
        
        /// <summary>
        /// Last Edited By.
        /// </summary>
        public int LastEditedBy { get; set; }
        
        /// <summary>
        /// Valid From.
        /// </summary>
        public DateTime ValidFrom { get; set; }
        
        /// <summary>
        /// Valid To.
        /// </summary>
        public DateTime ValidTo { get; set; }

        /// <summary>
        /// Associated Alternate Contact Person.
        /// </summary>
        public Person AlternateContactPerson { get; set; }
        
        /// <summary>
        /// Associated Bill To Customer.
        /// </summary>
        public Customer BillToCustomer { get; set; }
        
        /// <summary>
        /// Associated Buying Group.
        /// </summary>
        public BuyingGroup BuyingGroup { get; set; }
        
        /// <summary>
        /// Associated Customer Category.
        /// </summary>
        public CustomerCategory CustomerCategory { get; set; }
        
        /// <summary>
        /// Associated Delivery City.
        /// </summary>
        public City DeliveryCity { get; set; }
        
        /// <summary>
        /// Associated Delivery Method.
        /// </summary>
        public DeliveryMethod DeliveryMethod { get; set; }
        
        /// <summary>
        /// Last Edited By Navigation.
        /// </summary>
        public Person LastEditedByNavigation { get; set; }
        
        /// <summary>
        /// Associated Postal City.
        /// </summary>
        public City PostalCity { get; set; }
        
        /// <summary>
        /// Associated Primary Contact Person.
        /// </summary>
        public Person PrimaryContactPerson { get; set; }
        
        /// <summary>
        /// Associated Customer Transactions.
        /// </summary>
        public ICollection<CustomerTransaction> CustomerTransactions { get; set; }
        
        /// <summary>
        /// Inverse Bill To Customer Associations.
        /// </summary>
        public ICollection<Customer> InverseBillToCustomer { get; set; }
        
        /// <summary>
        /// Associated Invoices with Bill To Customer.
        /// </summary>
        public ICollection<Invoice> InvoicesBillToCustomer { get; set; }
        
        /// <summary>
        /// Associated Invoices.
        /// </summary>
        public ICollection<Invoice> InvoicesCustomer { get; set; }
        
        /// <summary>
        /// Associated Orders.
        /// </summary>
        public ICollection<Order> Orders { get; set; }
        
        /// <summary>
        /// Associated Special Deals.
        /// </summary>
        public ICollection<SpecialDeal> SpecialDeals { get; set; }
        
        /// <summary>
        /// Associated Stock Item Transactions.
        /// </summary>
        public ICollection<StockItemTransaction> StockItemTransactions { get; set; }
    }
}
