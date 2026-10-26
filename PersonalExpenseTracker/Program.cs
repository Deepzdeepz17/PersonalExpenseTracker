
Console.WriteLine("Welcome! Manage your expenses easily!");
Console.WriteLine("-------------------------");

Console.WriteLine("1. Add Expense");
Console.WriteLine("2. Exit");

Console.Write("Choose an option: ");
string? choice = Console.ReadLine();

if (choice == "1")
{
    Console.Write("Enter expense category: ");
    string? category = Console.ReadLine();

    Console.Write("Enter expense amount: ");
    string? amountInput = Console.ReadLine();

    if (decimal.TryParse(amountInput, out decimal amount) && amount > 0)
    {
        Console.WriteLine($"Expense added: {category} - {amount:F2}");
    }
    else
    {
        Console.WriteLine("Please enter a valid amount greater than zero.");
    }
}
else if (choice == "2")
{
    Console.WriteLine("Goodbye!");
}
else
{
    Console.WriteLine("Invalid option.");
}


