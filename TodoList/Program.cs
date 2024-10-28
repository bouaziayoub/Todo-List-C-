Console.WriteLine("Hello!");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

string inputUser = Console.ReadLine();

while (inputUser.ToUpper() != "E")
{
    if (inputUser.ToUpper() == "A")
    {
        Console.WriteLine("You pressed A");
    }
    else if (inputUser.ToUpper() == "S")
    {
        Console.WriteLine("You pressed S");
    }
    else if (inputUser.ToUpper() == "R")
    {
        Console.WriteLine("You pressed R");
    }
    else
    {
        Console.WriteLine("You pressed something that is not in the menu!");
    }

    // Prompt for user input again at the end of each iteration
    inputUser = Console.ReadLine();
}

Console.WriteLine("Exiting the program...");
Console.ReadKey(); // Waits for the user to press a key
