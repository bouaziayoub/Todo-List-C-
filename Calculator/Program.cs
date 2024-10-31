// See https://aka.ms/new-console-template for more information


for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.WriteLine(j);
    }
}

//for (int i = 1; i <= 5; i++)
//{
//    Console.WriteLine(i);
//}


//---------------------------------------------------------------------------------

Console.WriteLine("Hello!");

int firstNumber = 0, secondNumber = 0;


// Entre The fist number
firstNumber = hundelNumbers(firstNumber, "first");

// Entre the second number
secondNumber = hundelNumbers(secondNumber, "second");


Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
string userChoice = Console.ReadLine().ToUpper();
switch (userChoice)
{
    case "A":
        Console.WriteLine("The sum of these two numbers is: " + (firstNumber + secondNumber));
        break;
    case "S":
        Console.WriteLine("The difference of these two numbers is: " + (firstNumber - secondNumber ));
        break;
    case "M":
        Console.WriteLine("The product of these two numbers is: " + (firstNumber * secondNumber));
        break;
    default:
        Console.WriteLine("You haven't chosen a valid option from the menu!");
        break;
}


int hundelNumbers(int number, string msg)
{
    while (true)
    {
        try
        {
            Console.Write("Enter " + msg + " number ");
            number = int.Parse(Console.ReadLine());
            return number;
        }
        catch (FormatException)
        {
            Console.WriteLine("This is not a number!");
        }
    }
}

Console.WriteLine("Press a key to exit");
Console.ReadKey();