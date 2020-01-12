
using Microsoft.AspNetCore.Mvc;
using StopBeingJerk.ApplicationLogic.CarManagement;
using StopBeingJerk.Dto.CarManagement;
using System.Threading.Tasks;

namespace StopBeingJerk.Web.Controllers
{
    [Route("api/car")]   
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getCarInfo/{carNumber}")]
        public async Task<ActionResult<CarInfoOutput>> GetCarInfo(string carNumber)
        {
            return Ok(await _carService.GetCarInfo(carNumber));
        }
    }
}