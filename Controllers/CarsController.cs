using Microsoft.AspNetCore.Mvc;

namespace part2_HW1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly ILogger<CarsController> _logger;

        public CarsController(ILogger<CarsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCarInfo")]

        public IList<Car> Get()
        {
            return Cars.listOfCars;
        }
    }
}