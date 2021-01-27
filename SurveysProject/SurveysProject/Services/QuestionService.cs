using SurveysProject.Models;
using SurveysProject.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveysProject.Services
{
    public class QuestionService
    {
        private MyContext context;

        public int AddQuestion(Question question)
        {
            context.Questions.Add(question);
            context.SaveChanges();
            return question.QuestionId;
        }
    }
}
