public class Reference
{
    private string[] references = {
        "John 3:16",
        "John 3:17",
        "John 3:18",
        "John 3:19",
        "John 3:20",
        "John 3:21",
        "John 3:22"
    };

    public string GetRandomReference()
    {
        Random random = new Random();
        int index = random.Next(references.Length);
        return references[index];
    }
}
