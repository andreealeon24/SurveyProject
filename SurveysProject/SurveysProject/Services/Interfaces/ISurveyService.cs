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
        int DeleteSurvey(Survey survey);
        List<Survey> GetSurveys();
        Survey GetSurvey(int surveyId);
        int GetCountSurveysByUserId(int userId);
        List<Survey> GetSurveysByUserId(int userId);
        List<Survey> GetSurveysByCreateFor(string createFor);
    }
}
