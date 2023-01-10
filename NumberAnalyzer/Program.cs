Console.Write("Please Enter your name: ");
string name = Console.ReadLine();
bool restart = true;
do
{
    Console.Write("Enter an integer between 1 and 100. ");
    int number = int.Parse(Console.ReadLine());
    if (number < 60 && number % 2 > 0)
    {
        Console.WriteLine("Hello " + name + ", " + number + " is odd and less than 60.");
    }
    else if (number >= 2 && number <= 24 && number % 2 == 0)
    {
        Console.WriteLine("Hello " + name + ", " + number + " is even and less than 25.");
    }
    else if (number >= 26 && number <= 60 && number % 2 == 0)
    {
        Console.WriteLine("Hello " + name + ", " + number + " is even and between 26 and 60.");
    }
    else if (number > 60 && number % 2 == 0)
    {
        Console.WriteLine("Hello " + name + ", " + number + " is even and greater than 60.");
    }
    else if (number > 60 && number % 2 > 0)
    {
        Console.WriteLine("Hello " + name + ", " + number + " is odd and greater than 60.");
    }
    else
    {
        Console.WriteLine(name + ", that input is invalid..");
    }
    Console.WriteLine("Would you like to enter another number?");
    string choice = Console.ReadLine().ToLower().Trim();
    if (choice == "y" || choice == "yes")
    {
        restart = true;
    }
    else
    {
        restart = false;
    }
} while (restart == true);
Console.WriteLine("Goodbye " + name + "!");


