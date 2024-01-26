using Business.Abstract;
using Entities.Concreet;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }


        [HttpGet]
        public IActionResult Get()
        {
         var result= _carService.GetAlll();

         return Ok(result);
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
             var result=_carService.GetById(id);
            return Ok(result);
        }


        [HttpPost]
        public IActionResult Add(Car car)
        {
             _carService.add(car);
             return Ok(true);
          
        }
        [HttpPatch]
        public IActionResult Delete(Car car)
        {
            _carService.delete(car);
            return Ok(true);

        }
        [HttpPut]
        public IActionResult Update(Car car)
        {
            _carService.update(car);
            return Ok(true);

        }
    }
}
