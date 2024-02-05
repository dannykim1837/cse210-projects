public class Entry
    {
        public string Prompt;
        public string Response;
        public DateTime Date;


        public Entry(string line)
        {
            var parts = line.Split(",");
            Date = DateTime.Now;
            Prompt = parts[0];
            Response = parts[1];
        }

        public Entry() { }  
    }