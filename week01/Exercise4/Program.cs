using System;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Enter a list of numbers, type 0 when finished.");
       int  user_number = -1;
       List <int> numbers = new List<int>();
       int sum = 0;
       int largest = -2;

        while(user_number != 0)
            {
            Console.WriteLine("Enter number: ");
            string number = Console.ReadLine();
            user_number = int.Parse(number);
            if (user_number != 0)
                {
                    numbers.Add(user_number);
                    Console.WriteLine($"You entered:{user_number}");
                }
            }
                foreach(int item in numbers)
                {
                sum += item;
                if (item > largest)
            {
                largest = item;
            }
                } 
                Double average = sum /numbers.Count;
            Console.WriteLine($"Here is the sum:{sum}"); 
            Console.WriteLine($"the average is: {average}");
            Console.WriteLine($"The largest number is:{largest}");


    }
}