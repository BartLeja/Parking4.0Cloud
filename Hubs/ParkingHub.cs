using Microsoft.AspNetCore.SignalR;
using Parking4._0Cloud.Models;
using Parking4._0Cloud.Services;
using System.Threading.Tasks;

namespace Parking4._0Cloud.Hubs
{
    public class ParkingHub : Hub
    {
        private readonly IParkingService _parkingService;

        public ParkingHub(IParkingService parkingService)
        {
            _parkingService = parkingService;
        }
        public async Task SendUpsertParking(Parking parking)
        {
            await _parkingService.UpsertParking(parking);
            await Clients.Others.SendAsync("UpsertParkingMessage", parking);
        }

        public async Task SendChangeParkingSpotStatus(ParkingSpot parkingSpot)
        {
            await _parkingService.ChangeParkingSpotStatus(parkingSpot);
            await Clients.Others.SendAsync("ChangeParkingSpotStatusMessage", parkingSpot);
        }
    }
}
