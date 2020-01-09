using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// Supplier Entity.
    /// </summary>
    [Table("Purchasing.Suppliers")]
    public class Supplier
    {
        /// <summary>
        /// Instantiates a new <see cref="Supplier"/>.
        /// </summary>
        public Supplier()
        {
            PurchaseOrders = new HashSet<PurchaseOrder>();
            StockItemTransactions = new HashSet<StockItemTransaction>();
            StockItems = new HashSet<StockItem>();
            SupplierTransactions = new HashSet<SupplierTransaction>();
        }

        /// <summary>
        /// Supplier Id. Primary Key for this entity.
        /// </summary>
        [Key]
        public int SupplierId { get; set; }
        
        /// <summary>
        /// Supplier Name.
        /// </summary>
        public string SupplierName { get; set; }
        
        /// <summary>
        /// Supplier Category Id.
        /// </summary>
        public int SupplierCategoryId { get; set; }
        
        /// <summary>
        /// Primary Contact Person Id.
        /// </summary>
        public int PrimaryContactPersonId { get; set; }
        
        /// <summary>
        /// Alternate Contact Person Id.
        /// </summary>
        public int AlternateContactPersonId { get; set; }
        
        /// <summary>
        /// Delivery Method Id.
        /// </summary>
        public int? DeliveryMethodId { get; set; }
        
        /// <summary>
        /// Delivery City Id.
        /// </summary>
        public int DeliveryCityId { get; set; }
        
        /// <summary>
        /// Postal City Id.
        /// </summary>
        public int PostalCityId { get; set; }
        
        /// <summary>
        /// Supplier Reference.
        /// </summary>
        public string SupplierReference { get; set; }
        
        /// <summary>
        /// Bank Account Name.
        /// </summary>
        public string BankAccountName { get; set; }
        
        /// <summary>
        /// Bank Account Branch.
        /// </summary>
        public string BankAccountBranch { get; set; }
        
        /// <summary>
        /// Bank Account Code.
        /// </summary>
        public string BankAccountCode { get; set; }
        
        /// <summary>
        /// Bank Account Number.
        /// </summary>
        public string BankAccountNumber { get; set; }
        
        /// <summary>
        /// Bank International Code.
        /// </summary>
        public string BankInternationalCode { get; set; }
        
        /// <summary>
        /// Payment Days.
        /// </summary>
        public int PaymentDays { get; set; }
        
        /// <summary>
        /// Internal Comments.
        /// </summary>
        public string InternalComments { get; set; }
        
        /// <summary>
        /// Phone Number.
        /// </summary>
        public string PhoneNumber { get; set; }
        
        /// <summary>
        /// Fax Number.
        /// </summary>
        public string FaxNumber { get; set; }
        
        /// <summary>
        /// Website URL.
        /// </summary>
        public string WebsiteUrl { get; set; }
        
        /// <summary>
        /// Delivery Address Line 1.
        /// </summary>
        public string DeliveryAddressLine1 { get; set; }
        
        /// <summary>
        /// Delivery Address line 2.
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
        /// Associated Supplier Category.
        /// </summary>
        public SupplierCategory SupplierCategory { get; set; }
        
        /// <summary>
        /// Associated Purchase Orders.
        /// </summary>
        public ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        
        /// <summary>
        /// Associated Stock Item Transactions.
        /// </summary>
        public ICollection<StockItemTransaction> StockItemTransactions { get; set; }
        
        /// <summary>
        /// Associated Stock Items.
        /// </summary>
        public ICollection<StockItem> StockItems { get; set; }
        
        /// <summary>
        /// Associated Supplier Transactions.
        /// </summary>
        public ICollection<SupplierTransaction> SupplierTransactions { get; set; }
    }
}
