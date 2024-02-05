Console.Write("What is your name?: ");
string? name = Console.ReadLine();

//if (name.ToLower() == "tim"
//    || name.ToLower() == "timothy")
//{
//    Console.WriteLine("Hello professor");
//}

//else
//{
//    Console.WriteLine("Sorry don't know you.");
//}

switch (name)
{
    case "tim" or "timothy":
        Console.WriteLine("Hello professor");
        break;

    default:
        Console.WriteLine("Sorry don't know you.");
        break;
}