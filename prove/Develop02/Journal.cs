public class Journal
    {
        //entry
        public List<Entry> Entries { get; } = new List<Entry>();

        public Journal(string[] importLines = null)
        {
            if (importLines != null)
            {
                foreach (var line in importLines)
                {
                    var entry = new Entry(line);
                    Entries.Add(entry);
                }
            }
        }

        // add
        public void AddEntry(Entry entry)
        {
            Entries.Add(entry);
        }

        
        // for save
        public string[] Export()
        {
            var exportLines = new List<string>();
            foreach (var entry in Entries)
            {
                exportLines.Add($"{entry.Prompt},{entry.Response},{entry.Date}");
            }
            return exportLines.ToArray();
        }
    }