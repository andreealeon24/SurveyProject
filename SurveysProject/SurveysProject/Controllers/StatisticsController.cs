using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SurveysProject.Services.Interfaces;
using SurveysProject.Models;
using SurveysProject.Models.ViewModels;

namespace SurveysProject.Controllers
{
    public class StatisticsController : Controller
    {

        private ISurveyService surveyService;

        private IStatisticsService statisticsService;

        private IQuestionService questionService;

        public StatisticsController(ISurveyService surveyService, IQuestionService questionService, IStatisticsService statisticsService)
        {
            this.surveyService = surveyService;
            this.statisticsService = statisticsService;
            this.questionService = questionService;
        }
        public IActionResult Index()
        {
            List<Survey> surveys = surveyService.GetSurveys();
            return View(surveys);
        }

        public IActionResult Results()
        {
            return View();
        }


        public ActionResult ShowResults(int surveyId)
        {
            StatisticsModel model = new StatisticsModel();
            model.Survey = surveyService.GetSurvey(surveyId);
            model.NumberOfResponses = statisticsService.GetNumerOfResponsesBySurvey(surveyId);

            model.Questions = questionService.GetQuestionsForSurvey(surveyId);
            foreach(var question in model.Questions)
            {
                question.Options = questionService.GetOptionsForQuestion(question.QuestionId);
            }
            //numar de raspunsuri ptr fiecare optiune
            return View("Views/Statistics/Results.cshtml", model);
        }

    }
}
