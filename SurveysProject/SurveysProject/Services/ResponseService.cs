using SurveysProject.Models;
using SurveysProject.Models.Data;
using SurveysProject.Services.Interfaces;


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
            context.SaveChanges();
            return response.ResponseId;
        }
    }
}
