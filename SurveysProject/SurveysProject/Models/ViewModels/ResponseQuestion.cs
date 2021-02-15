using SurveysProject.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveysProject.Models.ViewModels
{
    public class ResponseQuestion
    {
        public Survey Survey { get; set; }
        public Question Question { get; set; }

        public int SelectedOptionId { get; set; }
    }
}
