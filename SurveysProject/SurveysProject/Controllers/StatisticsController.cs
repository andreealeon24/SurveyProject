using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SurveysProject.Models;
using SurveysProject.Services.Interfaces;

namespace SurveysProject.Controllers
{
    public class StatisticsController : Controller
    {

        private ISurveyService surveyService;
        public StatisticsController(ISurveyService surveyService)
        {
            this.surveyService = surveyService;
        }
        public IActionResult Index()
        {
            List<Survey> surveys = surveyService.GetSurveys();
            return View(surveys);
        }
    }
}
