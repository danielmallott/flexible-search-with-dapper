using System;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// System Parameter Entity.
    /// </summary>
    [Table("Application.SystemParameters")]
    public class SystemParameter
    {
        /// <summary>
        /// System Parameter Id. Primary Key of this entity.
        /// </summary>
        [Key]
        public int SystemParameterId { get; set; }
        
        /// <summary>
        /// Delivery Address Line 1.
        /// </summary>
        public string DeliveryAddressLine1 { get; set; }
        
        /// <summary>
        /// Delivery Address Line 2.
        /// </summary>
        public string DeliveryAddressLine2 { get; set; }
        
        /// <summary>
        /// Delivery City Id.
        /// </summary>
        public int DeliveryCityId { get; set; }
        
        /// <summary>
        /// Delivery Postal Code.
        /// </summary>
        public string DeliveryPostalCode { get; set; }
        
        /// <summary>
        /// Postal Address Line 1.
        /// </summary>
        public string PostalAddressLine1 { get; set; }
        
        /// <summary>
        /// Postal Address Line 2.
        /// </summary>
        public string PostalAddressLine2 { get; set; }
        
        /// <summary>
        /// Postal City Id.
        /// </summary>
        public int PostalCityId { get; set; }
        
        /// <summary>
        /// Postal Postal Code.
        /// </summary>
        public string PostalPostalCode { get; set; }
        
        /// <summary>
        /// Application Settings.
        /// </summary>
        public string ApplicationSettings { get; set; }
        
        /// <summary>
        /// Last Edited By.
        /// </summary>
        public int LastEditedBy { get; set; }
        
        /// <summary>
        /// Last Edited When.
        /// </summary>
        public DateTime LastEditedWhen { get; set; }

        /// <summary>
        /// Associated Delivery City.
        /// </summary>
        public City DeliveryCity { get; set; }
        
        /// <summary>
        /// Last Edited By Navigation.
        /// </summary>
        public Person LastEditedByNavigation { get; set; }
        
        /// <summary>
        /// Associated Postal City.
        /// </summary>
        public City PostalCity { get; set; }
    }
}
