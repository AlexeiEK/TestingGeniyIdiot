namespace GeniyIdiot.Common
{
    public class User
    {
        public string Name;
        public int RightAnswersCount = 0;
        public string Diagnose = "Неизвестно";

        public User(string name)
        {
            Name = name;
        }

        public void AcceptRightAnswer()
        {
            RightAnswersCount++;
        }

        public static string ShowUserDiagnose(User user)
        {
            var showStringUserDiagnose = $"{user.Name}, Ваш диагноз - {user.Diagnose}!";
            return showStringUserDiagnose;
        }
    }
}
