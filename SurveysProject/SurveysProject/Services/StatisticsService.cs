using SurveysProject.Models;
using SurveysProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveysProject.Services
{
    public class StatisticsService:IStatisticsService
    {
        private MyContext context;

        public StatisticsService(MyContext context)
        {
            this.context = context;
        }

        public int GetNumerOfResponsesBySurvey(int surveyId)
        {
            int countResponses = GetCountResponsesBySurvey(surveyId);
            int countQuestions = GetCountQuestionsBySurvey(surveyId);
            return (int)(countResponses / countQuestions);
        }

        public int GetCountResponsesBySurvey(int surveyId)
        {
            return context.Responses.Where(x => x.Survey.Id == surveyId).Count();
        }

        public int GetCountQuestionsBySurvey(int surveyId)
        {
            return context.Questions.Where(x => x.Survey.Id == surveyId).Count();
        }

        public int GetCountResponsesByQuestionOptionId(int questionoptionId)
        {
            return context.Responses.Where(x => x.QuestionOption.QuestionOptionId == questionoptionId).Count();
        }
    }
}
