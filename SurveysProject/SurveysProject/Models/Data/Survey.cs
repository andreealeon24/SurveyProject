using SurveysProject.Models.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SurveysProject.Models
{
    public class Survey
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [Column(TypeName ="nvarchar(30)")]
        public string Title { get; set; }

        public List<Question> Questions { get; set; }
    }
}
