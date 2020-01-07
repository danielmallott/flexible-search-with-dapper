using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    [Table("Warehouse.StockItemStockGroups")]
    public class StockItemStockGroup
    {
        [Key]
        public int StockItemStockGroupId { get; set; }
        public int StockItemId { get; set; }
        public int StockGroupId { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime LastEditedWhen { get; set; }

        public virtual Person LastEditedByNavigation { get; set; }
        public virtual StockGroup StockGroup { get; set; }
        public virtual StockItem StockItem { get; set; }
    }
}
