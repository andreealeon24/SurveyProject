using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SurveysProject.Models.Data;

namespace SurveysProject.Models.ViewModels
{
    public class DataModel
    {
        public Question Question { get; set; }

        public QuestionOption QuestionOption { get; set; }

        public Survey Survey { get; set; }

        public User User { get; set; }

    }
}
