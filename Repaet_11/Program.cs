Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
Console.WriteLine("Enter your surname:");
string surname = Console.ReadLine();
Console.WriteLine("Enter the year of birth:");
int ear = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your born place");
string bornPlace = Console.ReadLine();


Console.WriteLine($"Hello, {surname} {name}. You are {2025 - ear} years old. Your born place is {bornPlace}");


