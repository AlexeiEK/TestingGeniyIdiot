using System;

namespace GeniyIdiot.Common
{
    public class CLI
    {
        public static string InputUserName(string message)
        {
            string userName;
            var flag = true;
            while (true)
            {
                do
                {
                    Console.WriteLine(message);
                    userName = Console.ReadLine();
                    if (string.IsNullOrEmpty(userName))
                    {
                        Console.WriteLine("Введите, пожалуйста, хотябы один символ!");
                        Console.WriteLine();
                    }
                    else
                    {
                        flag = false;
                    }
                } while (flag);
                return userName;
            }
        }

        public static int GetNumber()
        {
            int number;
            while (!InputValidator.TryParseToNumber(Console.ReadLine(), out number, out string errorMessage))
            {
                Console.WriteLine(errorMessage);
            }
            return number;
        }

        public static bool GetUserChoice(string message)
        {
            while (true)
            {
                Console.WriteLine(message + " Введите Да или Нет!");
                var userInput = Console.ReadLine();
                if (userInput?.ToLower() == "да" || userInput?.ToLower() == "yes" || userInput?.ToLower() == "lf" || userInput?.ToLower() == "нуы")
                {
                    return true;
                }
                if (userInput?.ToLower() == "нет" || userInput?.ToLower() == "no" || userInput?.ToLower() == "ytn" || userInput?.ToLower() == "тщ")
                {
                    return false;
                }
            }
        }
    }
}
