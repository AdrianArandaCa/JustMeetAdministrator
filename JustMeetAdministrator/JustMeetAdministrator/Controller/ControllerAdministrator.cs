using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JustMeetAdministrator.Model;
using JustMeetAdministrator.View;
using System.Security.Cryptography;

namespace JustMeetAdministrator.Controller
{
    public class ControllerAdministrator
    {
        Form1 f;
        Repository repository;
        List<QuestionAnswer> questionAnswer = new List<QuestionAnswer>();
        public ControllerAdministrator()
        {
            f = new Form1();
            repository = new Repository();
            InitListeners();
            LoadData();
            DisableComponents();
            Application.Run(f);
        }

        private void LoadData()
        {
            f.questionDgv.DataSource = repository.GetQuestions();
            if (f.questionDgv.DataSource != null)
            {
                f.questionDgv.Columns["IdGametypeNavigation"].Visible = false;
            }
            f.answerDgv.DataSource = repository.GetAnswers();
            f.userDgv.DataSource = repository.GetUsers();
            if (f.userDgv.DataSource != null) 
            {
                f.userDgv.Columns["idSettingNavigation"].Visible = false;
                f.userDgv.Columns["Locations"].Visible = false;
            }
            f.settingDgv.DataSource = repository.GetSettings();
            if (f.settingDgv.DataSource != null) 
            {
                f.settingDgv.Columns["idGameTypeNavigation"].Visible = false;
            }
            f.locationDgv.DataSource = repository.GetLocations();
            f.gameDgv.DataSource = repository.GetGames();
            f.userAnswerDgv.DataSource = repository.GetUserAnswers();
            f.gameTypesDgv.DataSource = repository.GetGameTypes();
            f.questionAnswerDgv.DataSource = repository.GetQuestionsAnswers();
        }

        private void InitListeners()
        {
            //Question
            f.questionDgv.SelectionChanged += QuestionDgv_SelectionChanged;
            f.insertQuestionButton.Click += InsertQuestionButton_Click;
            f.updateQuestionButton.Click += UpdateQuestionButton_Click;
            f.deleteQuestionButton.Click += DeleteQuestionButton_Click;

            //Answer
            f.answerDgv.SelectionChanged += AnswerDgv_SelectionChanged;
            f.insertAnswerButton.Click += InsertAnswerButton_Click;
            f.updateAnswerButton.Click += UpdateAnswerButton_Click;
            f.deleteAnswerButton.Click += DeleteAnswerButton_Click1;

            //User
            f.userDgv.SelectionChanged += UserDgv_SelectionChanged;
            f.insertUserButton.Click += InsertUserButton_Click;
            f.updateUserButton.Click += UpdateUserButton_Click;
            f.deleteUserButton.Click += DeleteUserButton_Click;

            //Setting
            f.settingDgv.SelectionChanged += SettingDgv_SelectionChanged;
            f.insertSettingButton.Click += InsertSettingButton_Click;
            f.updateSettingButton.Click += UpdateSettingButton_Click;
            f.deleteSettingButton.Click += DeleteSettingButton_Click;

            //Location
            f.locationDgv.SelectionChanged += LocationDgv_SelectionChanged;
            f.insertLocationButton.Click += InsertLocationButton_Click;
            f.updateLocationButton.Click += UpdateLocationButton_Click;
            f.deleteLocationButton.Click += DeleteLocationButton_Click;

            //Game
            f.gameDgv.SelectionChanged += GameDgv_SelectionChanged;
            f.insertGameButton.Click += InsertGameButton_Click;
            f.updateGameButton.Click += UpdateGameButton_Click;
            f.deleteGameButton.Click += DeleteGameButton_Click;

            //UserAnswer
            f.userAnswerDgv.SelectionChanged += UserAnswerDgv_SelectionChanged;
            f.insertUserAnswerButton.Click += InsertUserAnswerButton_Click;
            f.updateUserAnswerButton.Click += UpdateUserAnswerButton_Click;
            f.deleteUserAnswerButton.Click += DeleteUserAnswerButton_Click;

            //GameType
            f.gameTypesDgv.SelectionChanged += GameTypesDgv_SelectionChanged;
            f.insertGameTypesButton.Click += InsertGameTypesButton_Click;
            f.updateGameTypesButton.Click += UpdateGameTypesButton_Click;
            f.deleteGameTypesButton.Click += DeleteGameTypesButton_Click;

            //QuestionAnswer
            f.questionAnswerDgv.SelectionChanged += QuestionAnswerDgv_SelectionChanged;
            f.insertQuestionAnswerButton.Click += InsertQuestionAnswerButton_Click;
            f.updateQuestionAnswerButton.Click += UpdateQuestionAnswerButton_Click;
            f.deleteQuestionAnswerButton.Click += DeleteQuestionAnswerButton_Click;
        }

        private void DisableComponents()
        {
            f.idQuestionTextBox.Enabled = false;
            f.idAnswerTextBox.Enabled = false;
            f.idUserTextBox.Enabled = false;
            f.idGameTextBox.Enabled = false;
            f.idSettingTextBox.Enabled = false;
            f.idLocationTextBox.Enabled = false;
            f.idGameTypeTextBox.Enabled = false;
            f.userAnswerIdGameTextBox.Enabled = false;
            f.userAnswerIdUserTextBox.Enabled = false;
            f.userAnswerIdQuestionTextBox.Enabled = false;
            f.insertUserAnswerButton.Enabled = false;
            f.updateQuestionButton.Enabled = false;
            f.updateAnswerButton.Enabled = false;
            f.updateUserButton.Enabled = false;
            f.updateSettingButton.Enabled = false;
            f.updateLocationButton.Enabled = false;
            f.updateGameButton.Enabled = false;
            f.updateGameTypesButton.Enabled = false;
            f.updateQuestionAnswerButton.Enabled = false;
            f.updateUserAnswerButton.Enabled = false;
            f.deleteQuestionButton.Enabled = false;
            f.deleteAnswerButton.Enabled = false;
            f.deleteUserButton.Enabled = false;
            f.deleteSettingButton.Enabled = false;
            f.deleteLocationButton.Enabled = false;
            f.deleteGameButton.Enabled = false;
            f.deleteGameTypesButton.Enabled = false;
            f.deleteQuestionAnswerButton.Enabled = false;
            f.deleteUserAnswerButton.Enabled = false;
        }

        private string ConvertPasswordSha256(string inputString)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] inputBytes = Encoding.UTF8.GetBytes(inputString);
            byte[] hash = sha256.ComputeHash(inputBytes);
            string hashedString = BitConverter.ToString(hash).Replace("-", "").ToLower();
            return hashedString;
        }

        private void MessageSend(string message)
        {
            MessageBox.Show(message);
        }

        //QuestionAnswer
        private void DeleteQuestionAnswerButton_Click(object sender, EventArgs e)
        {
            //int idQuestion;
            //int idAnswer;
            //if (int.TryParse(f.questionAnswerIdQuestionTextBox.Text, out idQuestion) &&
            //    int.TryParse(f.questionAnswerIdAnswerTextBox.Text, out idAnswer))
            //{
            //    repository.DeleteQuestionAnswerTable(idQuestion, idAnswer);
            //    LoadData();
            //}
            //else
            //{
            //    MessageSend("Game no esborrat, format incorrecte");
            //}

        }

        private void UpdateQuestionAnswerButton_Click(object sender, EventArgs e)
        {
        }

        private void InsertQuestionAnswerButton_Click(object sender, EventArgs e)
        {
            //int idQuestion;
            //int idAnswer;

            //if (int.TryParse(f.questionAnswerIdQuestionTextBox.Text, out idQuestion) &&
            //    int.TryParse(f.questionAnswerIdAnswerTextBox.Text, out idAnswer))
            //{
            //    Question question = repository.GetQuestion(idQuestion);
            //    Answer answer = repository.GetAnswer(idAnswer);
            //    question.IdAnswers.Clear();
            //    question.IdAnswers.Add(answer);
            //    repository.PutQuestionAnswerTable(question);
            //    LoadData();
            //}
            //else
            //{
            //    MessageSend("Question no modificat, format incorrecte");
            //}
        }

        private void QuestionAnswerDgv_SelectionChanged(object sender, EventArgs e)
        {
            QuestionAnswer questionAnswer = f.questionAnswerDgv.CurrentRow.DataBoundItem as QuestionAnswer;
            f.updateQuestionAnswerButton.Enabled = true;
            f.deleteQuestionAnswerButton.Enabled = true;
            f.questionAnswerIdAnswerTextBox.Text = questionAnswer.idAnswer.ToString();
        }

        //GameType
        private void DeleteGameTypesButton_Click(object sender, EventArgs e)
        {
            int idGameType;
            if (int.TryParse(f.idGameTypeTextBox.Text, out idGameType))
            {
                repository.DeleteGameType(idGameType);
                LoadData();
            }
            else
            {
                MessageSend("Game no esborrat, format incorrecte");
            }
        }

        private void UpdateGameTypesButton_Click(object sender, EventArgs e)
        {
            GameType gameTypePut = repository.GetGameType(int.Parse(f.idGameTextBox.Text));
            gameTypePut.type = f.typeTextBox.Text;
            repository.PutGameType(gameTypePut);
            LoadData();
        }

        private void InsertGameTypesButton_Click(object sender, EventArgs e)
        {
            GameType gameTypePost = new GameType();
            gameTypePost.idGameType = 0;
            gameTypePost.type = f.typeTextBox.Text;
            repository.PostGameType(gameTypePost);
            LoadData();
        }

        private void GameTypesDgv_SelectionChanged(object sender, EventArgs e)
        {
            GameType gameType = f.gameTypesDgv.CurrentRow.DataBoundItem as GameType;
            f.updateGameTypesButton.Enabled = true;
            f.deleteGameTypesButton.Enabled = true;
            f.idGameTypeTextBox.Text = gameType.idGameType.ToString();
            f.typeTextBox.Text = gameType.type.ToString();
        }

        //UserAnswer
        private void DeleteUserAnswerButton_Click(object sender, EventArgs e)
        {
            int idGame;
            if (int.TryParse(f.userAnswerIdGameTextBox.Text, out idGame))
            {
                repository.DeleteUserAnswer(idGame);
                LoadData();
            }
            else
            {
                MessageSend("Game no esborrat, format incorrecte");
            }
        }

        private void UpdateUserAnswerButton_Click(object sender, EventArgs e)
        {
            int idAnswer;
            UserAnswer userAnswerPut = repository.GetUserAnswer(int.Parse(f.userAnswerIdGameTextBox.Text),
                int.Parse(f.userAnswerIdUserTextBox.Text), int.Parse(f.userAnswerIdQuestionTextBox.Text));
            if (int.TryParse(f.userAnswerIdAnswerTextBox.Text, out idAnswer))
            {
                userAnswerPut.idAnswer = idAnswer;
                repository.PutUserAnswer(userAnswerPut);
                LoadData();
            }
            else
            {
                MessageSend("UserAnswer no modificat, format incorrecte");
            }

        }

        private void InsertUserAnswerButton_Click(object sender, EventArgs e)
        {
            //TODO
        }
        private void UserAnswerDgv_SelectionChanged(object sender, EventArgs e)
        {
            UserAnswer userAnswer = f.userAnswerDgv.CurrentRow.DataBoundItem as UserAnswer;
            f.updateUserAnswerButton.Enabled = true;
            f.deleteUserAnswerButton.Enabled = true;
            f.userAnswerIdGameTextBox.Text = userAnswer.idGame.ToString();
            f.userAnswerIdUserTextBox.Text = userAnswer.idUser.ToString();
            f.userAnswerIdQuestionTextBox.Text = userAnswer.idQuestion.ToString();
            f.userAnswerIdAnswerTextBox.Text = userAnswer.idAnswer.ToString();
        }

        //Game
        private void DeleteGameButton_Click(object sender, EventArgs e)
        {
            int idGame;
            if (int.TryParse(f.idGameTextBox.Text, out idGame))
            {
                repository.DeleteGame(idGame);
                LoadData();
            }
            else
            {
                MessageSend("Game no esborrat, format incorrecte");
            }
        }

        private void UpdateGameButton_Click(object sender, EventArgs e)
        {
            double gamePercentage;
            Game gamePut = repository.GetGame(int.Parse(f.idGameTextBox.Text));
            gamePut.idGame = 0;
            if (double.TryParse(f.percentageTextBox.Text, out gamePercentage))
            {
                gamePut.percentage = gamePercentage;
            }
            else
            {
                gamePut.percentage = 0;
            }
            gamePut.match = f.matchCheckBox.Checked;
            repository.PutGame(gamePut);
            LoadData();
        }

        private void InsertGameButton_Click(object sender, EventArgs e)
        {
            double gamePercentage;
            Game gamePost = new Game();
            gamePost.idGame = 0;
            if (double.TryParse(f.percentageTextBox.Text, out gamePercentage))
            {
                gamePost.percentage = gamePercentage;
            }
            else
            {
                gamePost.percentage = 0;
            }
            gamePost.registrationDate = DateTime.Today.ToString("yyyy-MM-dd");
            gamePost.match = f.matchCheckBox.Checked;
            repository.PostGame(gamePost);
            LoadData();
        }

        private void GameDgv_SelectionChanged(object sender, EventArgs e)
        {
            Game game = f.gameDgv.CurrentRow.DataBoundItem as Game;
            f.updateGameButton.Enabled = true;
            f.deleteGameButton.Enabled = true;
            f.idGameTextBox.Text = game.idGame.ToString();
            f.registrationDateTextBox.Text = game.registrationDate.ToString();
            f.percentageTextBox.Text = game.percentage.ToString();
            f.matchCheckBox.Checked = game.match;
        }

        //Location
        private void DeleteLocationButton_Click(object sender, EventArgs e)
        {
            int idLocation;
            if (int.TryParse(f.idLocationTextBox.Text, out idLocation))
            {
                repository.DeleteLocation(idLocation);
                LoadData();
            }
            else
            {
                MessageSend("Location no esborrat, format incorrecte");
            }
        }

        private void UpdateLocationButton_Click(object sender, EventArgs e)
        {
            int locationIdUser;
            int locationLatitud;
            int locationLongitud;
            Location locationPut = repository.GetLocation(int.Parse(f.idLocationTextBox.Text));
            if (int.TryParse(f.locationIdUserTextBox.Text, out locationIdUser) &&
                int.TryParse(f.latitudTextBox.Text, out locationLatitud) &&
                int.TryParse(f.longitudTextBox.Text, out locationLongitud))
            {
                locationPut.idUser = locationIdUser;
                locationPut.longitud = locationLongitud;
                locationPut.latitud = locationLatitud;
                repository.PutLocation(locationPut);
                LoadData();
            }
            else
            {
                MessageSend("Location no inserit, error format");
            }
        }

        private void InsertLocationButton_Click(object sender, EventArgs e)
        {
            int locationIdUser;
            int locationLatitud;
            int locationLongitud;
            Location locationPost = new Location();
            locationPost.idLocation = 0;
            if (int.TryParse(f.locationIdUserTextBox.Text, out locationIdUser) &&
                int.TryParse(f.latitudTextBox.Text, out locationLatitud) &&
                int.TryParse(f.longitudTextBox.Text, out locationLongitud))
            {
                locationPost.idUser = locationIdUser;
                locationPost.longitud = locationLongitud;
                locationPost.latitud = locationLatitud;
                repository.PostLocation(locationPost);
                LoadData();
            }
            else
            {
                MessageSend("Location no inserit, error format");
            }
        }

        private void LocationDgv_SelectionChanged(object sender, EventArgs e)
        {
            Location location = f.locationDgv.CurrentRow.DataBoundItem as Location;
            f.updateLocationButton.Enabled = true;
            f.deleteLocationButton.Enabled = true;
            f.idLocationTextBox.Text = location.idLocation.ToString();
            f.longitudTextBox.Text = location.longitud.ToString();
            f.latitudTextBox.Text = location.latitud.ToString();
            f.locationIdUserTextBox.Text = location.idUser.ToString();
        }

        //Setting
        private void DeleteSettingButton_Click(object sender, EventArgs e)
        {
            int idSetting;
            if (int.TryParse(f.idAnswerTextBox.Text, out idSetting))
            {
                repository.DeleteSetting(idSetting);
                LoadData();
            }
            else
            {
                MessageSend("Setting no esborrat, format incorrecte");
            }
        }

        private void UpdateSettingButton_Click(object sender, EventArgs e)
        {
            int settingMaxDistance;
            int settingMinAge;
            int settingMaxAge;
            int settingIdGameType;
            Setting settingPut = repository.GetSetting(int.Parse(f.idSettingTextBox.Text));
            if (int.TryParse(f.maxDistanceTextBox.Text, out settingMaxDistance) &&
                int.TryParse(f.minAgeTextBox.Text, out settingMinAge) &&
                int.TryParse(f.maxAgeTextBox.Text, out settingMaxAge))
            {
                settingPut.maxDistance = settingMaxDistance;
                settingPut.minAge = settingMinAge;
                settingPut.maxAge = settingMaxAge;
                settingPut.genre = f.settingGenreTextBox.Text;
                if (int.TryParse(f.settingIdGameTypeTextBox.Text, out settingIdGameType))
                {
                    settingPut.idGameType = settingIdGameType;
                }
                else
                {
                    settingPut.idGameType = 2;
                }
                repository.PutSetting(settingPut);
                LoadData();
            }
            else
            {
                MessageSend("Settings no modificat, error format");
            }
        }

        private void InsertSettingButton_Click(object sender, EventArgs e)
        {
            int settingMaxDistance;
            int settingMinAge;
            int settingMaxAge;
            int settingIdGameType;
            Setting settingPost = new Setting();
            settingPost.idSetting = 0;
            if (int.TryParse(f.maxDistanceTextBox.Text, out settingMaxDistance) && int.TryParse(f.minAgeTextBox.Text, out settingMinAge) && int.TryParse(f.maxAgeTextBox.Text, out settingMaxAge))
            {
                settingPost.maxDistance = settingMaxDistance;
                settingPost.minAge = settingMinAge;
                settingPost.maxAge = settingMaxAge;
                settingPost.genre = f.settingGenreTextBox.Text;
                if (int.TryParse(f.settingIdGameTypeTextBox.Text, out settingIdGameType))
                {
                    settingPost.idGameType = settingIdGameType;
                }
                else
                {
                    settingPost.idGameType = 2;
                }
                repository.PostSetting(settingPost);
                LoadData();
            }
            else
            {
                MessageSend("Settings no inserit, error format");
            }
        }

        private void SettingDgv_SelectionChanged(object sender, EventArgs e)
        {
            Setting setting = f.settingDgv.CurrentRow.DataBoundItem as Setting;
            f.updateSettingButton.Enabled = true;
            f.deleteSettingButton.Enabled = true;
            f.idSettingTextBox.Text = setting.idSetting.ToString();
            f.maxDistanceTextBox.Text = setting.maxDistance.ToString();
            f.minAgeTextBox.Text = setting.minAge.ToString();
            f.maxAgeTextBox.Text = setting.maxAge.ToString();
            f.settingGenreTextBox.Text = setting.genre.ToString();
            f.settingIdGameTypeTextBox.Text = setting.idGameType.ToString();
        }

        //User
        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            int idUser;
            if (int.TryParse(f.idAnswerTextBox.Text, out idUser))
            {
                repository.DeleteUser(idUser);
                LoadData();
            }
            else
            {
                MessageSend("User no esborrat, format incorrecte");
            }
        }

        private void UpdateUserButton_Click(object sender, EventArgs e)
        {
            int userAge;
            User userPut = repository.GetUser(int.Parse(f.idUserTextBox.Text));
            userPut.name = f.nameTextBox.Text;
            if (!f.passwordTextBox.Text.Equals(""))
            {
                userPut.password = ConvertPasswordSha256(f.passwordTextBox.Text);
            }
            else
            {
                userPut.password = ConvertPasswordSha256("1234");
            }
            userPut.email = f.emailTextBox.Text;
            userPut.genre = f.userGenreTextBox.Text;
            userPut.description = f.descriptionTextBox.Text;
            if (int.TryParse(f.ageTextBox.Text, out userAge))
            {
                userPut.birthday = userAge;
            }
            else
            {
                userPut.birthday = 99;
            }
            userPut.premium = f.premiumCheckBox.Checked;
            repository.PutUser(userPut);
            LoadData();
        }

        private void InsertUserButton_Click(object sender, EventArgs e)
        {
            int userAge;
            User userPost = new User();
            userPost.idUser = 0;
            userPost.name = f.nameTextBox.Text;
            if (!f.passwordTextBox.Text.Equals(""))
            {
                userPost.password = ConvertPasswordSha256(f.passwordTextBox.Text);
            }
            else
            {
                userPost.password = ConvertPasswordSha256("1234");
            }
            userPost.email = f.emailTextBox.Text;
            userPost.genre = f.userGenreTextBox.Text;
            userPost.photo = 0;
            userPost.description = f.descriptionTextBox.Text;
            userPost.idSettingNavigation = new Setting(0, 10, 18, 30, userPost.genre, null, null);
            if (int.TryParse(f.ageTextBox.Text, out userAge))
            {
                userPost.birthday = userAge;
            }
            else
            {
                userPost.birthday = 99;
            }
            userPost.premium = f.premiumCheckBox.Checked;
            repository.PostUser(userPost);
            LoadData();

        }
        private void UserDgv_SelectionChanged(object sender, EventArgs e)
        {
            User user = f.userDgv.CurrentRow.DataBoundItem as User;
            f.updateUserButton.Enabled = true;
            f.deleteUserButton.Enabled = true;
            f.photoTextBox.Enabled = false;
            f.idUserTextBox.Text = user.idUser.ToString();
            f.nameTextBox.Text = user.name.ToString();
            f.passwordTextBox.Text = user.password.ToString();
            f.emailTextBox.Text = user.email.ToString();
            f.userGenreTextBox.Text = user.genre.ToString();
            f.photoTextBox.Text = user.photo.ToString();
            f.descriptionTextBox.Text = user.description.ToString();
            f.userIdSettingTextBox.Text = user.idSetting.ToString();
            f.ageTextBox.Text = user.birthday.ToString();
            f.premiumCheckBox.Checked = user.premium;
        }

        //Answer
        private void DeleteAnswerButton_Click1(object sender, EventArgs e)
        {
            int idAnswer;
            if (int.TryParse(f.idAnswerTextBox.Text, out idAnswer))
            {
                repository.DeleteAnswer(idAnswer);
                LoadData();
            }
            else
            {
                MessageSend("Answer no esborrat, format incorrecte");
            }
        }

        private void UpdateAnswerButton_Click(object sender, EventArgs e)
        {
            Answer answerPut = repository.GetAnswer(int.Parse(f.idAnswerTextBox.Text));
            answerPut.answer1 = f.answerTextBox.Text;
            repository.PutAnswer(answerPut);
            LoadData();

        }

        private void InsertAnswerButton_Click(object sender, EventArgs e)
        {
            Answer answerPost = new Answer();
            answerPost.idAnswer = 0;
            answerPost.answer1 = f.answerTextBox.Text;
            repository.PostAnswer(answerPost);
            LoadData();

        }

        private void AnswerDgv_SelectionChanged(object sender, EventArgs e)
        {
            Answer answer = f.answerDgv.CurrentRow.DataBoundItem as Answer;
            f.updateAnswerButton.Enabled = true;
            f.deleteAnswerButton.Enabled = true;
            f.idAnswerTextBox.Text = answer.idAnswer.ToString();
            f.answerTextBox.Text = answer.answer1.ToString();
        }

        //Question
        private void DeleteQuestionButton_Click(object sender, EventArgs e)
        {
            int idQuestion;
            if (int.TryParse(f.idQuestionTextBox.Text, out idQuestion))
            {
                repository.DeleteQuestion(idQuestion);
                LoadData();
            }
            else
            {
                MessageSend("Question no esborrat, format incorrecte");
            }

        }

        private void UpdateQuestionButton_Click(object sender, EventArgs e)
        {
            int idQuestionGameType;
            Question questionPut = repository.GetQuestion(int.Parse(f.idQuestionTextBox.Text));
            questionPut.question1 = f.questionTextBox.Text;

            if (int.TryParse(f.questionIdGameTypeTextBox.Text, out idQuestionGameType))
            {
                switch (idQuestionGameType)
                {
                    case 1:
                        questionPut.idGameType = idQuestionGameType;
                        break;
                    case 2:
                        questionPut.idGameType = idQuestionGameType;
                        break;
                    case 3:
                        questionPut.idGameType = idQuestionGameType;
                        break;
                    default:
                        questionPut.idGameType = 2;
                        break;
                }
                repository.PutQuestion(questionPut);
                LoadData();

            }
            else
            {
                MessageSend("Question no modificat, format incorrecte");
            }

        }

        private void InsertQuestionButton_Click(object sender, EventArgs e)
        {
            int idQuestionGameType;
            Question questionPost = new Question();
            questionPost.idQuestion = 0;
            questionPost.question1 = f.questionTextBox.Text;

            if (int.TryParse(f.questionIdGameTypeTextBox.Text, out idQuestionGameType))
            {
                switch (idQuestionGameType)
                {
                    case 1:
                        questionPost.idGameType = idQuestionGameType;
                        break;
                    case 2:
                        questionPost.idGameType = idQuestionGameType;
                        break;
                    case 3:
                        questionPost.idGameType = idQuestionGameType;
                        break;
                    default:
                        questionPost.idGameType = 2;
                        break;
                }
                repository.PostQuestion(questionPost);
                LoadData();
            }
            else
            {
                MessageSend("Question no insertat, format incorrecte");
            }
        }

        private void QuestionDgv_SelectionChanged(object sender, EventArgs e)
        {
            Question question = f.questionDgv.CurrentRow.DataBoundItem as Question;
            f.updateQuestionButton.Enabled = true;
            f.deleteQuestionButton.Enabled = true;
            f.idQuestionTextBox.Text = question.idQuestion.ToString();
            f.questionTextBox.Text = question.question1.ToString();
            f.questionIdGameTypeTextBox.Text = question.idGameType.ToString();
        }
    }
}
