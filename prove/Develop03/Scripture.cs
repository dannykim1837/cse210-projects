public class Scripture
{
    private Reference reference;
    private List<string> scriptures = new List<string>
    {
        "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
        "For God sent not his Son into the world to condemn the world; but that the world through him might be saved.",
        "He that believeth on him is not condemned: but he that believeth not is condemned already, because he hath not believed in the name of the only begotten Son of God.",
        "And this is the condemnation, that light is come into the world, and men loved darkness rather than light, because their deeds were evil.",
        "For every one that doeth evil hateth the light, neither cometh to the light, lest his deeds should be reproved.",
        "But he that doeth truth cometh to the light, that his deeds may be made manifest, that they are wrought in God.",
        "After these things came Jesus and his disciples into the land of Juda; and there he tarried with them, and baptized."
    };

    private List<Word> words = new List<Word>();
    private List<int> hiddenWordIndices = new List<int>();
    private int currentSentenceIndex = 0;

    public Scripture(Reference scripture)
    {
        reference = scripture;
        InitializeWords();
    }

    private void InitializeWords()
    {
        string currentSentence = GetCurrentSentence();
        string[] parts = currentSentence.Split(" ");
        foreach (string part in parts)
        {
            Word word = new Word(part);
            words.Add(word);
        }
    }

    private string GetCurrentSentence()
    {
        return scriptures[currentSentenceIndex];
    }

    public string GetVisibleScripture()
    {
        string visibleScripture = reference.GetRandomReference() + "\n";
        foreach (Word word in words)
        {
            visibleScripture += word.Text + " ";
        }
        return visibleScripture;
    }

    public bool HasHiddenWords()
    {
        return hiddenWordIndices.Count < words.Count;
    }

    public bool HideRandomWord()
    {
        try
        {
            Random rand = new Random();
            int hrw;
            do
            {
                hrw = rand.Next(words.Count);
            } while (words[hrw].IsHidden()); // Keep selecting a random word until it's not hidden

            words[hrw].HideWord();
            hiddenWordIndices.Add(hrw);

            // Check if all words in the current sentence are hidden
            if (!HasHiddenWords())
                return false; // All words are hidden
            return true; // Not all words are hidden
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            return false;
        }
    }

    public void MoveToNextSentence()
    {
        currentSentenceIndex++;
        words.Clear(); // Clear the words list for the new sentence
        InitializeWords();
        hiddenWordIndices.Clear(); // Reset hidden word indices
    }

    public bool HasNextSentence()
    {
        return currentSentenceIndex < scriptures.Count - 1;
    }
}