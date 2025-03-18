public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructors 
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getters and setters
    public int GetTop()
    {
        return _top;
    }

    // Setters should accept a single parameter and have a void return type.
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getters should not have any parameters and should not prompt the user for anything, but instead, simply return a value.
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Methods
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        if (_bottom == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        return (double)_top / (double)_bottom;
    }


}