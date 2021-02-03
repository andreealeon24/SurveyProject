using SurveysProject.Models;
using SurveysProject.Models.Data;
using SurveysProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveysProject.Services
{
    public class SurveyService:ISurveyService
    {
        
        private MyContext context;

        public SurveyService(MyContext context)
        {
            this.context = context;
        }

        public int AddSurvey(Survey survey)
        {
            context.Surveys.Add(survey);
            context.SaveChanges();
            return survey.Id;
        }

        public List<Survey> GetSurveys()
        {
            return context.Surveys.ToList();
        }

        public Survey GetSurvey(int surveyId)
        {
            Survey survey = context.Surveys.Where(x=>x.Id==surveyId).FirstOrDefault();
            return survey;
        }

    }
}
