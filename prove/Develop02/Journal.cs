public class Journal
    {
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

        public void AddEntry(Entry entry)
        {
            Entries.Add(entry);
        }

        public string[] Export()
        {
            var exportLines = new List<string>();
            foreach (var entry in Entries)
            {
                exportLines.Add(entry.Export());
            }
            return exportLines.ToArray();
        }
    }