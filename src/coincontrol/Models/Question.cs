using Microsoft.AspNetCore.Mvc;

namespace coincontrol.Models
{
    public class Question : Controller
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string AnswerText { get; set; }
    }
}
