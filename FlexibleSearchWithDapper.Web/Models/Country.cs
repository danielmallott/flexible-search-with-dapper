using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// Country Entity.
    /// </summary>
    [Table("Application.Countries")]
    public class Country
    {
        /// <summary>
        /// Instantiates a new <see cref="Country"/>.
        /// </summary>
        public Country()
        {
            StateProvinces = new HashSet<StateProvince>();
        }

        /// <summary>
        /// Country Id. Primary Key of this entity.
        /// </summary>
        [Key]
        public int CountryId { get; set; }
        
        /// <summary>
        /// Country Name.
        /// </summary>
        public string CountryName { get; set; }
        
        /// <summary>
        /// Formal Name.
        /// </summary>
        public string FormalName { get; set; }
        
        /// <summary>
        /// ISO Alpha 3 Code.
        /// </summary>
        public string IsoAlpha3Code { get; set; }
        
        /// <summary>
        /// ISO Numeric Code.
        /// </summary>
        public int? IsoNumericCode { get; set; }
        
        /// <summary>
        /// Country Type.
        /// </summary>
        public string CountryType { get; set; }
        
        /// <summary>
        /// Latest Recorded Population.
        /// </summary>
        public long? LatestRecordedPopulation { get; set; }
        
        /// <summary>
        /// Continent.
        /// </summary>
        public string Continent { get; set; }
        
        /// <summary>
        /// Region.
        /// </summary>
        public string Region { get; set; }
        
        /// <summary>
        /// Subregion.
        /// </summary>
        public string Subregion { get; set; }
        
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
        /// Associated State Provinces.
        /// </summary>
        public ICollection<StateProvince> StateProvinces { get; set; }
    }
}
