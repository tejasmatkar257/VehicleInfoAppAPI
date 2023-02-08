using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vehicle_Info_APP.Models;
using Vehicle_Info_APP.Services;

namespace Vehicle_Info_APP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private VehicleService _VehicleService;

        public VehicleController(VehicleService vehicleService)
        {
            _VehicleService = vehicleService;
        }

        [HttpGet("GetVehicle")]
        public IActionResult GetVehicle(int Id)
        {
            return Ok(_VehicleService.GetVehicle(Id));
        }

        [HttpGet("GetAllVehicle")]

        public IActionResult GetAllVehicle()
        {
            return Ok(_VehicleService.GetAllVehicle());
        }

        [HttpPost("SaveVehicle")]

        public IActionResult SaveVehicle(Vehicle vehicle)
        {
            return Ok(_VehicleService.SaveVehicle(vehicle));
        }

        [HttpPut("UpdateVehicle")]

        public IActionResult UpdateVehicle(Vehicle vehicle)
        {
            return Ok(_VehicleService.UpdateVehicle(vehicle));
        }

        [HttpDelete("DeleteVehicle")]

        public IActionResult DeleteVehicle(int id)
        {
            return Ok(_VehicleService.DeleteVehicle(id));
        }
    }
}
