using Microsoft.EntityFrameworkCore;
using SurveysProject.Models;
using SurveysProject.Models.Data;
using SurveysProject.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SurveysProject.Services
{
    public class QuestionService:IQuestionService
    {
        private MyContext context;

        public QuestionService(MyContext context) => this.context = context;

        public int AddQuestion(Question question)
        {
            context.Questions.Add(question);
            context.Entry(question.Survey).State = Microsoft.EntityFrameworkCore.EntityState.Unchanged;
            context.SaveChanges();
            return question.QuestionId;
        }

        public int AddQuestionOption(QuestionOption questionOption)
        {
            context.QuestionOptions.Add(questionOption);
            context.Entry(questionOption.Question).State = Microsoft.EntityFrameworkCore.EntityState.Unchanged;
            context.SaveChanges();
            return questionOption.QuestionOptionId;
        }

        public List<Question> GetQuestionsForSurvey(int surveyId) 
        {
            List<Question> questions = context.Questions.Where(x => x.Survey.Id == surveyId).ToList();
            return questions;
        }

        public List<QuestionOption> GetOptionsForQuestion(int questionId)
        {
            List<QuestionOption> questionOptions = context.QuestionOptions.Where(x => x.Question.QuestionId == questionId).ToList();
            return questionOptions;
        }

        public int GetCountQuestion(int surveyId)
        {
            return context.Questions.Where(x=> x.Survey.Id == surveyId).Count();
        }

        public QuestionOption GetOptionById(int selectedOptionId)
        {
            QuestionOption questionOption = context.QuestionOptions.Where(x => x.QuestionOptionId == selectedOptionId).Include(x => x.Question).FirstOrDefault();
            return questionOption;
        }
    }
}
