using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// City entity.
    /// </summary>
    [Table("Application.Cities")]
    public class City
    {
        /// <summary>
        /// Instantiates a new <see cref="City"/>.
        /// </summary>
        public City()
        {
            CustomersDeliveryCity = new HashSet<Customer>();
            CustomersPostalCity = new HashSet<Customer>();
            SuppliersDeliveryCity = new HashSet<Supplier>();
            SuppliersPostalCity = new HashSet<Supplier>();
            SystemParametersDeliveryCity = new HashSet<SystemParameter>();
            SystemParametersPostalCity = new HashSet<SystemParameter>();
        }

        /// <summary>
        /// City Id. Primary Key for this entity.
        /// </summary>
        [Key]
        public int CityId { get; set; }
        
        /// <summary>
        /// City Name.
        /// </summary>
        public string CityName { get; set; }
        
        /// <summary>
        /// State Province Id.
        /// </summary>
        public int StateProvinceId { get; set; }
        
        /// <summary>
        /// Latest Recorded Population.
        /// </summary>
        public long? LatestRecordedPopulation { get; set; }
        
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
        /// Associated State Province.
        /// </summary>
        public StateProvince StateProvince { get; set; }
        
        /// <summary>
        /// Associated Customer Delivery Cities.
        /// </summary>
        public ICollection<Customer> CustomersDeliveryCity { get; set; }
        
        /// <summary>
        /// Associated Customer Postal Cities.
        /// </summary>
        public ICollection<Customer> CustomersPostalCity { get; set; }
        
        /// <summary>
        /// Associated Supplier Delivery Cities.
        /// </summary>
        public ICollection<Supplier> SuppliersDeliveryCity { get; set; }
        
        /// <summary>
        /// Associated Supplier Postal Cities.
        /// </summary>
        public ICollection<Supplier> SuppliersPostalCity { get; set; }
        
        /// <summary>
        /// Associated System Parameter Delivery Cities.
        /// </summary>
        public ICollection<SystemParameter> SystemParametersDeliveryCity { get; set; }
        
        /// <summary>
        /// Associated System Parameter Postal Cities.
        /// </summary>
        public ICollection<SystemParameter> SystemParametersPostalCity { get; set; }
    }
}
