
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SurveysProject.Models.Data
{
    public class QuestionOption
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuestionOptionId { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Question Option")]
        [Column(TypeName = "nvarchar(100)")]
        public string QuestionOptionText { get; set; }
        public virtual Question Question { get; set; }

    }
}
