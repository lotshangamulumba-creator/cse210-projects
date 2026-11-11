                  // Creativity: //
//-------------------------------------------------------//
// - Added 15 journal prompts instead of the minimum set//
// - Added a personalized welcome experience           //
// - Added confirmation messages after writing entries//
//---------------------------------------------------//

using System;
using System.Reflection.Metadata;

public class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("Please enter your name:");
        string user_choice = "";
        string user_response = "";
        string user_name = Console.ReadLine();
        Console.WriteLine($"Hi {user_name}!");
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (user_choice != "5")
         { 
            Console.WriteLine("what do you want to do today?");
             Console.WriteLine("----------");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.WriteLine("----------");
            user_choice = Console.ReadLine();

            if(user_choice =="1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                user_response = Console.ReadLine();
                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = prompt;
                newEntry._entryText = user_response;
                journal.AddEntry(newEntry);
               
            }
            
            if (user_choice =="2")
            {
                journal.DisplayAll();
                
            }
            if (user_choice == "3")
            {
                journal.LoadFromFile();
            }
            if (user_choice == "4")
            {
                journal.SaveToFile();
                
            }
            if (user_choice == "5")
            {
                Console.WriteLine("OK!, I've stopped generating the prompt.");
                break;
            }

            }
    }
}