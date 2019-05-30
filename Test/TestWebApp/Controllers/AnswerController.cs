using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TestWebApp.ViewModels;

namespace TestWebApp.Controllers
{
    [Route("api/[controller]")]
    public class AnswerController : Controller
    {
        [HttpGet("All/{questionId}")]
        public IActionResult All(int questionId)
        { 
            var sampleAnswers = new List<AnswerViewModel>();

            sampleAnswers.Add(new AnswerViewModel()
            {

                Id = 1,
                QuestionId = questionId,
                Text = "Friends and family",
                CreatedDate = DateTime.Now,
                LastModifiedDate = DateTime.Now
            });

            for (int i = 2; i <= 5; i++)
            {
                sampleAnswers.Add(new AnswerViewModel()
                {
                    QuestionId = questionId,
                    Text = String.Format("Sample Answer {0}", i),
                    CreatedDate = DateTime.Now,
                    LastModifiedDate = DateTime.Now
                });
            }

            return new JsonResult(
                sampleAnswers,
                new JsonSerializerSettings()
                {
                    Formatting = Formatting.Indented
                });
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Content("Not implemented");
        }

        [HttpPut]
        public IActionResult Put(AnswerViewModel m)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult Post(AnswerViewModel m)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }

    }
}