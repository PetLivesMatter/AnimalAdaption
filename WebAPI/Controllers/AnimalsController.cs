using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private readonly IAnimalService _animalService;
        private IWebHostEnvironment _env;

        public AnimalsController(IAnimalService animalService, IWebHostEnvironment env)
        {
            _animalService = animalService;
            _env = env;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            
            var result = _animalService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Animal animal)
        {
            var result = _animalService.Add(animal);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _animalService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpPost("deletebyid")]
        public IActionResult Delete(int id)
        {
            var animal = new Animal { AnimalId = id };

            var result =  _animalService.Delete(animal);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPatch("update")]
        public IActionResult Update(Animal animal)
        {
            var envPath = _env.ContentRootPath;
            var dirPath = Path.Combine(envPath, "Animals");
            var result =  _animalService.Update(animal, dirPath);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }  
}
