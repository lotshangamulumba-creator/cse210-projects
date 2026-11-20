using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("----------------------g");
        Console.WriteLine("GetFractionString Test");
        Console.WriteLine("----------------------");
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine("--------------------");
        Console.WriteLine("GetDecimalValue Test");
        Console.WriteLine("--------------------");
        Console.WriteLine(f1.GetDecimalvalue());
        Console.WriteLine(f2.GetDecimalvalue());
        Console.WriteLine(f3.GetDecimalvalue());
        Console.WriteLine(f4.GetDecimalvalue());
    }
}