using System.Collections.Generic;

namespace JustMeetAdministrator.Model
{
    public class Answer
    {
        public int idAnswer { get; set; }
        public string answer1 { get; set; }
        public bool? Selected { get; set; }
        public List<Question> IdQuestions { get; set; } = new List<Question>();
    }
}
