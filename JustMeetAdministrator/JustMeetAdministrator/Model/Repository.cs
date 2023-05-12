using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace JustMeetAdministrator.Model
{
    public class Repository
    {
        //string ws = "https://172.16.24.123:45455/api/"; //DISCO SSD
        string ws = "https://172.16.24.24:45455/api/"; //DISCO HDD

        //Users
        public List<User> GetUsers()
        {
            List<User> users = null;
            users = (List<User>)MakeRequest(string.Concat(ws, "users"), null, "GET", "application/json", typeof(List<User>));
            return users;
        }

        public User GetUser(int id)
        {
            User user = null;
            user = (User)MakeRequest(string.Concat(ws, "user/", id), null, "GET", "application/json", typeof(User));
            return user;
        }
        
        public User GetUserByName(string name)
        {
            User user = null;
            user = (User)MakeRequest(string.Concat(ws, "userByName/", name), null, "GET", "application/json", typeof(User));
            return user;
        }

        public User PostUser(User user)
        {
            User userPost = (User)MakeRequest(string.Concat(ws, "user/"),
                user, "POST", "application/json", typeof(User));
            User userLocation = GetUserByName(user.name);
            if (userLocation != null)
            {
                PostLocation(new Location(0, 0.0, 0.0, userLocation.idUser));
            }
            return userPost;
        }

        public User PutUser(User user)
        {
            User userPut = null;
            userPut = (User)MakeRequest(string.Concat(ws, "user/", user.idUser), user, "PUT", "application/json", typeof(User));
            return userPut;
        }

        public Boolean DeleteUser(int idUser)
        {
            Object userDelete = MakeRequest(string.Concat(ws, "user/", idUser),
                 null, "DELETE", "application/json", typeof(User));
            return (userDelete != null);
        }

        //Settings

        public List<Setting> GetSettings()
        {
            List<Setting> settings = null;
            settings = (List<Setting>)MakeRequest(string.Concat(ws, "settings"), null, "GET", "application/json", typeof(List<Setting>));
            return settings;
        }

        public Setting GetSetting(int id)
        {
            Setting setting = null;
            setting = (Setting)MakeRequest(string.Concat(ws, "setting/", id), null, "GET", "application/json", typeof(Setting));
            return setting;
        }

        public Setting PostSetting(Setting setting)
        {
            Setting settingPost = (Setting)MakeRequest(string.Concat(ws, "setting/"),
                setting, "POST", "application/json", typeof(Setting));
            return settingPost;
        }

        public Setting PutSetting(Setting setting)
        {
            Setting settingPut = null;
            settingPut = (Setting)MakeRequest(string.Concat(ws, "setting/", setting.idSetting), setting, "PUT", "application/json", typeof(Setting));
            return settingPut;
        }

        public Boolean DeleteSetting(int idSetting)
        {
            Object settingDelete = MakeRequest(string.Concat(ws, "setting/", idSetting),
                 null, "DELETE", "application/json", typeof(User));
            return (settingDelete != null);
        }

        //Locations


        public List<Location> GetLocations()
        {
            List<Location> locations = null;
            locations = (List<Location>)MakeRequest(string.Concat(ws, "locations"), null, "GET", "application/json", typeof(List<Location>));
            return locations;
        }

        public Location GetLocation(int id)
        {
            Location location = null;
            location = (Location)MakeRequest(string.Concat(ws, "location/", id), null, "GET", "application/json", typeof(Location));
            return location;
        }

        public Location PostLocation(Location location)
        {
            Location locationPost = (Location)MakeRequest(string.Concat(ws, "location/"),
                location, "POST", "application/json", typeof(Location));
            return locationPost;
        }

        public Location PutLocation(Location location)
        {
            Location locationPut = null;
            locationPut = (Location)MakeRequest(string.Concat(ws, "location/", location.idLocation), location, "PUT", "application/json", typeof(Location));
            return locationPut;
        }

        public Boolean DeleteLocation(int idLocation)
        {
            Object locationDelete = MakeRequest(string.Concat(ws, "location/", idLocation),
                 null, "DELETE", "application/json", typeof(Location));
            return (locationDelete != null);
        }

        //Question

        public List<Question> GetQuestions()
        {
            List<Question> questions = null;
            questions = (List<Question>)MakeRequest(string.Concat(ws, "questions"), null, "GET", "application/json", typeof(List<Question>));
            return questions;
        }

        public Question GetQuestion(int id)
        {
            Question question = null;
            question = (Question)MakeRequest(string.Concat(ws, "question/", id), null, "GET", "application/json", typeof(Question));
            return question;
        }

        public Question PostQuestion(Question question)
        {
            Question questionPost = (Question)MakeRequest(string.Concat(ws, "question/"),
                question, "POST", "application/json", typeof(Question));
            return questionPost;
        }

        public Question PutQuestion(Question question)
        {
            Question questionPut = null;
            questionPut = (Question)MakeRequest(string.Concat(ws, "question/", question.idQuestion), question, "PUT", "application/json", typeof(Question));
            return questionPut;
        }
        

        public Boolean DeleteQuestion(int idQuestion)
        {
            Object questionDelete = MakeRequest(string.Concat(ws, "question/", idQuestion),
                 null, "DELETE", "application/json", typeof(Question));
            return (questionDelete != null);
        }

        //Answer

        public List<Answer> GetAnswers()
        {
            List<Answer> answers = null;
            answers = (List<Answer>)MakeRequest(string.Concat(ws, "answers"), null, "GET", "application/json", typeof(List<Answer>));
            return answers;
        }

        public Answer GetAnswer(int id)
        {
            Answer answer = null;
            answer = (Answer)MakeRequest(string.Concat(ws, "answer/", id), null, "GET", "application/json", typeof(Answer));
            return answer;
        }

        public Answer PostAnswer(Answer answer)
        {
            Answer answerPost = (Answer)MakeRequest(string.Concat(ws, "answer/"),
                answer, "POST", "application/json", typeof(Answer));
            return answerPost;
        }

        public Answer PutAnswer(Answer answer)
        {
            Answer answerPut = null;
            answerPut = (Answer)MakeRequest(string.Concat(ws, "answer/", answer.idAnswer), answer, "PUT", "application/json", typeof(Answer));
            return answerPut;
        }

        public Boolean DeleteAnswer(int idAnswer)
        {
            Object answerDelete = MakeRequest(string.Concat(ws, "answer/", idAnswer),
                 null, "DELETE", "application/json", typeof(Answer));
            return (answerDelete != null);
        }

        //QuestionAnswer

        public List<QuestionAnswer> GetQuestionsAnswers()
        {
            List<QuestionAnswer> questionsAnswers = null;
            questionsAnswers = (List<QuestionAnswer>)MakeRequest(string.Concat(ws, "questionsAnswers"), null, "GET", "application/json", typeof(List<QuestionAnswer>));
            return questionsAnswers;
        }

        public QuestionAnswer PostQuestionAnswer(QuestionAnswer questionAnswer)
        {
            QuestionAnswer questionPost = null;
            questionPost = (QuestionAnswer)MakeRequest(string.Concat(ws, "questionAnswer/"), questionAnswer, "POST", "application/json", typeof(QuestionAnswer));
            return questionPost;
        }
        public QuestionAnswer PutQuestionAnswer(QuestionAnswer questionAnswer)
        {
            QuestionAnswer questionPut = null;
            questionPut = (QuestionAnswer)MakeRequest(string.Concat(ws, "questionAnswer/",questionAnswer.idQuestion,"/",questionAnswer.idAnswer,"/"), questionAnswer, "PUT", "application/json", typeof(QuestionAnswer));
            return questionPut;
        }

        public Boolean DeleteQuestionAnswer(int idQuestion, int idAnswer)
        {
            Object questionDelete = MakeRequest(string.Concat(ws, "questionAnswer/", idQuestion, "/", idAnswer),
                 null, "DELETE", "application/json", typeof(Question));
            return (questionDelete != null);
        }

        // GameType

        public List<GameType> GetGameTypes()
        {
            List<GameType> gameTypes = null;
            gameTypes = (List<GameType>)MakeRequest(string.Concat(ws, "gameTypes"), null, "GET", "application/json", typeof(List<GameType>));
            return gameTypes;
        }

        public GameType GetGameType(int id)
        {
            GameType gameType = null;
            gameType = (GameType)MakeRequest(string.Concat(ws, "gameType/", id), null, "GET", "application/json", typeof(GameType));
            return gameType;
        }

        public GameType PostGameType(GameType gameType)
        {
            GameType gameTypePost = (GameType)MakeRequest(string.Concat(ws, "gameType/"),
                gameType, "POST", "application/json", typeof(GameType));
            return gameTypePost;
        }

        public GameType PutGameType(GameType gameType)
        {
            GameType gameTypePut = null;
            gameTypePut = (GameType)MakeRequest(string.Concat(ws, "gameType/", gameType.idGameType), gameType, "PUT", "application/json", typeof(GameType));
            return gameTypePut;
        }

        public Boolean DeleteGameType(int idGameType)
        {
            Object gameTypeDelete = MakeRequest(string.Concat(ws, "gameType/", idGameType),
                 null, "DELETE", "application/json", typeof(GameType));
            return (gameTypeDelete != null);
        }

        //Game

        public List<Game> GetGames()
        {
            List<Game> game = null;
            game = (List<Game>)MakeRequest(string.Concat(ws, "games"), null, "GET", "application/json", typeof(List<Game>));
            return game;
        }

        public Game GetGame(int id)
        {
            Game game = null;
            game = (Game)MakeRequest(string.Concat(ws, "game/", id), null, "GET", "application/json", typeof(Game));
            return game;
        }

        public Game PostGame(Game game)
        {
            Game gamePost = (Game)MakeRequest(string.Concat(ws, "game/"),
                game, "POST", "application/json", typeof(Game));
            return gamePost;
        }

        public Game PutGame(Game game)
        {
            Game gamePut = null;
            gamePut = (Game)MakeRequest(string.Concat(ws, "game/", game.idGame), game, "PUT", "application/json", typeof(Game));
            return gamePut;
        }

        public Boolean DeleteGame(int idGame)
        {
            Object gameDelete = MakeRequest(string.Concat(ws, "game/", idGame),
                 null, "DELETE", "application/json", typeof(Game));
            return (gameDelete != null);
        }

        //UserAnswer

        public List<UserAnswer> GetUserAnswers()
        {
            List<UserAnswer> userAnswers = null;
            userAnswers = (List<UserAnswer>)MakeRequest(string.Concat(ws, "userAnswers"), null, "GET", "application/json", typeof(List<UserAnswer>));
            return userAnswers;
        }

        public UserAnswer GetUserAnswer(int idGame, int idUser, int idQuestion)
        {
            UserAnswer userAnswer = null;
            userAnswer = (UserAnswer)MakeRequest(string.Concat(ws, "userAnswer/", idGame, "/", idUser, "/", idQuestion), null, "GET", "application/json", typeof(UserAnswer));
            return userAnswer;
        }

        public UserAnswer PostUserAnswer(UserAnswer userAnswer)
        {
            UserAnswer userAnswerPost = (UserAnswer)MakeRequest(string.Concat(ws, "userAnswer/"),
                userAnswer, "POST", "application/json", typeof(UserAnswer));
            return userAnswerPost;
        }

        public UserAnswer PutUserAnswer(UserAnswer userAnswer)
        {
            UserAnswer userAnswerPut = null;
            userAnswerPut = (UserAnswer)MakeRequest(string.Concat(ws, "userAnswer/", userAnswer.idGame), userAnswer, "PUT", "application/json", typeof(UserAnswer));
            return userAnswerPut;
        }

        public Boolean DeleteUserAnswer(int idGame)
        {
            Object userAnswerDelete = MakeRequest(string.Concat(ws, "userAnswer/", idGame),
                 null, "DELETE", "application/json", typeof(UserAnswer));
            return (userAnswerDelete != null);
        }

        //QuestionAnswer

        //public List<QuestionAnswer> GetQuestionAnswer()
        //{
        //    List<QuestionAnswer> userAnswers = null;
        //    userAnswers = (List<QuestionAnswer>)MakeRequest(string.Concat(ws, "userAnswers"), null, "GET", "application/json", typeof(List<QuestionAnswer>));
        //    return userAnswers;
        //}

        //public UserAnswer GetUserAnswer(int id)
        //{
        //    UserAnswer userAnswer = null;
        //    userAnswer = (UserAnswer)MakeRequest(string.Concat(ws, "userAnswer/", id), null, "GET", "application/json", typeof(UserAnswer));
        //    return userAnswer;
        //}

        //public UserAnswer PostUserAnswer(UserAnswer userAnswer)
        //{
        //    UserAnswer userAnswerPost = (UserAnswer)MakeRequest(string.Concat(ws, "userAnswer/"),
        //        userAnswer, "POST", "application/json", typeof(UserAnswer));
        //    return userAnswerPost;
        //}

        //public UserAnswer PutUserAnswer(UserAnswer userAnswer)
        //{
        //    UserAnswer userAnswerPut = null;
        //    userAnswerPut = (UserAnswer)MakeRequest(string.Concat(ws, "userAnswer/", userAnswer.idGame), userAnswer, "PUT", "application/json", typeof(UserAnswer));
        //    return userAnswerPut;
        //}

        //public Boolean DeleteUserAnswer(UserAnswer userAnswer)
        //{
        //    Object userAnswerDelete = MakeRequest(string.Concat(ws, "userAnswer/", userAnswer.idGame),
        //         null, "DELETE", "application/json", typeof(UserAnswer));
        //    return (userAnswerDelete != null);
        //}


        public static object MakeRequest(string requestUrl, object JSONRequest, string JSONmethod, string JSONContentType, Type JSONResponseType)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
                string sb = JsonConvert.SerializeObject(JSONRequest);
                request.Method = JSONmethod;  // "GET"/"POST"/"PUT"/"DELETE";  

                if (JSONmethod != "GET")
                {
                    request.ContentType = JSONContentType; // "application/json";   
                    Byte[] bt = Encoding.UTF8.GetBytes(sb);
                    Stream st = request.GetRequestStream();
                    st.Write(bt, 0, bt.Length);
                    st.Close();
                }

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        throw new Exception(String.Format("Server error (HTTP {0}: {1}).", response.StatusCode, response.StatusDescription));

                    Stream stream1 = response.GetResponseStream();
                    StreamReader sr = new StreamReader(stream1);
                    string strsb = sr.ReadToEnd();
                    object objResponse = JsonConvert.DeserializeObject(strsb, JSONResponseType);
                    return objResponse;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
