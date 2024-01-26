using Business.Abstract;
using Entities.Concreet;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var result = _brandService.GetAll();
            return Ok(result);
        }
        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
           var result= _brandService.GetById(id);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Add(Brand brand)
        {
             _brandService.add(brand);
            return Ok(true);

        }
        [HttpPost]
        public IActionResult Delete(Brand brand) 
        {

            _brandService.Delete(brand);
            return Ok(true);

        }

        [HttpPatch] 
        public IActionResult Update(Brand brand)
        {

            _brandService.update(brand);
            return Ok(true);

        }


    }
}
