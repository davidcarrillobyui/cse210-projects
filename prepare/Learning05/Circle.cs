
public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Override the GetArea method to calculate the area of a circle
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}
