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

        using (StreamReader reader = new StreamReader(fileName))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] parts = line.Split(',');

                if (parts.Length == 3 &&
                    DateTime.TryParse(parts[0], out DateTime date))
                {
                    Entry entry = new Entry
                    {
                        Date = date,
                        Prompt = parts[1],
                        Response = parts[2]
                    };

                    loadedJournal.AddEntry(entry);
                }
            }
        }

        return loadedJournal;
    }
    }