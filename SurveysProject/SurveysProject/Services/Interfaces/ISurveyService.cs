using SurveysProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveysProject.Services.Interfaces
{
    public interface ISurveyService
    {
        int AddSurvey(Survey survey);
        List<Survey> GetSurveys();
        Survey GetSurvey(int surveyId);
    }
}
