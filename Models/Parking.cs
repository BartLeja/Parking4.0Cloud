using System.Collections.Generic;

namespace Parking4._0Cloud.Models
{
    public class Parking
    {
        public string ParkingName { get; set; }
        public double[] Coordinates { get; set; }
        public IEnumerable<ParkingSpot> ParkingSpots { get; set; } = new List<ParkingSpot>();
    }
}
