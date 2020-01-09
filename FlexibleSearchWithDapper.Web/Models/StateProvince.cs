using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// State Province Entity.
    /// </summary>
    [Table("Application.StateProvinces")]
    public class StateProvince
    {
        /// <summary>
        /// Instantiates a new <see cref="StateProvince"/>
        /// </summary>
        public StateProvince()
        {
            Cities = new HashSet<City>();
        }

        /// <summary>
        /// State Province Id. Primary Key for this entity.
        /// </summary>
        [Key]
        public int StateProvinceId { get; set; }
        
        /// <summary>
        /// State Province Code.
        /// </summary>
        public string StateProvinceCode { get; set; }
        
        /// <summary>
        /// State Province Name.
        /// </summary>
        public string StateProvinceName { get; set; }
        
        /// <summary>
        /// Country Id.
        /// </summary>
        public int CountryId { get; set; }
        
        /// <summary>
        /// Sales Territory.
        /// </summary>
        public string SalesTerritory { get; set; }
        
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
        /// Associated Country.
        /// </summary>
        public Country Country { get; set; }
        
        /// <summary>
        /// Last Edited By Navigation.
        /// </summary>
        public Person LastEditedByNavigation { get; set; }
        
        /// <summary>
        /// Associated Cities.
        /// </summary>
        public ICollection<City> Cities { get; set; }
    }
}
