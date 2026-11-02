using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("what is your grade percentage?");
        string grade_percentage = Console.ReadLine();
        int number = int.Parse(grade_percentage);
        Console.WriteLine($"Your grade percentage is {grade_percentage}");
        if (number >= 90)
        {
          Console.WriteLine("Your grade is A");

        }
        else if (number >= 80 )
        {
            Console.WriteLine("Your grade is B");
        }
        else if (number >= 70)
        {
            Console.WriteLine("Your grade is C");
        }
        else if (number >= 60)
        {
            Console.WriteLine("Your grade is D");
        }
        else if (number > 60)
        {
            Console.WriteLine("F");
        }
        if (number >70)
        {
            Console.WriteLine("Congratulations! you passed the course.");
        }
        else if (number < 70)
        {
            Console.WriteLine("Better luck next time");
        }


    }
}