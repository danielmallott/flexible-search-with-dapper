using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    [Table("Application.StateProvinces")]
    public class StateProvince
    {
        public StateProvince()
        {
            Cities = new HashSet<City>();
        }

        [Key]
        public int StateProvinceId { get; set; }
        public string StateProvinceCode { get; set; }
        public string StateProvinceName { get; set; }
        public int CountryId { get; set; }
        public string SalesTerritory { get; set; }
        public long? LatestRecordedPopulation { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public virtual Country Country { get; set; }
        public virtual Person LastEditedByNavigation { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}
