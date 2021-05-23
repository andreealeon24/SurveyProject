using SurveysProject.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveysProject.Services.Interfaces
{
    public interface IQuestionService
    {
        int AddQuestion(Question question);

        int DeleteQuestion(Question question);

        int AddQuestionOption(QuestionOption questionOption);

        int DeleteQuestionOption(QuestionOption questionoption);

        List<Question> GetQuestionsForSurvey(int surveyId);

        List<QuestionOption> GetOptionsForQuestion(int questionId);

        int GetCountQuestion(int surveyId);

        QuestionOption GetOptionById(int selectedOptionId);
        Question GetQuestionById(int questionId);

        int GetCountQuestionOptionSelectById(int questionOptionId);

        int GetCountQuestionOptionByQuestionId(int questionId);

    }
}
