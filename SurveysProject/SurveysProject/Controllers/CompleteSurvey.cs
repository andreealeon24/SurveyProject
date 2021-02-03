using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SurveysProject.Models;
using SurveysProject.Services.Interfaces;
using SurveysProject.Models.Data;

namespace SurveysProject.Controllers
{
    public class CompleteSurvey : Controller
    {

        private ISurveyService surveyService;

        private IQuestionService questionService;

        public CompleteSurvey(ISurveyService surveyService, IQuestionService questionService)
        {
            this.surveyService = surveyService;
            this.questionService = questionService;
            
        }
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult GetSurvey(int surveyId)
        {
            Survey survey = surveyService.GetSurvey(surveyId);
            List<Question> questions = questionService.GetQuestionsForSurvey(surveyId);
            survey.Questions = new List<Question>();
            foreach (Question question in questions)
            {
                List<QuestionOption> options = questionService.GetOptionsForQuestion(question.QuestionId);
                question.Options = new List<QuestionOption>();
                question.Options.AddRange(options);
                survey.Questions.Add(question);
            }

            return View("Views/CompleteSurvey/Index.cshtml", survey);

            
        }
    }
}
