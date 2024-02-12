public class Reference {
    public string Book;
    public string Chapter;
    public string Verse;

    public Reference(string line)
        {
            var parts = line.Split(",");
            Book = parts[0];
            Chapter = parts[1];
            Verse = parts[2];
        }


}