using SurveysProject.Models;
using SurveysProject.Models.Data;
using SurveysProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveysProject.Services
{
    public class UserService:IUserService
    {
        private ISurveyService surveyService;
        private MyContext context;

        public UserService(MyContext context, ISurveyService surveyService)
        {
            this.context = context;
            this.surveyService = surveyService;
        }

        public int AddUser(User user)
        {
            context.User.Add(user);
            context.SaveChanges();
            return user.Id;
        }

        public int DeleteUser(User user)
        {
            if (surveyService.GetCountSurveysByUserId(user.Id) != 0)
            {
                List<Survey> surveys = new List<Survey>();
                surveys = surveyService.GetSurveysByUserId(user.Id);
                foreach (var survey in surveys)
                {
                    surveyService.DeleteSurvey(survey);
                }
            }
            context.User.Remove(user);
            context.SaveChanges();
            return 0;
        }

        public User GetUser(string email, string password)
        {
            return context.User.Where(x => x.Email == email && x.Password == password).FirstOrDefault();
        }

        public List<User> GetUsers()
        {
            return context.User.ToList();
        }

        public User GetUserById(int id)
        {
            return context.User.Where(x => x.Id==id).FirstOrDefault();
        }

    }
}
