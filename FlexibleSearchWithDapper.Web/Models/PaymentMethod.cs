using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    [Table("Application.PaymentMethods")]
    public class PaymentMethod
    {
        public PaymentMethod()
        {
            CustomerTransactions = new HashSet<CustomerTransaction>();
            SupplierTransactions = new HashSet<SupplierTransaction>();
        }

        [Key]
        public int PaymentMethodId { get; set; }
        public string PaymentMethodName { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public virtual Person LastEditedByNavigation { get; set; }
        public virtual ICollection<CustomerTransaction> CustomerTransactions { get; set; }
        public virtual ICollection<SupplierTransaction> SupplierTransactions { get; set; }
    }
}
