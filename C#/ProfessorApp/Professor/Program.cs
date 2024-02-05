Console.WriteLine("Program started");
Console.WriteLine();

Console.Write("Enter your name: ");
string? name = Console.ReadLine();
bool isNameValid = name?.ToLower() == "sue" || name?.ToLower() == "bob";


if (!isNameValid)
{
    Console.WriteLine("Sorry. You're not registered");
} 
else
{
    Console.Write("Enter your age: ");
    string? ageText = Console.ReadLine();
    if (int.TryParse(ageText, out int age))
    {
        if (age < 21)
        {
            Console.WriteLine("Please wait for " + (21 - age) + " years for your class.");
        }

        else
        {
            Console.WriteLine($"Hello Professor {name}");
        }
    }

    else
    {
        Console.WriteLine("Invalid age input. Please enter a valid number");
    }
}



if (isNameValid == true)
{
    
    {
        Console.WriteLine();
    }

}

Console.WriteLine();
Console.WriteLine("Program ended");