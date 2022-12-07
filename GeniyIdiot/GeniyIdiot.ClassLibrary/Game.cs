namespace GeniyIdiot.Common
{
    public class Game
    {
        private User user;
        private List<Question> allQuestions;
        private Question currentQuestion;
        private int allQuestionsCount;
        private int questionNumber = 0;

        public Game(User user)
        {
            this.user = user;
            allQuestions = QuestionsStorage.GetQuestions();
            allQuestionsCount = allQuestions.Count;
        }

        public Question GetNextQuestion()
        {
            var random = new Random();
            var randomeQuestionIndex = random.Next(0, allQuestions.Count);
            currentQuestion = allQuestions[randomeQuestionIndex];

            questionNumber++;

            return currentQuestion;
        }

        public void AcceptAnswer(int userAnswer)
        {
            var rightAnswer = currentQuestion.Answer;

            if (userAnswer == rightAnswer)
            {
                user.AcceptRightAnswer();
            }

            allQuestions.Remove(currentQuestion);
        }

        public string GetQuestionNumberText()
        {
            return "Вопрос №" + questionNumber;
        }

        public bool End()
        {
            return allQuestions.Count == 0;
        }

        public string CalculateDiagnose()
        {
            user.Diagnose = Diagnose.GetDiagnose(user.RightAnswersCount, allQuestionsCount);
            UserResultsStorage.Append(user);

            return User.ShowUserDiagnose(user);
        }
    }
}
