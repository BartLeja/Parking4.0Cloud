using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Parking4._0Cloud.Models;
using Parking4._0Cloud.Services;

namespace Parking4._0Cloud.Controllers
{
    [ApiController]
    [Route("parking/api")]
    public class ParkingController : ControllerBase
    {
        private readonly ILogger<ParkingController> _logger;
        private readonly IParkingService _parkingService;

        public ParkingController(ILogger<ParkingController> logger, 
            IParkingService parkingService)
        {
            _logger = logger;
            _parkingService = parkingService;
        }

        //[HttpPost]
        //[Route("statsuChanged")]
        //public async Task ChangeParkingSpotStatus(ParkingSpot parkingSpot) => await _parkingService.ChangeParkingSpotStatus(parkingSpot);

        //[HttpPost]
        //[Route("upsertParkingSpot")]
        //public async Task ChangeParkingSpotStatus(Parking parking) => await _parkingService.UpsertParking(parking);

        [HttpGet]
        public IEnumerable<Parking> Get() => _parkingService.GetAllParkings();


    }
}
