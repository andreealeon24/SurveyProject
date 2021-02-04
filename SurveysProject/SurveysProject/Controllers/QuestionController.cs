using Microsoft.AspNetCore.Mvc;
using SurveysProject.Models.Data;
using SurveysProject.Models;
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

        public ActionResult AddQuestion(Survey survey, string questionText, string questionOption1, string questionOption2, string questionOption3)
        {
            Question question = new Question();
            question.QuestionText = "text";
            question.Survey= survey;
            //???
            questionService.AddQuestion(question);

            QuestionOption option = new QuestionOption();
            option.QuestionOptionText = "1";
            option.Question.QuestionId = question.QuestionId;
            // de 3 ori/ o data
            questionService.AddQuestionOption(option);
            option.QuestionOptionText = "2";
            option.Question.QuestionId = question.QuestionId;
            questionService.AddQuestionOption(option);
            option.QuestionOptionText = "3";
            option.Question.QuestionId = question.QuestionId;
            questionService.AddQuestionOption(option);

            return View("Views/Question/Index.cshtml");
        }



    }
}
