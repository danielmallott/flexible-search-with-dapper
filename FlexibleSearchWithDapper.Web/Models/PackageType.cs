using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// Package Type Entity.
    /// </summary>
    [Table("Warehouse.PackageTypes")]
    public class PackageType
    {
        /// <summary>
        /// Instantiates a new <see cref="PackageType"/>.
        /// </summary>
        public PackageType()
        {
            InvoiceLines = new HashSet<InvoiceLine>();
            OrderLines = new HashSet<OrderLine>();
            PurchaseOrderLines = new HashSet<PurchaseOrderLine>();
            StockItemsOuterPackage = new HashSet<StockItem>();
            StockItemsUnitPackage = new HashSet<StockItem>();
        }

        /// <summary>
        /// Package Type Id. Primary Key of this entity.
        /// </summary>
        [Key]
        public int PackageTypeId { get; set; }
        
        /// <summary>
        /// Package Type Name.
        /// </summary>
        public string PackageTypeName { get; set; }
        
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
        /// Associated Stock Items Outer Packages
        /// </summary>
        public ICollection<StockItem> StockItemsOuterPackage { get; set; }
        
        /// <summary>
        /// Associated Stock Items Unit Packages.
        /// </summary>
        public ICollection<StockItem> StockItemsUnitPackage { get; set; }
    }
}
