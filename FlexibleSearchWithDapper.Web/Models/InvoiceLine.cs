using System;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// Invoice Line Entity.
    /// </summary>
    [Table("Sales.InvoiceLines")]
    public class InvoiceLine
    {
        /// <summary>
        /// Invoice Line Id. Primary Key for this entity.
        /// </summary>
        [Key]
        public int InvoiceLineId { get; set; }
        
        /// <summary>
        /// Invoice Id.
        /// </summary>
        public int InvoiceId { get; set; }
        
        /// <summary>
        /// Stock Item Id.
        /// </summary>
        public int StockItemId { get; set; }
        
        /// <summary>
        /// Description.
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// Package Type Id.
        /// </summary>
        public int PackageTypeId { get; set; }
        
        /// <summary>
        /// Quantity.
        /// </summary>
        public int Quantity { get; set; }
        
        /// <summary>
        /// Unit Price.
        /// </summary>
        public decimal? UnitPrice { get; set; }
        
        /// <summary>
        /// Tax Rate.
        /// </summary>
        public decimal TaxRate { get; set; }
        
        /// <summary>
        /// Tax Amount.
        /// </summary>
        public decimal TaxAmount { get; set; }
        
        /// <summary>
        /// Line Profit.
        /// </summary>
        public decimal LineProfit { get; set; }
        
        /// <summary>
        /// Extended Price.
        /// </summary>
        public decimal ExtendedPrice { get; set; }
        
        /// <summary>
        /// Last Edited By.
        /// </summary>
        public int LastEditedBy { get; set; }
        
        /// <summary>
        /// Last Edited When.
        /// </summary>
        public DateTime LastEditedWhen { get; set; }

        /// <summary>
        /// Associated Invoice.
        /// </summary>
        public Invoice Invoice { get; set; }
        
        /// <summary>
        /// Last Edited By Navigation.
        /// </summary>
        public Person LastEditedByNavigation { get; set; }
        
        /// <summary>
        /// Associated Package Type.
        /// </summary>
        public PackageType PackageType { get; set; }
        
        /// <summary>
        /// Associated Stock Item.
        /// </summary>
        public StockItem StockItem { get; set; }
    }
}
