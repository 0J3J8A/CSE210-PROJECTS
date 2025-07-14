using System;

public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction() //Default Fraction
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int top) //ONLY the top number
    {
        _topNumber = top;
        _bottomNumber = 1;
    }

    public Fraction(int top, int bottom) // Using both numbers
    {
        _topNumber = top;
        _bottomNumber = bottom;
    }

    public string GetFractionString()
    {
        string txt = $"{_topNumber}/{_bottomNumber}";
        return txt;
    }

    public double GetDecimalValue()
    {
        return (double)_topNumber / (double)_bottomNumber;
    }


}