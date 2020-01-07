using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    [Table("Sales.CustomerCategories")]
    public class CustomerCategory
    {
        public CustomerCategory()
        {
            Customers = new HashSet<Customer>();
            SpecialDeals = new HashSet<SpecialDeal>();
        }

        [Key]
        public int CustomerCategoryId { get; set; }
        public string CustomerCategoryName { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public virtual Person LastEditedByNavigation { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<SpecialDeal> SpecialDeals { get; set; }
    }
}
