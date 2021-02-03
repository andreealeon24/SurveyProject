using Microsoft.AspNetCore.Mvc;
using SurveysProject.Models.Data;
using SurveysProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveysProject.Controllers
{
    public class QuestionController : Controller
    {

        private IQuestionService questionService;
        public QuestionController(IQuestionService questionService)
        {
            this.questionService = questionService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult AddQuestion(string questionText, string questionOption1, string questionOption2, string questionOption3)
        {
            Question question = new Question();
            question.QuestionText = questionText;
            questionService.AddQuestion(question);

            QuestionOption option = new QuestionOption();
            option.QuestionOptionText = questionOption1;
            questionService.AddQuestionOption(option);
            option.QuestionOptionText = questionOption2;
            questionService.AddQuestionOption(option);
            option.QuestionOptionText = questionOption3;
            questionService.AddQuestionOption(option);


            return View("Views/Question/Index.cshtml");
        }


        //id survey, id question

    }
}
