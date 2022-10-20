using System;
using System.Collections.Concurrent;

string[] studentName = new string[] { "Daniel", "Jennifer", "Chloe", "Bob" };

string[] hometown = new string[] { "Biggleswade", "Mt Morris", "Grand Blanc", "New York" };

string[] favoriteFood = new string[] { "Pizza", "Mexican", "Mac and Cheese", "Hot Dogs" };

int arrayLength = studentName.Length;
int studentID = 0;

Console.WriteLine($"Hello. Which student would you like to learn about?");
while (true)
{
    while (true)
    {
        Console.WriteLine($"Enter a number between 1 and {arrayLength} or to view a list of all students type 'list'.");
        string userInput = Console.ReadLine();
        int numberInput;
        bool isNum = int.TryParse(userInput, out numberInput);
        studentID = numberInput - 1;
        string userInputTrimmed = userInput.Trim().ToLower();
        if (!isNum)
        {
            if (userInputTrimmed.ToLower() == "list")
            {
                studentID = 1;
                foreach (string s in studentName)
                {
                    Console.WriteLine($"{studentID++} - {s}");
                }
                continue;
            }
            else
            {
                Console.WriteLine("That is not a number.");
                continue;
            }
        }
        if (numberInput < 1 || numberInput > arrayLength)
        {
            Console.WriteLine("That student number does not exist.");
            continue;
        }
        else
        {
            Console.WriteLine($"Student {numberInput} is {studentName[studentID]}.");
            break;
        }
    }

    Console.WriteLine("What other information would you like to know?");
    while (true)
    {
        Console.WriteLine("Enter 'hometown' or 'favorite food':");
        string categoryInput = Console.ReadLine();
        string trimmedInput = categoryInput.ToLower().Trim();
        if (trimmedInput.Contains("town") || trimmedInput.Contains("home"))
        {
            Console.WriteLine($"{studentName[studentID]} is from {hometown[studentID]}.");
            break;
        }
        else if (trimmedInput.Contains("food"))
        {
            Console.WriteLine($"{studentName[studentID]}'s favorite food is {favoriteFood[studentID]}.");
            break;
        }
        else
        {
            Console.WriteLine("That category does not exist.");
            continue;
        }
    }
    Console.WriteLine("Would you like to learn about another student? (y/n)");
    string continueInput = Console.ReadLine().ToLower();
    if (continueInput == "y")
    {
        continue;
    }
    else
    {
        Console.WriteLine("Thankyou. Goodbye.");
        break;
    }


}
