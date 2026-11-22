using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference ("Proverbs", 3, 5, 6);
        Scripture scripture = 
        new Scripture (
            reference , "Trust in the Lord with all thine heart"
        );
        string userInput = "";
        while(!scripture.IsCompletlyHidden() &&
                   userInput.ToLower() !="quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("press Enter to continue or type 'quit' to finish");
            userInput = Console.ReadLine();
            if(userInput.ToLower() !="quit")
            {
                scripture.HideRandomWords(1);
            }

            
        }
        
    }
}