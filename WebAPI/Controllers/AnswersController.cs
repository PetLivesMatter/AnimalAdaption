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
    public class AnswersController : ControllerBase
    {

        [Route("api/[controller]")]
        [ApiController]
        public class AnswersController : Controller
        {
            private readonly IAnswerService _answerService;
            private readonly IHttpContextAccessor _httpContextAccessor;
            private IWebHostEnvironment _env;

            public AnswersController(IAnswerService answerService, IHttpContextAccessor httpContextAccessor, IWebHostEnvironment env)
            {
                _answerService = answerService;
                _httpContextAccessor = httpContextAccessor;
                _env = env;
            }

            [HttpGet("getall")]
            public  Task<IActionResult> GetList()
            {
                var result =  _answerService.GetList();
                if (result.Success)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }
           

            [HttpGet("getbyid")]
            public  Task<IActionResult> GetById(int id)
            {
                var envPath = _env.ContentRootPath;
                var dirPath = Path.Combine(envPath, "images", "Answers");

                var result =  _answerService.GetById(id, dirPath);
                if (result.Success)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }


            [HttpPost("add")]
            public  Task<IActionResult> Add(Answer answer)
            {
                var envPath = _env.ContentRootPath;
                var dirPath = Path.Combine(envPath, "images", "Answers");
                var result =  _answerService.Add(answer, dirPath);
                if (result.Success)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }

            [HttpPatch("update")]
            public  Task<IActionResult> Update(Answer answer)
            {
                var envPath = _env.ContentRootPath;
                var dirPath = Path.Combine(envPath, "images", "Answers");
                var result =  _answerService.Update(answer, dirPath);
                if (result.Success)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }

            [HttpDelete("delete/{id}")]
            public  Task<IActionResult> Delete(int id)
            {
                var answer = new Answer { AnswerId = id };

                var result =  _answerService.Delete(answer);
                if (result.Success)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }
        }
    }
}
