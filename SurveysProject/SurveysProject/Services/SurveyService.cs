using Microsoft.EntityFrameworkCore;
using SurveysProject.Models;
using SurveysProject.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using SurveysProject.Models.Data;

namespace SurveysProject.Services
{
    public class SurveyService:ISurveyService
    {
        private IQuestionService questionService;

        private MyContext context;

        public SurveyService(MyContext context, IQuestionService questionService)
        {
            this.context = context;
            this.questionService = questionService;
        }

        public int AddSurvey(Survey survey)
        {
            context.Surveys.Add(survey);
            context.SaveChanges();
            return survey.Id;
        }

        public int DeleteSurvey(Survey survey)
        {
            List<Question> questions = new List<Question>();
            questions = questionService.GetQuestionsForSurvey(survey.Id);

            foreach (var question in questions)
            {
                questionService.DeleteQuestion(question);
            }
            context.Surveys.Remove(survey);
            context.SaveChanges();
            return 0;
        }

        public List<Survey> GetSurveys()
        {
            return context.Surveys.ToList();
        }

        public Survey GetSurvey(int surveyId)
        {
            return context.Surveys.Find(surveyId);
        }

        public int GetCountSurveysByUserId(int userId)
        {
            return context.Surveys.Where(x => x.User.Id == userId).Count();
        }

        public List<Survey> GetSurveysByUserId(int userId)
        {
            List<Survey> surveys = context.Surveys.Where(x => x.User.Id == userId).ToList();
            return surveys;
        }

        public List<Survey> GetSurveysByCreateFor(string createFor)
        {
            List<Survey> surveys = context.Surveys.Where(x => x.CreateFor == createFor).ToList();
            return surveys;
        }

    }
}
