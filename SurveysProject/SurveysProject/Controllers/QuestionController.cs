using Microsoft.AspNetCore.Mvc;
using SurveysProject.Models;
using SurveysProject.Models.Data;
using SurveysProject.Models.ViewModels;
using SurveysProject.Services.Interfaces;
using System;

namespace SurveysProject.Controllers
{
    public class QuestionController : Controller
    {

        private IQuestionService questionService;
        private ISurveyService surveyService;
        public QuestionController(IQuestionService questionService, ISurveyService surveyService)
        {
            this.questionService = questionService;
            this.surveyService = surveyService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult QuestionOption()
        {
            return View();
        }

        public IActionResult GetQuestionPage( int id)
        {
            DataModel data = new DataModel();
            data.Survey = surveyService.GetSurvey(id);
            ViewBag.question = questionService.GetCountQuestion(id) + 1;
            return View("Views/Question/Index.cshtml", data);
        }

        [HttpPost]
        public ActionResult AddQuestion(DataModel data)
        {
            if (data.Question.Text == null)
            {
                ViewBag.errorQuestion = "Complete question text!"; 
                data.Survey = surveyService.GetSurvey(data.Survey.Id);
                ViewBag.question = questionService.GetCountQuestion(data.Survey.Id) + 1;
                return View("Views/Question/Index.cshtml", data);

            }
                data.Survey = surveyService.GetSurvey(data.Survey.Id);

                Question question = new Question();
                question.Survey = data.Survey;
                question.Text = data.Question.Text;
                questionService.AddQuestion(question);

                DataModel model = new DataModel();
                model.Question = question;
                model.Survey = data.Survey;
                ViewBag.option = 1;
                ViewBag.question = questionService.GetCountQuestion(model.Survey.Id);
                return View("Views/Question/QuestionOption.cshtml", model);
        }

        public ActionResult AddQuestionOption(DataModel data)
        {   
            data.Survey = surveyService.GetSurvey(data.Survey.Id);
            data.Question = questionService.GetQuestionById(data.Question.QuestionId);

            if (data.QuestionOption.QuestionOptionText == null)
            {
                ViewBag.question = questionService.GetCountQuestion(data.Survey.Id);
                ViewBag.option = questionService.GetCountQuestionOptionByQuestionId(data.Question.QuestionId) + 1;
                ViewBag.errorQuestionOption = "Complete question option text!";
                return View("Views/Question/QuestionOption.cshtml", data);

            }
            
            QuestionOption questionOption = new QuestionOption();
            questionOption.Question = data.Question;
            questionOption.QuestionOptionText = data.QuestionOption.QuestionOptionText;
            questionService.AddQuestionOption(questionOption);

            DataModel model = new DataModel();
            model.Survey= data.Survey;
            model.Question = data.Question;

            ModelState.Clear();

            ViewBag.option = questionService.GetCountQuestionOptionByQuestionId(model.Question.QuestionId) + 1;
            ViewBag.question = questionService.GetCountQuestion(model.Survey.Id);

            return View("Views/Question/QuestionOption.cshtml", model);
        }


    }
}
