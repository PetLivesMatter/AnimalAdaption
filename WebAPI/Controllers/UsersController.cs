using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private IWebHostEnvironment _env;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UsersController(IUserService userService, IWebHostEnvironment env, IHttpContextAccessor httpContextAccessor)
        {
            _userService = userService;
            _env = env;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _userService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            var result = _userService.Add(user);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _userService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpPost("deletebyid")]
        public IActionResult Delete(int id)
        {
            var user = new User { Id = id };

            var result = _userService.Delete(user);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPatch("update")]
        public IActionResult Update(User user)
        {
            var envPath = _env.ContentRootPath;
            var dirPath = Path.Combine(envPath, "Users");
            var result = _userService.Update(user, dirPath);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
