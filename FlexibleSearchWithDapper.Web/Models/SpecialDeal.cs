using System;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// Special Deal Entity.
    /// </summary>
    [Table("Sales.SpecialDeals")]
    public class SpecialDeal
    {
        /// <summary>
        /// Special Deal Id. Primary Key for this entity.
        /// </summary>
        [Key]
        public int SpecialDealId { get; set; }
        
        /// <summary>
        /// Stock Item Id.
        /// </summary>
        public int? StockItemId { get; set; }
        
        /// <summary>
        /// Customer Id.
        /// </summary>
        public int? CustomerId { get; set; }
        
        /// <summary>
        /// Buying Group Id.
        /// </summary>
        public int? BuyingGroupId { get; set; }
        
        /// <summary>
        /// Customer Category Id.
        /// </summary>
        public int? CustomerCategoryId { get; set; }
        
        /// <summary>
        /// Stock Group Id.
        /// </summary>
        public int? StockGroupId { get; set; }
        
        /// <summary>
        /// Deal Description.
        /// </summary>
        public string DealDescription { get; set; }
        
        /// <summary>
        /// Start Date.
        /// </summary>
        public DateTime StartDate { get; set; }
        
        /// <summary>
        /// End Date.
        /// </summary>
        public DateTime EndDate { get; set; }
        
        /// <summary>
        /// Discount Amount.
        /// </summary>
        public decimal? DiscountAmount { get; set; }
        
        /// <summary>
        /// Discount Percentage.
        /// </summary>
        public decimal? DiscountPercentage { get; set; }
        
        /// <summary>
        /// Unit Price.
        /// </summary>
        public decimal? UnitPrice { get; set; }
        
        /// <summary>
        /// Last Edited By.
        /// </summary>
        public int LastEditedBy { get; set; }
        
        /// <summary>
        /// Last Edited When.
        /// </summary>
        public DateTime LastEditedWhen { get; set; }

        /// <summary>
        /// Associated Buying Group.
        /// </summary>
        public BuyingGroup BuyingGroup { get; set; }
        
        /// <summary>
        /// Associated Customer.
        /// </summary>
        public Customer Customer { get; set; }
        
        /// <summary>
        /// Associated Customer Category.
        /// </summary>
        public CustomerCategory CustomerCategory { get; set; }
        
        /// <summary>
        /// Last Edited By Navigation.
        /// </summary>
        public Person LastEditedByNavigation { get; set; }
        
        /// <summary>
        /// Associated Stock Group.
        /// </summary>
        public StockGroup StockGroup { get; set; }
        
        /// <summary>
        /// Associated Stock Item.
        /// </summary>
        public StockItem StockItem { get; set; }
    }
}
