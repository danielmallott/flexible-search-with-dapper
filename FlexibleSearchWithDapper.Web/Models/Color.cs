using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    [Table("Warehouse.Colors")]
    public class Color
    {
        public Color()
        {
            StockItems = new HashSet<StockItem>();
        }

        [Key]
        public int ColorId { get; set; }
        public string ColorName { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public virtual Person LastEditedByNavigation { get; set; }
        public virtual ICollection<StockItem> StockItems { get; set; }
    }
}
