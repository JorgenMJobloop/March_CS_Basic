public class Circle : Shapes
{
    public double A { get; set; }
    public double B { get; set; }

    public override double GetArea()
    {
        var r = A * B;
        return Math.PI / 2 * Math.Pow(r, 2);
    }

    public override double GetCircumference()
    {
        var r = A * B;
        return 2 * Math.PI * r;
    }

    public override double GetDiameter()
    {
        throw new NotImplementedException();
    }
}