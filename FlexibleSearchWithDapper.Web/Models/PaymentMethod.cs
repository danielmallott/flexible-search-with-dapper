using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// Payment Method Entity.
    /// </summary>
    [Table("Application.PaymentMethods")]
    public class PaymentMethod
    {
        /// <summary>
        /// Instantiates a new <see cref="PaymentMethod"/>.
        /// </summary>
        public PaymentMethod()
        {
            CustomerTransactions = new HashSet<CustomerTransaction>();
            SupplierTransactions = new HashSet<SupplierTransaction>();
        }

        /// <summary>
        /// Payment Method Id. Primary Key of this entity.
        /// </summary>
        [Key]
        public int PaymentMethodId { get; set; }
        
        /// <summary>
        /// Payment Method Name.
        /// </summary>
        public string PaymentMethodName { get; set; }
        
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
        /// Associated Customer Transactions.
        /// </summary>
        public ICollection<CustomerTransaction> CustomerTransactions { get; set; }
        
        /// <summary>
        /// Supplier Transactions.
        /// </summary>
        public ICollection<SupplierTransaction> SupplierTransactions { get; set; }
    }
}
