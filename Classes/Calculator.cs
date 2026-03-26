public class Calculator
{
    public double Xvalue;
    public double YValue;
    public double AddNumbers(double num1, double num2)
    {
        return num1 + num2;
    }

    public double SubtractNumbers(double num1, double num2)
    {
        return num1 - num2;
    }

    public void PrintXandY()
    {
        Console.WriteLine($"X value: {Xvalue}, Y value: {YValue}");
    }
}