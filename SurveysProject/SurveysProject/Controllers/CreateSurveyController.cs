using Microsoft.AspNetCore.Mvc;
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

        public IActionResult CreatedSuccessfully()
        {
            return View();
        }

        public IActionResult DeletedSuccessfully()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddSurvey(Survey survey)
        {
            Survey survey2 = new Survey();
            survey2.Title = survey.Title;
            if (HttpContext.Session.GetString("Role") == "Admin")
            {
                survey2.CreateFor = survey.CreateFor;
            }
            else
            {
                survey2.CreateFor = "Student";
            }
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
