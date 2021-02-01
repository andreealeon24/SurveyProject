using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SurveysProject.Models.Data
{
    public class Response
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ResponseId { get; set; }
        public virtual Question Question { get; set; }
        public virtual Survey Survey { get; set; }
        public virtual QuestionOption QuestionOption { get; set; }

    }
}
