using Microsoft.AspNetCore.Mvc;
using ParkingGarage_AlsoEnergy.Models.Vehicle;

namespace ParkingGarage_AlsoEnergy.Controllers
{
    [ApiController]
    [Route("Garage")]
    public class GarageController : ControllerBase
    {
        [HttpGet(Name = "GetGarageStatus")]
        public IEnumerable<Vehicle>[][] Get()
        {
            return new IEnumerable<Vehicle>[][] { };
        }
    }
}
