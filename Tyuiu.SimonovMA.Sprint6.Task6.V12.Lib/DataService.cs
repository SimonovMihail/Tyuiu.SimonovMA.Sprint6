using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SimonovMA.Sprint6.Task6.V12.Lib
{
    public class DataService : ISprint6Task6V12
    {
        public string CollectTextFromFile(string path)
        {
                var content = File.ReadAllText(path);

                var filteredWords = content
                    .Split(new[] { ' ', '\r', '\n', '\t', ',', '.', '!', '?', ';', ':', '-', '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
                    .Where(word => word.Contains('w') && !word.Contains('W'));

                return string.Join(" ", filteredWords);
        }
    }
}
