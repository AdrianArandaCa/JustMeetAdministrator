using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustMeetAdministrator.Model
{
    public class QuestionAnswer
    {
        public int idQuestion { get; set; }
        public int idAnswer { get; set; }
        public bool? exist { get; set; }
        public Answer IdAnswerNavigation { get; set; } = null;
        public Question IdQuestionNavigation { get; set; } = null;

        public QuestionAnswer(int idQuestion, int idAnswer, bool? exist)
        {
            this.idQuestion = idQuestion;
            this.idAnswer = idAnswer;
            this.exist = exist;
        }

        public QuestionAnswer()
        {
        }
    }
}
