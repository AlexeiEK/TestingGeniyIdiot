using Newtonsoft.Json;

namespace GeniyIdiot.Common
{
    public class UserResultsStorage
    {
        private static string pathFile = "usersResults.json";

        public static void Append(User user)
        {
            var usersResults = GetUsersResults();
            usersResults.Add(user);
            Save(usersResults);
        }

        public static List<User> GetUsersResults()
        {
            if (!FileProvider.Exists(pathFile))
            {
                return new List<User>();
            }

            var fileData = FileProvider.GetValue(pathFile);
            var usersResults = JsonConvert.DeserializeObject<List<User>>(fileData);
            return usersResults;
        }

        public static void Save(List<User> usersResults)
        {
            var jsonData = JsonConvert.SerializeObject(usersResults, Formatting.Indented);
            FileProvider.Replace(pathFile, jsonData);
        }
    }
}
