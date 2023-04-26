using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            string userResponse = Console.ReadLine();
            
            userNumber = int.Parse(userResponse);
            
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
    
    }
}