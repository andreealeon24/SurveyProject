using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveysProject.Services.Interfaces
{
    public interface IStatisticsService
    {
        int GetNumerOfResponsesBySurvey(int surveyId);

        int GetCountResponsesBySurvey(int surveyId);

        int GetCountQuestionsBySurvey(int surveyId);
    }
}
