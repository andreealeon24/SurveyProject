using SurveysProject.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveysProject.Models.ViewModels
{
    public class StatisticsModel
    {
        public Survey Survey { get; set; }
        public List<Question> Questions { get; set; }
        public QuestionOption QuestionOption { get; set; }
        public Response Response { get; set; }
        public int NumberOfResponses { get; set; }
        public List<QuestionStatistics> QuestionStatistics { get; set; }

    }
}
