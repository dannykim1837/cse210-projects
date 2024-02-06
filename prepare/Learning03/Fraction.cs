public class Fractoin
{
    public int _top;
    public int _bottom;

    public Fractoin() {
        _top = 1;
        _bottom = 1;
    }
    public Fractoin(int wholeNumber) {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fractoin(int top, int bottom) {
        _top = top;
        _bottom = bottom;
    }

    //public GetTop() {}
    //public SetTop(int top) {}
    //public GetBottom() {}
    //public SetBottom(int bottom) {}

    public string GetFractionString() {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue() {
        return (double)_top / (double)_bottom;
    }

}