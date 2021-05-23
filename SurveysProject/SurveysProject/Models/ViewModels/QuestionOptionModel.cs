using SurveysProject.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveysProject.Models.ViewModels
{
    public class QuestionOptionModel
    {
        public QuestionOption QuestionOption { get; set; }

        public int countQuestionOptionSelected { get; set; }
    }
}
