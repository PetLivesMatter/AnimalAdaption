using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertisementsController : ControllerBase
    {
        private readonly IAdvertisementService _advertisementService;
        private IWebHostEnvironment _env;

        public AdvertisementsController(IAdvertisementService advertisementService, IWebHostEnvironment env)
        {
            _advertisementService = advertisementService;
            _env = env;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _advertisementService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Advertisement advertisement)
        {
            var result = _advertisementService.Add(advertisement);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _advertisementService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpPost("deletebyid")]
        public IActionResult Delete(int id)
        {
            var advertisement = new Advertisement { AdvertisementId = id };

            var result = _advertisementService.Delete(advertisement);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

    }
}

