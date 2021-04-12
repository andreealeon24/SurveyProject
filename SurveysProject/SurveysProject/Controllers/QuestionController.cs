using Microsoft.AspNetCore.Mvc;
using SurveysProject.Models;
using SurveysProject.Models.Data;
using SurveysProject.Models.ViewModels;
using SurveysProject.Services.Interfaces;


namespace SurveysProject.Controllers
{
    public class QuestionController : Controller
    {

        private IQuestionService questionService;
        private ISurveyService surveyService;
        public QuestionController(IQuestionService questionService, ISurveyService surveyService)
        {
            this.questionService = questionService;
            this.surveyService = surveyService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult QuestionOption()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddQuestion(DataModel data)
        {
            data.Survey = surveyService.GetSurvey(data.Survey.Id);

            Question question = new Question();
            question.Survey = data.Survey;
            question.Text = data.Question.Text;
            questionService.AddQuestion(question);
            
            DataModel model = new DataModel();
            model.Question = question;
            model.Survey = data.Survey;

            return View("Views/Question/QuestionOption.cshtml", model);
        }

        public ActionResult AddQuestionOption(DataModel data)
        {
            data.Survey = surveyService.GetSurvey(data.Survey.Id);
            data.Question = questionService.GetQuestionById(data.Question.QuestionId);

            QuestionOption questionOption = new QuestionOption();
            questionOption.Question = data.Question;
            questionOption.QuestionOptionText = data.QuestionOption.QuestionOptionText;
            questionService.AddQuestionOption(questionOption);

            DataModel model = new DataModel();
            model.Survey= data.Survey;
            model.Question = data.Question;

            ModelState.Clear();

            return View("Views/Question/QuestionOption.cshtml", model);
        }


    }
}
