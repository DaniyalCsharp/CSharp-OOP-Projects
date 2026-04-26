
using System;
class Calculator
{
    public double Add(double a, double b)
    {
        return a + b;
    }
    public double Subtract(double a, double b)
    {
        return a - b;
    }
    public double Multiply(double a, double b)
    {
        return a * b;
    }
    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Cannot be divided by zero");
            return 0;
        }
        return a / b;
    }
}
class Program
{
    static void Main()
    {
        Calculator calc= new Calculator();

        Console.WriteLine("-----Simple Calculator----");

        Console.WriteLine("Enter First number");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Second number");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Choose Operation");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        int choice = Convert.ToInt32(Console.ReadLine());
        double result = 0;

        if (choice == 1)
        {
            result = calc.Add(num1, num2);
        }
        else if(choice==2)
        {
            result = calc.Subtract(num1, num2);
        }
        else if(choice==3)
        {
            result = calc.Multiply(num1, num2);
        }
        else if(choice==4)
        {
            result = calc.Divide(num1, num2);
        }
        else
        {
            Console.WriteLine("Invalid choice");
            return;
        }
        Console.WriteLine("Result =" + result);
    }

}