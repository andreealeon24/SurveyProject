using Microsoft.AspNetCore.Mvc;
using SurveysProject.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveysProject.Controllers
{
    public class QuestionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult AddQuestion(string questionText, string questionOption1, string questionOption2, string questionOption3)
        {
            Question question = new Question();
            question.QuestionText = questionText;
            AddQuestionOption(questionOption1);
            AddQuestionOption(questionOption2);
            AddQuestionOption(questionOption3);
            return View("Views/Question/Index.cshtml");
        }

        public void AddQuestionOption(string questionOption)
        {
            QuestionOption option = new QuestionOption();
            option.QuestionOptionText = questionOption;
        }

    }
}
