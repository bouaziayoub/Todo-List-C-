// Declare variables
string[] todoList = { "Comer a las ocho", "Dormir temprano" };


Console.WriteLine("Hello!");

// Call the menu
Menu();
// Insert a choice of the menu
var inputUser = Console.ReadLine();

while (inputUser.ToUpper() != "E")
{
    if (inputUser.ToUpper() == "A")
    {
        Console.WriteLine("Add a TODO: ");
        var addTodo = Console.ReadLine();
        Array.Resize(ref todoList, todoList.Length + 1);
        todoList[todoList.Length - 1] = addTodo;

        // Call Menu
        Menu();
    }
    else if (inputUser.ToUpper() == "S")
    {
        // Call method PrintTodoList
        PrintTodoList(todoList);

        // Call Menu
        Menu();

    }
    else if (inputUser.ToUpper() == "R")
    {

        // Print the list of todo
        PrintTodoList(todoList);

        //Array.Resize(ref todoList, todoList.Length - 1);
        Console.WriteLine("Choose the number of the todo to eliminate.");
        var input = Console.ReadLine();

        // Use a boolean to check if the input is a valid integer
        bool isValidInput = TryGetItemIndex(input, out int itemToEliminate);

        itemToEliminate--;

        // Check if the input index is valid
        if (itemToEliminate < 0 || itemToEliminate >= todoList.Length)
        {
            Console.WriteLine("Invalid item number.");
        }
        else
        {
            Console.WriteLine("You choosed to delete item number " + (itemToEliminate + 1));
            todoList = todoList.Where((val, idx) => idx != itemToEliminate).ToArray();
            Console.WriteLine("Updated Todo List:");
            PrintTodoList(todoList);
        }

        // call menu
        Menu();
    }
    else
    {
        Console.WriteLine("You pressed something that is not in the menu!");
    }

    // Prompt for user input again at the end of each iteration
    inputUser = Console.ReadLine();
}


//Methon to print the menu
static void Menu()
{

    Console.WriteLine("");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
    Console.WriteLine("");

}


static void PrintTodoList(string[] todoList)
{
    if (todoList.Length == 0)
    {
        Console.WriteLine("Your Todo List is empty ");
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("Your Todo List: ");
        Console.WriteLine("");

        for (int i = 0; i < todoList.Length; i++)
        {
            Console.WriteLine((i + 1) + ") " + todoList[i]);
        }
    }
}


static bool TryGetItemIndex(string input, out int itemToEliminate)
{
    return int.TryParse(input, out itemToEliminate);
}
Console.WriteLine("Exiting the program...");
Console.ReadKey(); // Waits for the user to press a key

