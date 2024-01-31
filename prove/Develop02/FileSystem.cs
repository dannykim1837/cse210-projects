public class FileSystem
    {
        public static void SaveToFile(string fileName, Journal journal)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var entry in journal.Entries)
                {
                    writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
                }
            }
        }
    public static Journal LoadFromFile(string fileName)
    {
        Journal loadedJournal = new Journal();
        return loadedJournal;
    }
    }