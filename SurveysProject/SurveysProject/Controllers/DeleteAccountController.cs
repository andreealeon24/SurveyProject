using Microsoft.AspNetCore.Mvc;
using SurveysProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SurveysProject.Models.Data;

namespace SurveysProject.Controllers
{
    public class DeleteAccountController : Controller
    {
        private IUserService userService;
        public DeleteAccountController(IUserService userService)
        {
            this.userService = userService;
        }
        public IActionResult Index()
        {
            return View(userService.GetUsers());
        }

        public IActionResult DeleteAccount(int userId)
        {
            User user = userService.GetUserById(userId);
            userService.DeleteUser(user);
            return View("Views/DeleteAccount/DeletedAccountSuccessfully.cshtml");
        }
    }
}
