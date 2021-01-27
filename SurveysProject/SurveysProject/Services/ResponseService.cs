using SurveysProject.Models;
using SurveysProject.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveysProject.Services
{
    public class ResponseService
    {
        private MyContext context;

        public int AddResponse(Response response)
        {
            context.Responses.Add(response);
            context.SaveChanges();
            return response.ResponseId;
        }
    }
}
