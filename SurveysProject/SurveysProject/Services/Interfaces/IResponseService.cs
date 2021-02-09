using SurveysProject.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveysProject.Services.Interfaces
{
    public interface IResponseService
    {

        int AddResponse(Response response);
    }
}
