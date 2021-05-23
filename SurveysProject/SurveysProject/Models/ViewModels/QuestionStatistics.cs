using SurveysProject.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveysProject.Models.ViewModels
{
    public class QuestionStatistics
    {
        public Question Question { get; set; }

        public List<QuestionOptionModel> QuestionOptionModels { get; set; }
    }
}
