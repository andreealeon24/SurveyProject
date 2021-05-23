using Microsoft.EntityFrameworkCore;
using SurveysProject.Models.Data;

namespace SurveysProject.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Response> Responses { get; set; }
        public DbSet<QuestionOption> QuestionOptions { get; set; }
        public DbSet<User> User { get; set; }

    }
}
