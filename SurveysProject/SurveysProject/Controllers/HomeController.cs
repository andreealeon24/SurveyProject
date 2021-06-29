using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using SurveysProject.Models;
using SurveysProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SurveysProject.Controllers
{
    public class HomeController : Controller
    {
        private ISurveyService surveyService;
        public HomeController(ISurveyService surveyService)
        {
            this.surveyService = surveyService;
        }
        public IActionResult Index()
        {
            List<Survey> surveys = new List<Survey>();
            if (HttpContext.Session.GetString("Role") == "Admin")
            {
                
                surveys = surveyService.GetSurveys();

            }
            else if (HttpContext.Session.GetString("Role") == "Teacher")
            {
                surveys = surveyService.GetSurveysByUserId((int)HttpContext.Session.GetInt32("Id"));
            }
            else
            {
                surveys = surveyService.GetSurveysByCreateFor(HttpContext.Session.GetString("Role"));
            }
            return View(surveys);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
