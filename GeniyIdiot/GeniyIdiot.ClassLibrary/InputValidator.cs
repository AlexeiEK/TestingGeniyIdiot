namespace GeniyIdiot.Common
{
    public class InputValidator
    {
        public static bool TryParseToNumber(string input, out int number, out string errorMessage)
        {
            try
            {
                number = Convert.ToInt32(input);
                errorMessage = "";
                return true;
            }
            catch (FormatException)
            {
                errorMessage = "Введите, пожалуйста, число без пробелов!";
                number = -2 * 10 ^ 9;
                return false;
            }
            catch (OverflowException)
            {
                errorMessage = "Введите, пожалуйста, число от -2*10^9 до 2*10^9!";
                number = -2 * 10 ^ 9;
                return false;
            }
        }
    }


}
