using System.Collections.Generic;

namespace JustMeetAdministrator.Model
{
    public class Question
    {
        public int idQuestion { get; set; }
        public string question1 { get; set; }
        public int? idGameType { get; set; }
        public GameType IdGametypeNavigation { get; set; }
        public List<Answer> Answers { get; set; } = new List<Answer>();
    }
}
