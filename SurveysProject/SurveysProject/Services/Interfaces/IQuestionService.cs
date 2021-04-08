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

        int AddQuestionOption(QuestionOption questionOption);

        List<Question> GetQuestionsForSurvey(int surveyId);

        List<QuestionOption> GetOptionsForQuestion(int questionId);

        int GetCountQuestion(int surveyId);

        QuestionOption GetOptionById(int selectedOptionId);
        string GetQuestionTextById(int questionId);
    }
}
