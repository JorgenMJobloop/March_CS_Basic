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

    public double MultiplyNumbers(double num1, double num2)
    {
        return num1 * num2;
    }

    public int DivideNumbers(int num1, int num2)
    {
        try
        {
            return num1 / num2;
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine($"Cannot divide by 0 {e.Message}");
        }
        return num1 / num2;
    }

    public double DivideNumbers(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Cannot divide by 0");
        }
        return num1 / num2;
    }

    public double GetPower(double number, double exponent)
    {
        return Math.Pow(number, exponent);
    }

    public void PrintXandY()
    {
        Console.WriteLine($"X value: {Xvalue}, Y value: {YValue}");
    }
}