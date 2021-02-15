using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using SurveysProject.Models;
using SurveysProject.Services.Interfaces;
using SurveysProject.Models.Data;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SurveysProject.Models.ViewModels;

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

        public IActionResult Index(int surveyId)
        {
            Survey survey = surveyService.GetSurvey(surveyId);

            // verifica daca survey-ul are intrebari (si optiuni), daca nu, vei avea eroare


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

        public ActionResult AddResponse(int surveyId, int page, ResponseQuestion response)
        {
            Survey survey = surveyService.GetSurvey(surveyId);
            // get option by id (response.SelectedoptionId) si tot ce iti trebuie
            // creeaza response si adauga in bd

            page++;
            ViewBag.page = page;

            List<Question> questions = questionService.GetQuestionsForSurvey(surveyId).Skip(page).Take(1).ToList();

            // daca nu mai sunt alte intrebari
            if (questions.Count <= 0)
            {
                List<Survey> surveys = surveyService.GetSurveys();
                return View("Views/Home/Index.cshtml", surveys);
                // sau poti crea o pagina cu o imagine cu bifa si un mesaj cu The survey was successfully completed!
            }

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

            return View("Views/CompleteSurvey/Index.cshtml", respQ);
        }
    }
}
