using Microsoft.AspNetCore.Mvc;
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
            Question question = new Question();
            question.Survey = data.Survey;
            question.Text = data.Question.Text;
            questionService.AddQuestion(question);

            data.Survey.Title = surveyService.GetSurveyTitleById(data.Survey.Id);

            DataModel model = new DataModel();
            model.Survey = data.Survey;
            model.Question = question;

            return View("Views/Question/QuestionOption.cshtml", model);
        }

        public ActionResult AddQuestionOption(DataModel data)
        {
          
            QuestionOption questionOption = new QuestionOption();
            questionOption.Question = data.Question;
            questionOption.QuestionOptionText = data.QuestionOption.QuestionOptionText;
            questionService.AddQuestionOption(questionOption);


            string title= surveyService.GetSurveyTitleById(data.Survey.Id);
            data.Survey.Title = title;

            string text= questionService.GetQuestionTextById(data.Question.QuestionId);
            data.Question.Text = text;

            DataModel model = new DataModel();
            model.Survey= data.Survey;
            model.Question = data.Question;

            ModelState.Clear();


            return View("Views/Question/QuestionOption.cshtml", model);
        }


    }
}
