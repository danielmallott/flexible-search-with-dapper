using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    [Table("Purchasing.SupplierCategories")]
    public class SupplierCategory
    {
        public SupplierCategory()
        {
            Suppliers = new HashSet<Supplier>();
        }

        [Key]
        public int SupplierCategoryId { get; set; }
        public string SupplierCategoryName { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public virtual Person LastEditedByNavigation { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}
