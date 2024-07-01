using System.Text;

class SaveLoadCSV
{
    // Save data to a CSV file
    public static void SaveToCSV(List<String> _dataToSave, string _filePath)
    {
        File.WriteAllLines(_filePath, _dataToSave);
    }

    // Load data from a CSV file
    public static List<String> LoadFromCSV(string _filePath)
    {
        List<string> fromCSV = new List<string>();
        using (StreamReader streamReader = new StreamReader(_filePath))
        {
            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                fromCSV.Add(line);
            }
        }

        return fromCSV;
    }
}
