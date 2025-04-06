public abstract class Shapes
{
    public string _color;
    public abstract double GetArea();

    public Shapes(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }
}