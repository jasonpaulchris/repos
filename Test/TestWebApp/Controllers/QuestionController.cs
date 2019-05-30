using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using TestWebApp.Data;
using TestWebApp.ViewModels;

namespace TestWebApp.Controllers
{
    [Route("api/[controller]")]
    public class QuestionController : Controller
    {
        private ApplicationDbContext DbContext;

        public QuestionController(ApplicationDbContext context)
        {
            DbContext = context;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var question = DbContext.Questions.Where(i => i.id == id)
                .FirstorDefault();

            if (question == null)
            {
                return NotFound(new
                {
                    Error = String.Format("Question id {0} has not been found", id)
                });
            }

            return new JsonResult(
                question.Adapt<QuestionViewModel>(),
                new JsonSerializerSettings()
                {
                    Formatting = Formatting.Indented
                });
        }



        [HttpGet("All/{quizId}")]
        public IActionResult All(int quizId)
        {
            var sampleQuestions = new List<QuestionViewModel>();

            sampleQuestions.Add(new QuestionViewModel()
            {
                Id = 1,
                QuizId = quizId,
                Text = "What do you value most in your life?",
                CreatedDate = DateTime.Now,
                LastModifiedDate = DateTime.Now
            });

            for (int i = 2; i <= 5; i++)
            {
                sampleQuestions.Add(new QuestionViewModel()
                {
                    Id = 1,
                    QuizId = quizId,
                    Text = String.Format("Sample Question {0}", i),
                    CreatedDate = DateTime.Now,
                    LastModifiedDate = DateTime.Now

                });
            }

            return new JsonResult(
                sampleQuestions,
                new JsonSerializerSettings()
                {
                    Formatting = Formatting.Indented
                });
        }
    }
}