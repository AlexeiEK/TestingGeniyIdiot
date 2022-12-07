namespace GeniyIdiot.Common
{
    public class Diagnose
    {
        public static string GetDiagnose(int rightAnswersCount, int questionsCount)
        {
            var shareCorrectAnswers = rightAnswersCount * 100 / questionsCount;
            switch (shareCorrectAnswers)
            {
                case < 20:
                    return "Кретин";
                case < 40:
                    return "Идиот";
                case < 60:
                    return "Дурак";
                case < 80:
                    return "Нормальный";
                case < 100:
                    return "Талант";
                default:
                    return "Гений";
            }
        }
    }
}
