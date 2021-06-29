using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SurveysProject.Services.Interfaces;
using SurveysProject.Models.Data;
using System.Linq;
using SurveysProject.Models.ViewModels;
using SurveysProject.Models;

namespace SurveysProject.Controllers
{
    public class CompleteSurvey : Controller
    {

        private ISurveyService surveyService;

        private IQuestionService questionService;

        private IResponseService responseService;


        public CompleteSurvey(ISurveyService surveyService, IQuestionService questionService, IResponseService responseService)
        {
            this.surveyService = surveyService;
            this.questionService = questionService;
            this.responseService = responseService;
        }

        public IActionResult CompleteSurveyPage()
        {
            List<Survey> surveys = surveyService.GetSurveysByCreateFor("Teacher");
            return View(surveys);
        }

        public IActionResult CompletedSuccessfully()
        {
            return View();
        }

        public IActionResult Index(int surveyId)
        {
            Survey survey = surveyService.GetSurvey(surveyId);
            if (questionService.GetCountQuestion(surveyId) > 0)
            {

                List<Question> questions = questionService.GetQuestionsForSurvey(surveyId).Take(1).ToList();
                survey.Questions = new List<Question>();
                foreach (Question question in questions)
                {
                    List<QuestionOption> options = questionService.GetOptionsForQuestion(question.QuestionId);
                    question.Options = new List<QuestionOption>();
                    question.Options.AddRange(options);
                    survey.Questions.Add(question);
                }
                ResponseQuestion respQ = new ResponseQuestion()
                {
                    Survey = survey,
                    Question = questions[0],
                };

                ViewBag.page = 0;
                return View("Views/CompleteSurvey/Index.cshtml", respQ);
            }
            else
            {
                return View("Views/Home/Index.cshtml");
            }
        }

        public ActionResult AddResponse(int surveyId, int page, ResponseQuestion response)
        {
            if (response.SelectedOptionId == 0)
            {
                Survey survey = surveyService.GetSurvey(surveyId);

                List<Question> surveyQuestions = questionService.GetQuestionsForSurvey(surveyId).Skip(page).Take(1).ToList();

                survey.Questions = new List<Question>();
                foreach (Question question in surveyQuestions)
                {
                    List<QuestionOption> options = questionService.GetOptionsForQuestion(question.QuestionId);
                    question.Options = new List<QuestionOption>();
                    question.Options.AddRange(options);
                    survey.Questions.Add(question);
                }

                ResponseQuestion resp = new ResponseQuestion()
                {
                    Survey = survey,
                    Question = surveyQuestions[0],
                };
                ViewBag.errorComplete = "Select an option!";
                response.Survey = survey;
                ViewBag.page = page;
                return View("Views/CompleteSurvey/Index.cshtml", resp);
            }

            QuestionOption questionOption = questionService.GetOptionById(response.SelectedOptionId);
            Response responseQuestion = new Response();
            responseQuestion.Survey = surveyService.GetSurvey(surveyId);
            responseQuestion.QuestionOption = questionOption;
            responseQuestion.Question = questionOption.Question;
            responseService.AddResponse(responseQuestion);

            page++;
            ViewBag.page = page;

            List<Question> questions = questionService.GetQuestionsForSurvey(surveyId).Skip(page).Take(1).ToList();

            responseQuestion.Survey.Questions = new List<Question>();
            foreach (Question question in questions)
            {
                List<QuestionOption> options = questionService.GetOptionsForQuestion(question.QuestionId);
                question.Options = new List<QuestionOption>();
                question.Options.AddRange(options);
                responseQuestion.Survey.Questions.Add(question);
            }

            if (questions.Count <= 0)
            {
                List<Survey> surveys = surveyService.GetSurveys();
                return View("Views/CompleteSurvey/CompletedSuccessfully.cshtml", surveys);
            }
            ResponseQuestion respQ = new ResponseQuestion()
            {
                Survey = responseQuestion.Survey,
                Question = questions[0],
            };

            return View("Views/CompleteSurvey/Index.cshtml", respQ);
            
        }
    }
}
