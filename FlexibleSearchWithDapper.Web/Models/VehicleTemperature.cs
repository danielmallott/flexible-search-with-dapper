using System;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    /// <summary>
    /// Vehicle Temperature Entity.
    /// </summary>
    [Table("Warehouse.VehicleTemperatures")]
    public class VehicleTemperature
    {
        /// <summary>
        /// Vehicle Temperature Id. Primary Key for this entity.
        /// </summary>
        [Key]
        public long VehicleTemperatureId { get; set; }
        
        /// <summary>
        /// Vehicle Registration.
        /// </summary>
        public string VehicleRegistration { get; set; }
        
        /// <summary>
        /// Chiller Sensor Number.
        /// </summary>
        public int ChillerSensorNumber { get; set; }
        
        /// <summary>
        /// Recorded When.
        /// </summary>
        public DateTime RecordedWhen { get; set; }
        
        /// <summary>
        /// Temperature.
        /// </summary>
        public decimal Temperature { get; set; }
        
        /// <summary>
        /// Full Sensor Data.
        /// </summary>
        public string FullSensorData { get; set; }
        
        /// <summary>
        /// Is Compressed.
        /// </summary>
        public bool IsCompressed { get; set; }
        
        /// <summary>
        /// Compressed Sensor Data.
        /// </summary>
        public byte[] CompressedSensorData { get; set; }
    }
}
