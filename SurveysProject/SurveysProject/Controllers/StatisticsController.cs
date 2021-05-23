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
