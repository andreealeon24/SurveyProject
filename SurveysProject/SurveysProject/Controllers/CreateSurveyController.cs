﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SurveysProject.Models;
using SurveysProject.Models.Data;
using SurveysProject.Models.ViewModels;
using SurveysProject.Services;
using SurveysProject.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.ModelBinding;

namespace SurveysProject.Controllers
{
    public class CreateSurveyController : Controller
    {
        private ISurveyService surveyService;
        private IQuestionService questionService;
        private IResponseService responseService;
        private IUserService userService;
        public CreateSurveyController(ISurveyService surveyService, IQuestionService questionService, IResponseService responseService, IUserService userService)
        {
            this.surveyService = surveyService;
            this.questionService = questionService;
            this.responseService = responseService;
            this.userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreatedSuccessfully(int surveyId, int questionId)
        {
            DataModel model = new DataModel();
            model.Survey = surveyService.GetSurvey(surveyId);
            int  questionsNumber = questionService.GetCountQuestion(surveyId);
            if (questionsNumber <= 0)
            {
                ViewBag.questionsNumber = "The survey must have at least one question!";
                ViewBag.question = 1;
                return View("Views/Question/Index.cshtml", model);
            }
            if (questionId == 0) {
                model.Survey.Questions = questionService.GetQuestionsForSurvey(surveyId);
                int id = model.Survey.Questions[questionsNumber-1].QuestionId;
                if (questionService.GetCountQuestionOptionByQuestionId(id) >= 2)
                {
                    return View();
                }
            }
            if (questionService.GetCountQuestionOptionByQuestionId(questionId)<2)
            {
                model.Question = questionService.GetQuestionById(questionId);
                ViewBag.option = questionService.GetCountQuestionOptionByQuestionId(questionId) + 1;
                ViewBag.question = questionsNumber;
                ViewBag.optionsNumber = "The question must have at least 2 options!";
                return View("Views/Question/QuestionOption.cshtml", model);
            }
            return View();
        }

        public IActionResult DeletedSuccessfully()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddSurvey(Survey survey)
        {
            if (HttpContext.Session.GetString("Role") == "Teacher")
            {
                survey.CreateFor="Student";
            }
            if (survey.Title == null && survey.CreateFor == null)
            {
                ViewBag.errorTitle = "Set a title!";
                ViewBag.errorCreateFor = "set a role to complete this survey!";
                return View("Views/CreateSurvey/Index.cshtml");
            }
            else if(survey.Title==null)
            {

                ViewBag.errorTitle = "Set a title!";
                return View("Views/CreateSurvey/Index.cshtml");
            }
            else if (survey.CreateFor == null)
            {

                ViewBag.errorCreateFor = "Set a role to complete this survey!";
                return View("Views/CreateSurvey/Index.cshtml");
            }

                Survey survey2 = new Survey();
                survey2.Title = survey.Title;
                survey2.CreateFor = survey.CreateFor;
                survey2.User = userService.GetUserById((int)HttpContext.Session.GetInt32("Id"));
                int surveyid = surveyService.AddSurvey(survey2);
                Survey survey3 = surveyService.GetSurvey(surveyid);

                DataModel model = new DataModel();
                model.Survey = survey3;
                ViewBag.question = 1;
                return View("Views/Question/Index.cshtml", model);
            
        }

        public IActionResult DeleteSurvey(int surveyId)
        {
            Survey survey = surveyService.GetSurvey(surveyId);
            surveyService.DeleteSurvey(survey);

            return View("Views/CreateSurvey/DeletedSuccessfully.cshtml");
        }


    }
}
