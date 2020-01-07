using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    [Table("Warehouse.PackageTypes")]
    public class PackageType
    {
        public PackageType()
        {
            InvoiceLines = new HashSet<InvoiceLine>();
            OrderLines = new HashSet<OrderLine>();
            PurchaseOrderLines = new HashSet<PurchaseOrderLine>();
            StockItemsOuterPackage = new HashSet<StockItem>();
            StockItemsUnitPackage = new HashSet<StockItem>();
        }

        [Key]
        public int PackageTypeId { get; set; }
        public string PackageTypeName { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public virtual Person LastEditedByNavigation { get; set; }
        public virtual ICollection<InvoiceLine> InvoiceLines { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
        public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; }
        public virtual ICollection<StockItem> StockItemsOuterPackage { get; set; }
        public virtual ICollection<StockItem> StockItemsUnitPackage { get; set; }
    }
}
