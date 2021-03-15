using Microsoft.EntityFrameworkCore;
using SurveysProject.Models;
using SurveysProject.Models.Data;
using SurveysProject.Services.Interfaces;
using System.Linq;

namespace SurveysProject.Services
{
    public class ResponseService:IResponseService
    {
        private MyContext context;

        public ResponseService(MyContext context)
        {
            this.context = context;
        }

        public int AddResponse(Response response)
        {
            context.Responses.Add(response);
            context.Entry(response.Survey).State = Microsoft.EntityFrameworkCore.EntityState.Unchanged;
            context.Entry(response.Question).State = Microsoft.EntityFrameworkCore.EntityState.Unchanged;
            context.Entry(response.QuestionOption).State = Microsoft.EntityFrameworkCore.EntityState.Unchanged;
            context.SaveChanges();
            return response.ResponseId;
        }

    }
}
