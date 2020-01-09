using System;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// Cold Room Temperature Entity.
    /// </summary>
    [Table("Warehouse.ColdRoomTemperatures")]
    public class ColdRoomTemperature
    {
        /// <summary>
        /// Cold Room Temperature Id. Primary Key for this entity.
        /// </summary>
        [Key]
        public long ColdRoomTemperatureId { get; set; }
        
        /// <summary>
        /// Cold Room Sensor Number.
        /// </summary>
        public int ColdRoomSensorNumber { get; set; }
        
        /// <summary>
        /// Recorded When.
        /// </summary>
        public DateTime RecordedWhen { get; set; }
        
        /// <summary>
        /// Temperature.
        /// </summary>
        public decimal Temperature { get; set; }
        
        /// <summary>
        /// Valid From.
        /// </summary>
        public DateTime ValidFrom { get; set; }
        
        /// <summary>
        /// Valid To.
        /// </summary>
        public DateTime ValidTo { get; set; }
    }
}
