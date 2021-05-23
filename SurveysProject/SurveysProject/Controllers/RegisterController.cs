using Microsoft.AspNetCore.Mvc;
using SurveysProject.Models.Data;
using SurveysProject.Services.Interfaces;
using System.Collections.Generic;

namespace SurveysProject.Controllers
{
    public class RegisterController : Controller
    {

        private IUserService userService;
        private ISurveyService surveyService;
        public RegisterController(IUserService userService, ISurveyService surveyService)
        {
            this.userService = userService;
            this.surveyService = surveyService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegisterSuccesfully()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(User user)
        {
            userService.AddUser(user);
            return View("Views/Register/RegisterSuccessfully.cshtml");
        }
    }

   
}
