using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    [Table("Application.DeliveryMethods")]
    public class DeliveryMethod
    {
        public DeliveryMethod()
        {
            Customers = new HashSet<Customer>();
            Invoices = new HashSet<Invoice>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
            Suppliers = new HashSet<Supplier>();
        }

        [Key]
        public int DeliveryMethodId { get; set; }
        public string DeliveryMethodName { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public virtual Person LastEditedByNavigation { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}
