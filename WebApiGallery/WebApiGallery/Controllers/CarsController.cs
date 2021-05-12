using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiGallery.Entities;
using WebApiGallery.Entities.Data;
using WebApiGallery.Models;

namespace WebApiGallery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly EFDataContext _context;

        public CarsController(EFDataContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("search")]
        public IActionResult SearchCars()
        {
            var list = _context.Cars.ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddCar([FromBody] Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
            return Ok(new { message = "Додано" });
        }

        [HttpPut("{id}")]
        //[Route("update")]
        public IActionResult UpdateCar([FromRoute] int id, [FromBody] Car car)
        {

            var cars = _context.Cars.SingleOrDefault(x => x.Id == id);

            if (cars == null)
                return BadRequest(new { invalid = "Такої машини немає!" });

            cars.Mark = car.Mark;
            cars.Model = car.Model;
            cars.Year = car.Year;
            cars.Fuel = car.Fuel;
            cars.Сapacity = car.Сapacity;
            

            _context.Update(cars);
            
            _context.SaveChanges();
            return Ok(cars);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCar([FromRoute] int id)
        {


            var cars = _context.Cars.SingleOrDefault(x => x.Id == id);
            if (cars == null)
            {
                return BadRequest(new { invalid = "Такої машини немає!" });
            }

            _context.Remove(cars);
            _context.SaveChanges();

            return Ok(cars.Id);
        }
    } 
}