using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// Delivery Method Entity.
    /// </summary>
    [Table("Application.DeliveryMethods")]
    public class DeliveryMethod
    {
        /// <summary>
        /// Instantiates a new <see cref="DeliveryMethod"/>.
        /// </summary>
        public DeliveryMethod()
        {
            Customers = new HashSet<Customer>();
            Invoices = new HashSet<Invoice>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
            Suppliers = new HashSet<Supplier>();
        }

        /// <summary>
        /// Delivery Method Id. Primary Key for this Entity.
        /// </summary>
        [Key]
        public int DeliveryMethodId { get; set; }
        
        /// <summary>
        /// Delivery Method Name.
        /// </summary>
        public string DeliveryMethodName { get; set; }
        
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
        /// Associated Customers.
        /// </summary>
        public ICollection<Customer> Customers { get; set; }
        
        /// <summary>
        /// Associated Invoices.
        /// </summary>
        public ICollection<Invoice> Invoices { get; set; }
        
        /// <summary>
        /// Associated Purchase Orders.
        /// </summary>
        public ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        
        /// <summary>
        /// Associated Suppliers.
        /// </summary>
        public ICollection<Supplier> Suppliers { get; set; }
    }
}
