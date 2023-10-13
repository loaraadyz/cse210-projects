public class Shape
{
    private string _color;
    private double _area;

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public Shape(string input)
    {
        SetColor(input);
        GetColor();

    }

    public virtual double GetArea()
    {
        return _area;
    }


}