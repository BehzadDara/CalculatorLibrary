namespace CalculatorLibrary;

public static class Calculator
{
    public static double Add(params double[] numbers)
    {
        return numbers.Sum();
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static double Multiply(params double[] numbers)
    {
        return numbers.Aggregate(1.0, (result, number) => result * number);
    }

    public static double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }
        return a / b;
    }

    public static double Modulus(double a, double b)
    {
        return a % b;
    }

    public static double Power(double a, double b)
    {
        return Math.Pow(a, b);
    }

    public static double SquareRoot(double number)
    {
        return Root(number, 2);
    }

    public static double Root(double number, double n)
    {
        if (n == 0)
        {
            throw new ArgumentOutOfRangeException(nameof(n), "The value of n cannot be zero.");
        }
        if (number < 0 && n % 2 == 0)
        {
            throw new ArgumentOutOfRangeException(nameof(number), "Cannot calculate the even root of a negative number.");
        }
        return Math.Pow(number, 1.0 / n);
    }

    public static long Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(number), "Factorial is not defined for negative numbers.");
        }
        if (number == 0 || number == 1)
        {
            return 1;
        }
        long result = 1;
        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }
}
