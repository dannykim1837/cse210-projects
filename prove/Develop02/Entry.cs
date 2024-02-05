public class Entry
    {
        public string Prompt;
        public string Response;
        public DateTime Date;
        
        // random prompt list
        public string GetRandomPrompt()
        {
            List<string> prompts = new List<string>
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?"
            };

            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
        


        public Entry(string line)
        {
            var parts = line.Split(",");
            Date = DateTime.Now;
            Prompt = parts[0];
            Response = parts[1];
        }

        public Entry() { }  
    }