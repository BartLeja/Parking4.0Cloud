using Parking4._0Cloud.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Parking4._0Cloud.Services
{
    public interface IParkingService
    {
        IEnumerable<Parking> GetAllParkings();
        Task ChangeParkingSpotStatus(ParkingSpot parkingSpot);
        Task UpsertParking(Parking parking);
    }
}
