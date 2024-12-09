using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SimonovMA.Sprint6.Task6.V12.Lib
{
    public class DataService : ISprint6Task6V12
    {
        public string CollectTextFromFile(string path)
        {
            var content = File.ReadAllText(path);

            var result = content
                    .Split(new[] { ' ', '\n', '\r', '\t', ',', '.', '!', '?', ';', ':', '(', ')', '[', ']', '{', '}' }, StringSplitOptions.RemoveEmptyEntries)
                    .Where(word => word.Contains('w', StringComparison.OrdinalIgnoreCase))
                    .Aggregate((current, next) => $"{current} {next}");

            return Convert.ToString(result);
        }
    }
}
