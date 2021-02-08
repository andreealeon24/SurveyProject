using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveysProject.Models.Data
{
    public class DataModel
    {
        public Question Question { get; set; }

        public QuestionOption QuestionOption1 { get; set; }

        public QuestionOption QuestionOption2 { get; set; }

        public QuestionOption QuestionOption3 { get; set; }

        public Survey Survey { get; set; }


    }
}
