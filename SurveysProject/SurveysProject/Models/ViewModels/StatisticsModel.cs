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
        public Question Question { get; set; }
        public QuestionOption QuestionOption { get; set; }
        public Response Response { get; set; }
        
    }
}
