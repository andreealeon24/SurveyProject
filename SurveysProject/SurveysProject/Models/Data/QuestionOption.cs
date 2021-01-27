
using System.ComponentModel.DataAnnotations.Schema;

namespace SurveysProject.Models.Data
{
    public class QuestionOption
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuestionOptionId { get; set; }
        [Column(TypeName = "nvarchar(30)")]

        public string QuestionOptionText { get; set; }
        public virtual Question Question { get; set; }
    }
}
