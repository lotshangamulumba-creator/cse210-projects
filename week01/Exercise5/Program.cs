using System;

class Program
{
    static void Main(string[] args)
    {
      DisplayWelcome();
      string UserName = PromptUserName();
      Console.WriteLine($"Hey {UserName}!") ;
      int user_numb = PromptUserNumber ();
      Console.Write("oh! that's interesting ");
      int Square_Number = SquareNumber(user_numb);
      Console.WriteLine(UserName);
      Console.WriteLine($"the square of your favorite number is: {Square_Number}");
      
    }
     static void  DisplayWelcome()
        {
            Console.WriteLine("welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name:");
            string username = Console.ReadLine();
            return username;
        }
        static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number:");
        string user_numb = Console.ReadLine();
        int userFavoriteNumb = int.Parse(user_numb);
        return userFavoriteNumb;
        }
        static int SquareNumber(int user_numb)
    {
        int square_numb = user_numb * user_numb;
        return square_numb;
    }
}