public class Entry
    {
        public string Prompt { get; set; }
        public string Response { get; set; }
        public DateTime Date { get; set; }

        // Constructor that takes a string
        public Entry(string line)
        {
            var parts = line.Split(",");
            Date = DateTime.Now;
            Prompt = parts[0];
            Response = parts[1];
        }

        public Entry() { }  // Default constructor

        public string Export()
        {
            return $"{Prompt},{Response},{Date}";
        }
    }