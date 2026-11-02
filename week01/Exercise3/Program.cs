using System;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.Versioning;

class Program
{
    static void Main(string[] args)
    {
      int guess_numb = 0  ;
      int number = 1;
      Console.WriteLine("what is your magic number");
        string magic_numb = Console.ReadLine();
         number = int.Parse(magic_numb);
      while(guess_numb != number)
        {
        Console.WriteLine("what is your guess?");
        string user_guess = Console.ReadLine();
        guess_numb = int.Parse(user_guess);
        if (guess_numb > number)
        {
          Console.WriteLine("Lower");
        }
        else if (guess_numb < number)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
    }
        }
       
}