using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// Transaction Type Entity.
    /// </summary>
    [Table("Application.TransactionTypes")]
    public class TransactionType
    {
        /// <summary>
        /// Instantiates a new <see cref="TransactionType"/>.
        /// </summary>
        public TransactionType()
        {
            CustomerTransactions = new HashSet<CustomerTransaction>();
            StockItemTransactions = new HashSet<StockItemTransaction>();
            SupplierTransactions = new HashSet<SupplierTransaction>();
        }

        /// <summary>
        /// Transaction Type Id. Primary Key for this entity.
        /// </summary>
        [Key]
        public int TransactionTypeId { get; set; }
        
        /// <summary>
        /// Transaction Type Name.
        /// </summary>
        public string TransactionTypeName { get; set; }
        
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
        /// Associated Stock Item Transactions.
        /// </summary>
        public ICollection<StockItemTransaction> StockItemTransactions { get; set; }
        
        /// <summary>
        /// Associated Supplier Transactions.
        /// </summary>
        public ICollection<SupplierTransaction> SupplierTransactions { get; set; }
    }
}
