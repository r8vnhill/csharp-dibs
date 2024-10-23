namespace Exceptions;

public static class Divider
{
    public static int Divide(int dividend, int divisor)
    {
        if (divisor == 0) throw new ArgumentException("Divisor cannot be zero", nameof(divisor));
        return dividend / divisor;
    }

    public static int SafeDivide(int dividend, int divisor)
    {
        try
        {
            return Divide(dividend, divisor);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
            return 0;
        }
    }
}