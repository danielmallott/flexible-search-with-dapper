using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// Order entity.
    /// </summary>
    [Table("Sales.Orders")]
    public class Order
    {
        /// <summary>
        /// Instantiates a new <see cref="Order"/>.
        /// </summary>
        public Order()
        {
            InverseBackorderOrder = new HashSet<Order>();
            Invoices = new HashSet<Invoice>();
            OrderLines = new HashSet<OrderLine>();
        }

        /// <summary>
        /// Order Id. Primary Key of this entity.
        /// </summary>
        [Key]
        public int OrderId { get; set; }
        
        /// <summary>
        /// Customer Id.
        /// </summary>
        public int CustomerId { get; set; }
        
        /// <summary>
        /// Salesperson Person Id.
        /// </summary>
        public int SalespersonPersonId { get; set; }
        
        /// <summary>
        /// Picked By Person Id.
        /// </summary>
        public int? PickedByPersonId { get; set; }
        
        /// <summary>
        /// Contact Person Id.
        /// </summary>
        public int ContactPersonId { get; set; }
        
        /// <summary>
        /// Backorder Order Id.
        /// </summary>
        public int? BackorderOrderId { get; set; }
        
        /// <summary>
        /// Order Date.
        /// </summary>
        public DateTime OrderDate { get; set; }
        
        /// <summary>
        /// Expected Delivery Date.
        /// </summary>
        public DateTime ExpectedDeliveryDate { get; set; }
        
        /// <summary>
        /// Customer Purchase Order Number.
        /// </summary>
        public string CustomerPurchaseOrderNumber { get; set; }
        
        /// <summary>
        /// Is Undersupply Backordered.
        /// </summary>
        public bool IsUndersupplyBackordered { get; set; }
        
        /// <summary>
        /// Comments.
        /// </summary>
        public string Comments { get; set; }
        
        /// <summary>
        /// Delivery Instructions.
        /// </summary>
        public string DeliveryInstructions { get; set; }
        
        /// <summary>
        /// Internal Comments.
        /// </summary>
        public string InternalComments { get; set; }
        
        /// <summary>
        /// Picking Completed When.
        /// </summary>
        public DateTime? PickingCompletedWhen { get; set; }
        
        /// <summary>
        /// Last Edited By.
        /// </summary>
        public int LastEditedBy { get; set; }
        
        /// <summary>
        /// Last Edited When.
        /// </summary>
        public DateTime LastEditedWhen { get; set; }

        /// <summary>
        /// Associated Backorder Order.
        /// </summary>
        public Order BackorderOrder { get; set; }
        
        /// <summary>
        /// Associated Contact Person.
        /// </summary>
        public Person ContactPerson { get; set; }
        
        /// <summary>
        /// Associated Customer.
        /// </summary>
        public Customer Customer { get; set; }
        
        /// <summary>
        /// Associated Last Edited By.
        /// </summary>
        public Person LastEditedByNavigation { get; set; }
        
        /// <summary>
        /// Associated Picked By Person.
        /// </summary>
        public Person PickedByPerson { get; set; }
        
        /// <summary>
        /// Associated Salesperson Person.
        /// </summary>
        public Person SalespersonPerson { get; set; }
        
        /// <summary>
        /// Inverse Backorder Order property.
        /// </summary>
        public ICollection<Order> InverseBackorderOrder { get; set; }
        
        /// <summary>
        /// Associated Invoices.
        /// </summary>
        public ICollection<Invoice> Invoices { get; set; }
        
        /// <summary>
        /// Associated Order Lines.
        /// </summary>
        public ICollection<OrderLine> OrderLines { get; set; }
    }
}
