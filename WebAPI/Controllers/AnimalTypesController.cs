using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalTypesController : ControllerBase
    {
        private readonly IAnimalTypeService _animalTypeService;

        public AnimalTypesController(IAnimalTypeService animalTypeService)
        {
            _animalTypeService = animalTypeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _animalTypeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(AnimalType animalType)
        {
            var result = _animalTypeService.Add(animalType);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _animalTypeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpPost("deletebyid")]
        public IActionResult Delete(int id)
        {
            var animalType = new AnimalType { AnimalTypeId = id };

            var result = _animalTypeService.Delete(animalType);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
