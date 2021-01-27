using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveysProject.Controllers
{
    public class CompleteSurvey : Controller
    {
        public IActionResult Index()
        {
            ViewBag.MyQuestion = "Question";
            ViewBag.MyResponse1 = "Response 1";
            ViewBag.MyResponse2 = "Response 2";
            ViewBag.MyResponse3 = "Response 3";
            return View();
        }
    }
}
