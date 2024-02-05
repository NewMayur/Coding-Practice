
Console.WriteLine("Program started");

Console.WriteLine("Type \'exit\' to end the program");

string name;

do
{
    Console.Write("Enter your name: ");
    name = Console.ReadLine();

    if (name == "Tim")
    {
        Console.WriteLine("Hello Professor Tim");
        break;

    }
    else if (name == "exit")
    {
        break;

    }

    else
    {
        Console.WriteLine($"Hello student {name}");

    }

} while (true);


Console.WriteLine("Program ended");