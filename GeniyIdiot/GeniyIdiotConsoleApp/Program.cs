using GeniyIdiot.Common;
using System;

namespace GeniyIdiotConsoleApp
{
    class Program
    {
        static void Main()
        {
            string userName = CLI.InputUserName("Добрый день, как Вас зовут?");
            Console.WriteLine("");
            var user = new User(userName);

            while (true)
            {
                var game = new Game(user);

                while (!game.End())
                {
                    var currentQuestion = game.GetNextQuestion();

                    Console.WriteLine(game.GetQuestionNumberText());
                    Console.WriteLine(currentQuestion.Text);

                    var userAnswer = CLI.GetNumber();

                    game.AcceptAnswer(userAnswer);
                }

                var message = game.CalculateDiagnose();

                Console.WriteLine("");
                Console.WriteLine("Количество правильных ответов: " + user.RightAnswersCount);
                Console.WriteLine(message);
                Console.WriteLine("");

                var userChoice = CLI.GetUserChoice("Хотите посмотреть предыдущие результаты игры?");
                Console.WriteLine("");
                if (userChoice)
                {
                    ShowUsersResults();
                }
                Console.WriteLine("");

                userChoice = CLI.GetUserChoice("Хотите добавить новый вопрос?");
                Console.WriteLine("");
                if (userChoice)
                {
                    AddNewQuestion();
                }
                Console.WriteLine("");

                userChoice = CLI.GetUserChoice("Хотите удалить существующий вопрос?");
                Console.WriteLine("");
                if (userChoice)
                {
                    RemoveQuestion();
                }
                Console.WriteLine("");

                userChoice = CLI.GetUserChoice("Хотите восстановить вопросы по умолчанию?");
                Console.WriteLine("");
                if (userChoice)
                {
                    QuestionsStorage.RestoreQuestions();
                }
                Console.WriteLine("");

                userChoice = CLI.GetUserChoice("Хотите повторить тест?");
                Console.WriteLine("");
                if (userChoice == false)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(userName + ", пройдем тест снова, удачи!");
                    user.RightAnswersCount = 0;
                }
                Console.WriteLine("");
            }
        }

        private static void AddNewQuestion()
        {
            Console.WriteLine("Введите текст вопроса:");
            var text = Console.ReadLine();

            Console.WriteLine("Введите ответ на вопрос:");
            var answer = CLI.GetNumber();

            var newQuestion = new Question(text, answer);

            QuestionsStorage.Add(newQuestion);
        }

        private static void RemoveQuestion()
        {
            var questions = QuestionsStorage.GetQuestions();
            if (questions.Count != 1)
            {
                Console.WriteLine("Введите номер удаляемого вопроса:");


                for (var i = 0; i < questions.Count; i++)
                {
                    Console.WriteLine(i + 1 + ". " + questions[i].Text);
                }

                var removeQuestionNumber = CLI.GetNumber();
                while (removeQuestionNumber < 1 || removeQuestionNumber > questions.Count)
                {
                    Console.WriteLine("Введите число от 1 до " + questions.Count);
                    removeQuestionNumber = CLI.GetNumber();
                }

                var removeQuestion = questions[removeQuestionNumber - 1];
                QuestionsStorage.Remove(removeQuestion);
            }
            else
            {
                Console.WriteLine("Нельзя удалить все вопросы!");

            }
        }

        private static void ShowUsersResults()
        {
            var tableFormat = "{0,-20}{1,-33}{2,0}";
            var results = UserResultsStorage.GetUsersResults();

            Console.WriteLine(tableFormat, "Имя", "Кол-во правильных ответов", "Диагноз");
            Console.WriteLine();

            foreach (var user in results)
            {
                Console.WriteLine(tableFormat, user.Name, user.RightAnswersCount, user.Diagnose);
            }
            Console.WriteLine();
        }
    }
}