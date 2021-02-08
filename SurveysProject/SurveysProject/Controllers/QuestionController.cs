using Microsoft.AspNetCore.Mvc;
using SurveysProject.Models.Data;
using SurveysProject.Models;
using SurveysProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

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

        [HttpPost]
        public ActionResult AddQuestion(DataModel data)
        {
            Question question = new Question();
            question.Survey = data.Survey;
            question.Text = data.Question.Text;
            questionService.AddQuestion(question);

            QuestionOption questionOption1 = new QuestionOption();
            questionOption1.Question = question;
            questionOption1.QuestionOptionText = data.QuestionOption1.QuestionOptionText;
            questionService.AddQuestionOption(questionOption1);

            QuestionOption questionOption2 = new QuestionOption();
            questionOption2.Question = question;
            questionOption2.QuestionOptionText = data.QuestionOption2.QuestionOptionText;
            questionService.AddQuestionOption(questionOption2);


            QuestionOption questionOption3 = new QuestionOption();
            questionOption3.Question = question;
            questionOption3.QuestionOptionText = data.QuestionOption3.QuestionOptionText;
            questionService.AddQuestionOption(questionOption3);


            DataModel model = new DataModel();
            model.Survey = data.Survey;

            ModelState.Clear();


            return View("Views/Question/Index.cshtml", model);
        }

}
}
