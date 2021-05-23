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
        private IResponseService responseService;


        public QuestionService(MyContext context, IResponseService responseService)
        {
            this.context = context;
            this.responseService = responseService;

        }

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

        public int DeleteQuestion(Question question)
        {
            List<QuestionOption> questionOptions = new List<QuestionOption>();
            questionOptions = GetOptionsForQuestion(question.QuestionId);
            foreach (var option in questionOptions)
            {
                DeleteQuestionOption(option);
            }
            context.Questions.Remove(question);
            context.SaveChanges();
            return 0;
        }

        public int DeleteQuestionOption(QuestionOption questionOption)
        {
            List<Response> responses = new List<Response>();
            responses = responseService.GetResponsesByOptionId(questionOption.QuestionOptionId);
            foreach (var response in responses)
            {
                responseService.DeleteResponse(response);
            }
            context.QuestionOptions.Remove(questionOption);
            context.SaveChanges();
            return 0;
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


        public Question GetQuestionById(int questionId)
        {

            return context.Questions.Find(questionId);
        }

        public int GetCountQuestionOptionSelectById(int questionOptionId)
        {
            return context.Responses.Where(x => x.QuestionOption.QuestionOptionId == questionOptionId).Count();
        }

        public int GetCountQuestionOptionByQuestionId(int questionId)
        {
            return context.QuestionOptions.Where(x => x.Question.QuestionId == questionId).Count();
        }



    }
}
