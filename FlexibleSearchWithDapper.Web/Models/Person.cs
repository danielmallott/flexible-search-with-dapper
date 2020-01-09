using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// Person Entity.
    /// </summary>
    [Table("Application.People")]
    public class Person
    {
        /// <summary>
        /// Instantiates a new <see cref="Person"/>.
        /// </summary>
        public Person()
        {
            BuyingGroups = new HashSet<BuyingGroup>();
            Cities = new HashSet<City>();
            Colors = new HashSet<Color>();
            Countries = new HashSet<Country>();
            CustomerCategories = new HashSet<CustomerCategory>();
            CustomerTransactions = new HashSet<CustomerTransaction>();
            CustomersAlternateContactPerson = new HashSet<Customer>();
            CustomersLastEditedByNavigation = new HashSet<Customer>();
            CustomersPrimaryContactPerson = new HashSet<Customer>();
            DeliveryMethods = new HashSet<DeliveryMethod>();
            InverseLastEditedByNavigation = new HashSet<Person>();
            InvoiceLines = new HashSet<InvoiceLine>();
            InvoicesAccountsPerson = new HashSet<Invoice>();
            InvoicesContactPerson = new HashSet<Invoice>();
            InvoicesLastEditedByNavigation = new HashSet<Invoice>();
            InvoicesPackedByPerson = new HashSet<Invoice>();
            InvoicesSalespersonPerson = new HashSet<Invoice>();
            OrderLines = new HashSet<OrderLine>();
            OrdersContactPerson = new HashSet<Order>();
            OrdersLastEditedByNavigation = new HashSet<Order>();
            OrdersPickedByPerson = new HashSet<Order>();
            OrdersSalespersonPerson = new HashSet<Order>();
            PackageTypes = new HashSet<PackageType>();
            PaymentMethods = new HashSet<PaymentMethod>();
            PurchaseOrderLines = new HashSet<PurchaseOrderLine>();
            PurchaseOrdersContactPerson = new HashSet<PurchaseOrder>();
            PurchaseOrdersLastEditedByNavigation = new HashSet<PurchaseOrder>();
            SpecialDeals = new HashSet<SpecialDeal>();
            StateProvinces = new HashSet<StateProvince>();
            StockGroups = new HashSet<StockGroup>();
            StockItemHoldings = new HashSet<StockItemHolding>();
            StockItemStockGroups = new HashSet<StockItemStockGroup>();
            StockItemTransactions = new HashSet<StockItemTransaction>();
            StockItems = new HashSet<StockItem>();
            SupplierCategories = new HashSet<SupplierCategory>();
            SupplierTransactions = new HashSet<SupplierTransaction>();
            SuppliersAlternateContactPerson = new HashSet<Supplier>();
            SuppliersLastEditedByNavigation = new HashSet<Supplier>();
            SuppliersPrimaryContactPerson = new HashSet<Supplier>();
            SystemParameters = new HashSet<SystemParameter>();
            TransactionTypes = new HashSet<TransactionType>();
        }

        /// <summary>
        /// Person Id. Primary Key for this entity.
        /// </summary>
        [Key]
        public int PersonId { get; set; }
        
        /// <summary>
        /// Full Name.
        /// </summary>
        public string FullName { get; set; }
        
        /// <summary>
        /// Preferred Name.
        /// </summary>
        public string PreferredName { get; set; }
        
        /// <summary>
        /// Search Name.
        /// </summary>
        public string SearchName { get; set; }
        
        /// <summary>
        /// Is Permitted to Logon.
        /// </summary>
        public bool IsPermittedToLogon { get; set; }
        
        /// <summary>
        /// Logon Name.
        /// </summary>
        public string LogonName { get; set; }
        
        /// <summary>
        /// Is External Logon Provider.
        /// </summary>
        public bool IsExternalLogonProvider { get; set; }
        
        /// <summary>
        /// Hashed Password.
        /// </summary>
        public byte[] HashedPassword { get; set; }
        
        /// <summary>
        /// Is System User.
        /// </summary>
        public bool IsSystemUser { get; set; }
        
        /// <summary>
        /// Is Employee.
        /// </summary>
        public bool IsEmployee { get; set; }
        
        /// <summary>
        /// Is Salesperson.
        /// </summary>
        public bool IsSalesperson { get; set; }
        
        /// <summary>
        /// User Preferences.
        /// </summary>
        public string UserPreferences { get; set; }
        
        /// <summary>
        /// Phone Number.
        /// </summary>
        public string PhoneNumber { get; set; }
        
        /// <summary>
        /// Fax Number.
        /// </summary>
        public string FaxNumber { get; set; }
        
        /// <summary>
        /// Email Address.
        /// </summary>
        public string EmailAddress { get; set; }
        
        /// <summary>
        /// Photo.
        /// </summary>
        public byte[] Photo { get; set; }
        
        /// <summary>
        /// Custom Fields.
        /// </summary>
        public string CustomFields { get; set; }
        
        /// <summary>
        /// Other Languages.
        /// </summary>
        public string OtherLanguages { get; set; }
        
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
        /// Last Edited By Navigation.
        /// </summary>
        public Person LastEditedByNavigation { get; set; }
        
        /// <summary>
        /// Associated Buying Groups.
        /// </summary>
        public ICollection<BuyingGroup> BuyingGroups { get; set; }
        
        /// <summary>
        /// Associated Cities.
        /// </summary>
        public ICollection<City> Cities { get; set; }
        
        /// <summary>
        /// Associated Colors.
        /// </summary>
        public ICollection<Color> Colors { get; set; }
        
        /// <summary>
        /// Associated Countries.
        /// </summary>
        public ICollection<Country> Countries { get; set; }
        
        /// <summary>
        /// Associated Customer Categories.
        /// </summary>
        public ICollection<CustomerCategory> CustomerCategories { get; set; }
        
        /// <summary>
        /// Associated Customer Transactions.
        /// </summary>
        public ICollection<CustomerTransaction> CustomerTransactions { get; set; }
        
        /// <summary>
        /// Associated Customers Alternate Contact Person.
        /// </summary>
        public ICollection<Customer> CustomersAlternateContactPerson { get; set; }
        
        /// <summary>
        /// Customers Last Edited By Navigation.
        /// </summary>
        public ICollection<Customer> CustomersLastEditedByNavigation { get; set; }
        
        /// <summary>
        /// Associated Customers Primary Contact Person.
        /// </summary>
        public ICollection<Customer> CustomersPrimaryContactPerson { get; set; }
        
        /// <summary>
        /// Associated Delivery Methods.
        /// </summary>
        public ICollection<DeliveryMethod> DeliveryMethods { get; set; }
        
        /// <summary>
        /// Inverse Last Edited By Navigation.
        /// </summary>
        public ICollection<Person> InverseLastEditedByNavigation { get; set; }
        
        /// <summary>
        /// Associated Invoice Lines.
        /// </summary>
        public ICollection<InvoiceLine> InvoiceLines { get; set; }
        
        /// <summary>
        /// Associated Invoice Accounts.
        /// </summary>
        public ICollection<Invoice> InvoicesAccountsPerson { get; set; }
        
        /// <summary>
        /// Associated Invoice Contact Person.
        /// </summary>
        public ICollection<Invoice> InvoicesContactPerson { get; set; }
        
        /// <summary>
        /// Associated Invoices Last Edited By.
        /// </summary>
        public ICollection<Invoice> InvoicesLastEditedByNavigation { get; set; }
        
        /// <summary>
        /// Associated Invoices Packed By Person.
        /// </summary>
        public ICollection<Invoice> InvoicesPackedByPerson { get; set; }
        
        /// <summary>
        /// Associated Invoices Salesperson Person.
        /// </summary>
        public ICollection<Invoice> InvoicesSalespersonPerson { get; set; }
        
        /// <summary>
        /// Associated Order Lines.
        /// </summary>
        public ICollection<OrderLine> OrderLines { get; set; }
        
        /// <summary>
        /// Associated Orders Contact Person.
        /// </summary>
        public ICollection<Order> OrdersContactPerson { get; set; }
        
        /// <summary>
        /// Associated Orders Lasted Edited By Navigation.
        /// </summary>
        public ICollection<Order> OrdersLastEditedByNavigation { get; set; }
        
        /// <summary>
        /// Associated Orders Picked By Person.
        /// </summary>
        public ICollection<Order> OrdersPickedByPerson { get; set; }
        
        /// <summary>
        /// Associated Orders Salesperson Person.
        /// </summary>
        public ICollection<Order> OrdersSalespersonPerson { get; set; }
        
        /// <summary>
        /// Associated Package Types.
        /// </summary>
        public ICollection<PackageType> PackageTypes { get; set; }
        
        /// <summary>
        /// Associated Payment Methods.
        /// </summary>
        public ICollection<PaymentMethod> PaymentMethods { get; set; }
        
        /// <summary>
        /// Associated Purchase Order Lines.
        /// </summary>
        public ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; }
        
        /// <summary>
        /// Associated Purchase Orders Contact Person.
        /// </summary>
        public ICollection<PurchaseOrder> PurchaseOrdersContactPerson { get; set; }
        
        /// <summary>
        /// Associated Purchase Orders Lasted Edited By Navigation.
        /// </summary>
        public ICollection<PurchaseOrder> PurchaseOrdersLastEditedByNavigation { get; set; }
        
        /// <summary>
        /// Associated Special Deals.
        /// </summary>
        public ICollection<SpecialDeal> SpecialDeals { get; set; }
        
        /// <summary>
        /// Associated State Provinces.
        /// </summary>
        public ICollection<StateProvince> StateProvinces { get; set; }
        
        /// <summary>
        /// Associated Stock Groups.
        /// </summary>
        public ICollection<StockGroup> StockGroups { get; set; }
        
        /// <summary>
        /// Associated Stock Item Holdings.
        /// </summary>
        public ICollection<StockItemHolding> StockItemHoldings { get; set; }
        
        /// <summary>
        /// Associated Stock Item Stock Groups.
        /// </summary>
        public ICollection<StockItemStockGroup> StockItemStockGroups { get; set; }
        
        /// <summary>
        /// Associated Stock Item Transactions.
        /// </summary>
        public ICollection<StockItemTransaction> StockItemTransactions { get; set; }
        
        /// <summary>
        /// Associated Stock Items.
        /// </summary>
        public ICollection<StockItem> StockItems { get; set; }
        
        /// <summary>
        /// Associated Supplier Categories.
        /// </summary>
        public ICollection<SupplierCategory> SupplierCategories { get; set; }
        
        /// <summary>
        /// Associated Supplier Transactions.
        /// </summary>
        public ICollection<SupplierTransaction> SupplierTransactions { get; set; }
        
        /// <summary>
        /// Associated Suppliers Alternate Contact Person.
        /// </summary>
        public ICollection<Supplier> SuppliersAlternateContactPerson { get; set; }
        
        /// <summary>
        /// Associated Supplers Last Edited By Navigation.
        /// </summary>
        public ICollection<Supplier> SuppliersLastEditedByNavigation { get; set; }
        
        /// <summary>
        /// Associated Suppliers Primary Contact Person.
        /// </summary>
        public ICollection<Supplier> SuppliersPrimaryContactPerson { get; set; }
        
        /// <summary>
        /// Associated System Parameters.
        /// </summary>
        public ICollection<SystemParameter> SystemParameters { get; set; }
        
        /// <summary>
        /// Associated Transaction Types.
        /// </summary>
        public ICollection<TransactionType> TransactionTypes { get; set; }
    }
}
