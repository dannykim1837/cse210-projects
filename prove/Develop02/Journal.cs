public class Journal
    {
        public List<Entry> Entries { get; } = new List<Entry>();

        public void AddEntry(Entry entry)
        {
            Entries.Add(entry);
        }
    }