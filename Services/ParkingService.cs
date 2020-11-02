using Parking4._0Cloud.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parking4._0Cloud.Services
{
    public class ParkingService : IParkingService
    {
        private List<Parking> _parkings { get; set; }

        public ParkingService()
        {
            _parkings = new List<Parking>();
        }

        public IEnumerable<Parking> GetAllParkings() => _parkings;

        public async Task ChangeParkingSpotStatus(ParkingSpot parkingSpot)
        {
            var parking = _parkings.SelectMany(p => p.ParkingSpots.Where(ps => ps.Id == parkingSpot.Id)).First();
            parking.Status = parkingSpot.Status;
        }

        public async Task UpsertParking(Parking parking)
        {
            if (_parkings.Any(p => p.ParkingName == parking.ParkingName))
            {
                var parkingToReplace = _parkings.First(p => p.ParkingName == parking.ParkingName);
                var index = _parkings.IndexOf(parkingToReplace);

                if (index != -1)
                    _parkings[index] = parking;
            }
            else
            {
                _parkings.Add(parking);
            }
               
        }
    }
}
