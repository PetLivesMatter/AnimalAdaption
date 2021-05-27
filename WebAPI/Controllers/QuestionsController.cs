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
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionService _questionService;
        private IWebHostEnvironment _env;

        public QuestionsController(IQuestionService questionService, IWebHostEnvironment env)
        {
            _questionService = questionService;
            _env = env;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _questionService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Question question)
        {
            var result = _questionService.Add(question);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _questionService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var question = new Question { QuestionId = id };

            var result = _questionService.Delete(question);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPatch("update")]
        public IActionResult Update(Question question)
        {
            var envPath = _env.ContentRootPath;
            var dirPath = Path.Combine(envPath, "Questions");
            var result = _questionService.Update(question, dirPath);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
