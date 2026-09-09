using System;

public enum enOperation
{
    Add,
    Subtract,
    Multiply,
    Divide
}

public class Calculator
{
    public double Calculate(double a, double b, enOperation operation)
    {
        switch (operation)
        {
            case enOperation.Add: return a;
            case enOperation.Subtract: return a - b;
            case enOperation.Multiply: return a * b;
            case enOperation.Divide: return b == 0 ? double.NaN : a / b;
            default: throw new ArgumentException("Invalid operation");
        }
    }
}

public static class Program
{
    public static void Main()
    {
        
            Console.WriteLine("Enter first number:");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter operation (Add, Subtract, Multiply, Divide):");
            string operationString = Console.ReadLine();
            enOperation operation = (enOperation)Enum.Parse(typeof(enOperation), operationString);
            Calculator calculator = new Calculator();
            double result = calculator.Calculate(num1, num2, operation);
            if (double.IsNaN(result))
            {
                Console.WriteLine("Error: Division by zero.");
            }
            else
            {
                Console.WriteLine($"Result: {result}");
            }
              
    }
}