using SurveysProject.Models;
using SurveysProject.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveysProject.Services
{
    public class QuestionOptionService
    {
        private MyContext context;

        public int AddQuestionOption(QuestionOption questionOption)
        {
            context.QuestionOptions.Add(questionOption);
            context.SaveChanges();
            return questionOption.QuestionOptionId;
        }
    }
}
