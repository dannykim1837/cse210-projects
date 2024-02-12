public class Word {
    public void HideRandomWords(string text)
    {
        Random rand = new Random();
        string[] words = text.Split(' ');
        int wordsToHideCount = rand.Next(1, words.Length); // Randomly select number of words to hide

        for (int i = 0; i < wordsToHideCount; i++)
        {
            int index = rand.Next(0, words.Length); // Randomly select index of word to hide
            words[index] = new string('_', words[index].Length); // Replace word with underscores
        }

        text = string.Join(" ", words);
        Console.WriteLine(text);
    }
}