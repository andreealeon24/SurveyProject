using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SurveysProject.Models.Data;

namespace SurveysProject.Services.Interfaces
{
    public interface IUserService
    {
        int AddUser(User user);
        int DeleteUser(User user);
        string Encrypt(string password);
        User GetUser(string email, string password);
        List<User> GetUsers();
        User GetUserById(int id);
    }
}
