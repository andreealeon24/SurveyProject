using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SurveysProject.Models.Data;
using SurveysProject.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using SurveysProject.Models;
using System.Web;

namespace SurveysProject.Controllers
{
    public class LoginController : Controller
    {
        private IUserService userService;
        private ISurveyService surveyService;
        public LoginController(IUserService userService, ISurveyService surveyService)
        {
            this.userService = userService;
            this.surveyService = surveyService;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(User user)
        {
            User user2 = new User();
            user2 = userService.GetUser(user.Email, user.Password);
            
            if (user2 != null)
            {
                HttpContext.Session.SetInt32( "Id", user2.Id);
                HttpContext.Session.SetString("Name", user2.Name);
                HttpContext.Session.SetString("Role", user2.Role);

                if (user2.Role == "Admin")
                {
                    List<Survey> surveys = new List<Survey>();
                    surveys = surveyService.GetSurveys();
                    return View("Views/Home/Index.cshtml", surveys);

                }
                else if (user2.Role == "Teacher")
                {
                    List<Survey> surveys = new List<Survey>();
                    surveys = surveyService.GetSurveysByUserId(user2.Id);
                    return View("Views/Home/Index.cshtml", surveys);

                }
                else
                {
                    List<Survey> surveys = new List<Survey>();
                    surveys = surveyService.GetSurveysByCreateFor(user2.Role);
                    return View("Views/Home/Index.cshtml", surveys);
                }
            }
            else
            {
                ModelState.Clear();
                ViewBag.error = "Email or password is incorrect!";
                return View("Views/Login/Index.cshtml");
            }
                 
        }
        public IActionResult Logout()
        {
            HttpContext.Session.SetString("Name", "");
            HttpContext.Session.SetString("Role", "");
            HttpContext.Session.SetInt32("Id", 0);

            return View("Views/Login/Index.cshtml");
        }
    }
}
