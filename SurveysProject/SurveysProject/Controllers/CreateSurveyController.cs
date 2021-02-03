using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver.Core.Configuration;
using SurveysProject.Models;
using SurveysProject.Models.Data;
using SurveysProject.Services;
using SurveysProject.Services.Interfaces;
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
        public CreateSurveyController(ISurveyService surveyService)
        {
            this.surveyService = surveyService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateQuestion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSurvey(string title)
        {
            Survey survey2 = new Survey();
            survey2.Title = title;
            int surveyid = surveyService.AddSurvey(survey2);
            Survey survey = surveyService.GetSurvey(surveyid);

            DataModel model = new DataModel();
            model.Survey = survey;
            return View("Views/Question/Index.cshtml", model);
        }

    }
}
