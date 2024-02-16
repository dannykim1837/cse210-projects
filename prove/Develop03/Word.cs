public class Word
{
    private string text;
    private bool hidden;

    public Word(string text)
    {
        this.text = text;
        this.hidden = false;
    }

    public string Text
    {
        get { return hidden ? "______" : text; }
    }

    public bool IsHidden()
    {
        return hidden;
    }

    public void HideWord()
    {
        hidden = true;
    }
}
