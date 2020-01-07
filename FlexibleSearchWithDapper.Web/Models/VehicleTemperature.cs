using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace FlexibleSearchWithDapper.Web.Models
{
    [Table("Warehouse.VehicleTemperatures")]
    public class VehicleTemperature
    {
        [Key]
        public long VehicleTemperatureId { get; set; }
        public string VehicleRegistration { get; set; }
        public int ChillerSensorNumber { get; set; }
        public DateTime RecordedWhen { get; set; }
        public decimal Temperature { get; set; }
        public string FullSensorData { get; set; }
        public bool IsCompressed { get; set; }
        public byte[] CompressedSensorData { get; set; }
    }
}
