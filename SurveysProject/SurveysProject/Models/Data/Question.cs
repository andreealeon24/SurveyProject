using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SurveysProject.Models.Data
{
    public class Question
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuestionId { get; set; }

        [Required(ErrorMessage="This field is required.")]
        [DisplayName("Question")]
        [Column(TypeName = "nvarchar(100)")]
        public string Text { get; set; }
        public virtual Survey Survey { get; set; }

        public List<QuestionOption> Options { get; set; }
    }
}
