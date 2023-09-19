using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkeringService.Datastore;
using ParkeringService.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkeringService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingServiceController : ControllerBase
    {
        private readonly IParkingStore parkingStore;

        public ParkingServiceController(IParkingStore parkingStore)
        {
            this.parkingStore = parkingStore;
        }


        [HttpGet]
        public async Task<ActionResult<Parking>> GetParking(string numberplate)
        {
            Parking test = new Parking()
            {
                Numberplate = "ab 12 345",
                Email = "test@test.dk",
                Location = "Odense",
            };
            parkingStore.Save(test);

            return parkingStore.GetParkingList(numberplate);
        }

        //[HttpPost]
    }
}
