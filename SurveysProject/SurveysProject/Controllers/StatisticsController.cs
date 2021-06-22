using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SurveysProject.Services.Interfaces;
using SurveysProject.Models;
using SurveysProject.Models.ViewModels;
using Microsoft.AspNetCore.Http;

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
            if (HttpContext.Session.GetString("Role") == "Admin")
            {
                List<Survey> surveys = new List<Survey>();
                surveys = surveyService.GetSurveys();
                return View("Views/Statistics/Index.cshtml", surveys);
            }
            else if (HttpContext.Session.GetString("Role") == "Teacher")
            {
                List<Survey> surveys = new List<Survey>();
                surveys = surveyService.GetSurveysByUserId((int)HttpContext.Session.GetInt32("Id"));
                return View("Views/Statistics/Index.cshtml", surveys);
            }
            else
            {
                List<Survey> surveys = new List<Survey>();
                surveys = surveyService.GetSurveysByCreateFor(HttpContext.Session.GetString("Role"));
                return View("Views/Statistics/Index.cshtml", surveys);
            }
        }

        public IActionResult Results()
        {
            return View();
        }


        public IActionResult ViewSurvey(int surveyId)
        {
            StatisticsModel model = new StatisticsModel();
            model.Survey = surveyService.GetSurvey(surveyId);
            model.Questions = questionService.GetQuestionsForSurvey(surveyId);
            foreach(var question in model.Questions)
            {
                question.Options = questionService.GetOptionsForQuestion(question.QuestionId);
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult ShowResults(int surveyId)
        {
            StatisticsModel model = new StatisticsModel();
            model.Survey = surveyService.GetSurvey(surveyId);
            model.NumberOfResponses = statisticsService.GetNumerOfResponsesBySurvey(surveyId);

            model.Questions = questionService.GetQuestionsForSurvey(surveyId);

            model.QuestionStatistics = new List<QuestionStatistics>();
            foreach (var question in model.Questions)
            {
                QuestionStatistics questionStatistics = new QuestionStatistics();
                questionStatistics.Question = question;
                questionStatistics.QuestionOptionModels = new List<QuestionOptionModel>();

                question.Options = questionService.GetOptionsForQuestion(question.QuestionId);

                foreach(var option in question.Options)
                {
                    QuestionOptionModel questionOptionModel = new QuestionOptionModel();
                    questionOptionModel.QuestionOption = option;
                    questionOptionModel.countQuestionOptionSelected = questionService.GetCountQuestionOptionSelectById(option.QuestionOptionId);
                    questionStatistics.QuestionOptionModels.Add(questionOptionModel);

                }

                model.QuestionStatistics.Add(questionStatistics);
            }

            return View("Views/Statistics/Results.cshtml", model);
        }

    }
}
