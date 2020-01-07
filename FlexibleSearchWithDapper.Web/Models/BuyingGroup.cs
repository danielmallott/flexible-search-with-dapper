using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    [Table("Sales.BuyingGroups")]
    public class BuyingGroup
    {
        public BuyingGroup()
        {
            Customers = new HashSet<Customer>();
            SpecialDeals = new HashSet<SpecialDeal>();
        }

        [ExplicitKey]
        public int BuyingGroupId { get; set; }
        public string BuyingGroupName { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public virtual Person LastEditedByNavigation { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<SpecialDeal> SpecialDeals { get; set; }
    }
}
