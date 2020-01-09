using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// Color Entity.
    /// </summary>
    [Table("Warehouse.Colors")]
    public class Color
    {
        /// <summary>
        /// Instantiates a new <see cref="Color"/>
        /// </summary>
        public Color()
        {
            StockItems = new HashSet<StockItem>();
        }

        /// <summary>
        /// Color Id. Primary Key for this entity.
        /// </summary>
        [Key]
        public int ColorId { get; set; }
        
        /// <summary>
        /// Color Name.
        /// </summary>
        public string ColorName { get; set; }
        
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
        /// Associated Stock Items.
        /// </summary>
        public ICollection<StockItem> StockItems { get; set; }
    }
}
