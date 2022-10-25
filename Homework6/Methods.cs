

Console.WriteLine("Which method do you want to look at? (ShowCharacter, RetailPrice, TemperatureTable, or PrimeNumbers?)");
string answer = Console.ReadLine().ToUpper();
switch(answer)
{
    case "SHOWCHARACTER":
        Console.WriteLine("Type some random words/letters: ");
        string a = Console.ReadLine();
        Console.WriteLine("Type a random number: ");
        int b = Int32.Parse(Console.ReadLine());
        ShowCharacter(a, b);
        break;
    case "RETAILPRICE":
        Console.WriteLine("What is the wholesale cost: ");
        double cost = Double.Parse(Console.ReadLine());
        Console.WriteLine("What is the markup percentage:");
        int markup = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"The total price will be ${CalculateRetail(cost, markup)}.");
        break;
    case "TEMPERATURETABLE":
        for (double temp = 80; temp <= 100; temp++)
        {
            Fahrenheit(temp);
        }
        break;
    case "PRIMENUMBERS":
        Console.WriteLine("Enter the number do you want to test: ");
        int prime = Int32.Parse(Console.ReadLine());
        if (IsPrime(prime))
            Console.WriteLine($"{prime} IS a prime number");
        else
            Console.WriteLine($"{prime} is NOT a prime number");
        break;
    default:
        Console.WriteLine("Try typing the words right");
        break;

}




static void ShowCharacter(string x, int y)
{
    char c = x[y];
    Console.WriteLine($"The character in position {y} for the string {x} is {c}.");
    Console.WriteLine("Remember, the string position starts at 0.");
}

static double CalculateRetail(double cost, int markup)
{
        double totalPrice = Math.Round((cost + (cost * (markup / 100))),2);
    return totalPrice;
}
    
static void Fahrenheit(double temp)
{
    double newTemp = temp - 32;
    double celsius = Math.Round(((temp - 32) * 5 / 9), 2);
    
    Console.WriteLine($"Fahrenheit of {temp} is equal to {celsius} degrees Celsius.");

}

/*
write a method named isprime, which takes an integer as an
argument and returns true if the argument is a prime number
or false otherwise. demonstrate the method in a complete
program. 
*/

static bool IsPrime(int prime)
{
    if (prime <= 2)
        return false;
    for (int a = 2; a < prime; a++)
    {
        
        if (prime % a == 0)
            return false;
    }
    return true;
}
