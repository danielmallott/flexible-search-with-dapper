using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// Stock Item Entity.
    /// </summary>
    [Table("Warehouse.StockItems")]
    public class StockItem
    {
        /// <summary>
        /// Instantiates a new <see cref="StockItem"/>.
        /// </summary>
        public StockItem()
        {
            InvoiceLines = new HashSet<InvoiceLine>();
            OrderLines = new HashSet<OrderLine>();
            PurchaseOrderLines = new HashSet<PurchaseOrderLine>();
            SpecialDeals = new HashSet<SpecialDeal>();
            StockItemStockGroups = new HashSet<StockItemStockGroup>();
            StockItemTransactions = new HashSet<StockItemTransaction>();
        }

        /// <summary>
        /// Stock Item Id. Primary Key for this entity.
        /// </summary>
        [Key]
        public int StockItemId { get; set; }
        
        /// <summary>
        /// Stock Item Name.
        /// </summary>
        public string StockItemName { get; set; }
        
        /// <summary>
        /// Supplier Id.
        /// </summary>
        public int SupplierId { get; set; }
        
        /// <summary>
        /// Color Id.
        /// </summary>
        public int? ColorId { get; set; }
        
        /// <summary>
        /// Unit Package Id.
        /// </summary>
        public int UnitPackageId { get; set; }
        
        /// <summary>
        /// Outer Package Id.
        /// </summary>
        public int OuterPackageId { get; set; }
        
        /// <summary>
        /// Brand.
        /// </summary>
        public string Brand { get; set; }
        
        /// <summary>
        /// Size.
        /// </summary>
        public string Size { get; set; }
        
        /// <summary>
        /// Lead Time Days.
        /// </summary>
        public int LeadTimeDays { get; set; }
        
        /// <summary>
        /// Quantity Per Outer.
        /// </summary>
        public int QuantityPerOuter { get; set; }
        
        /// <summary>
        /// Is Chiller Stock.
        /// </summary>
        public bool IsChillerStock { get; set; }
        
        /// <summary>
        /// Barcode.
        /// </summary>
        public string Barcode { get; set; }
        
        /// <summary>
        /// Tax Rate.
        /// </summary>
        public decimal TaxRate { get; set; }
        
        /// <summary>
        /// Unit Price.
        /// </summary>
        public decimal UnitPrice { get; set; }
        
        /// <summary>
        /// Recommended Retail Price.
        /// </summary>
        public decimal? RecommendedRetailPrice { get; set; }
        
        /// <summary>
        /// Typical Weight Per Unit.
        /// </summary>
        public decimal TypicalWeightPerUnit { get; set; }
        
        /// <summary>
        /// Marketing Comments.
        /// </summary>
        public string MarketingComments { get; set; }
        
        /// <summary>
        /// Internal Comments.
        /// </summary>
        public string InternalComments { get; set; }
        
        /// <summary>
        /// Photo.
        /// </summary>
        public byte[] Photo { get; set; }
        
        /// <summary>
        /// Custom Fields.
        /// </summary>
        public string CustomFields { get; set; }
        
        /// <summary>
        /// Tags.
        /// </summary>
        public string Tags { get; set; }
        
        /// <summary>
        /// Search Details.
        /// </summary>
        public string SearchDetails { get; set; }
        
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
        /// Associated Color.
        /// </summary>
        public Color Color { get; set; }
        
        /// <summary>
        /// Last Edited By Navigation.
        /// </summary>
        public Person LastEditedByNavigation { get; set; }
        
        /// <summary>
        /// Associated Outer Package.
        /// </summary>
        public PackageType OuterPackage { get; set; }
        
        /// <summary>
        /// Associated Supplier
        /// </summary>
        public Supplier Supplier { get; set; }
        
        /// <summary>
        /// Associated Unit Package.
        /// </summary>
        public PackageType UnitPackage { get; set; }
        
        /// <summary>
        /// Associated Stock Item Holding.
        /// </summary>
        public StockItemHolding StockItemHolding { get; set; }
        
        /// <summary>
        /// Associated Invoice Lines.
        /// </summary>
        public ICollection<InvoiceLine> InvoiceLines { get; set; }
        
        /// <summary>
        /// Associated Order Lines.
        /// </summary>
        public ICollection<OrderLine> OrderLines { get; set; }
        
        /// <summary>
        /// Associated Purchase Order Lines.
        /// </summary>
        public ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; }
        
        /// <summary>
        /// Associated Special Deals.
        /// </summary>
        public ICollection<SpecialDeal> SpecialDeals { get; set; }
        
        /// <summary>
        /// Associated Stock Item Stock Groups.
        /// </summary>
        public ICollection<StockItemStockGroup> StockItemStockGroups { get; set; }
        
        /// <summary>
        /// Associated Stock Item Transactions.
        /// </summary>
        public ICollection<StockItemTransaction> StockItemTransactions { get; set; }
    }
}
