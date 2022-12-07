using Newtonsoft.Json;

namespace GeniyIdiot.Common
{
    public class QuestionsStorage
    {
        private static string pathFile = "allQuestions.json";

        public static List<Question> GetQuestions()
        {
            var allQuestions = new List<Question>();

            if (!FileProvider.Exists(pathFile))
            {
                allQuestions.Add(new Question("Сколько будет два плюс два умноженное на два?", 6));
                allQuestions.Add(new Question("Бревно нужно распилить на 10 частей.Сколько распилов нужно сделать?", 9));
                allQuestions.Add(new Question("На двух руках 10 пальцев.Сколько пальцев на 5 руках?", 25));
                allQuestions.Add(new Question("Укол делают каждые полчаса.Сколько нужно минут, чтобы сделать три укола?", 60));
                allQuestions.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2));
                SaveQuestions(allQuestions);
            }

            var fileData = FileProvider.GetValue(pathFile);
            allQuestions = JsonConvert.DeserializeObject<List<Question>>(fileData);
            return allQuestions;
        }

        private static void SaveQuestions(List<Question> allQuestions)
        {
            var jsonData = JsonConvert.SerializeObject(allQuestions, Formatting.Indented);
            FileProvider.Replace(pathFile, jsonData);
        }

        public static void Add(Question newQuestion)
        {
            var allQuestions = GetQuestions();
            allQuestions.Add(newQuestion);
            SaveQuestions(allQuestions);
        }

        public static void RestoreQuestions()
        {
            File.Delete(pathFile);
            SaveQuestions(GetQuestions());
        }

        public static void Remove(Question removeQuestion)
        {
            var questions = GetQuestions();
            for (int i = 0; i < questions.Count; i++)
            {
                if (questions[i].Text == removeQuestion.Text)
                {
                    questions.RemoveAt(i);
                    break;
                }
            }
            SaveQuestions(questions);
        }

        public static void Remove(string questionText)
        {
            var questions = GetQuestions();
            for (int i = 0; i < questions.Count; i++)
            {
                if (questions[i].Text == questionText)
                {
                    questions.RemoveAt(i);
                    break;
                }
            }
            SaveQuestions(questions);
        }
    }
}
