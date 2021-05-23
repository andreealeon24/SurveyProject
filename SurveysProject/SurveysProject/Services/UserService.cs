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
        private MyContext context;

        public UserService(MyContext context)
        {
            this.context = context;
        }

        public int AddUser(User user)
        {
            context.User.Add(user);
            context.SaveChanges();
            return user.Id;
        }

        public User GetUser(string email, string password)
        {
            return context.User.Where(x => x.Email == email && x.Password == password).FirstOrDefault();
        }

    }
}
