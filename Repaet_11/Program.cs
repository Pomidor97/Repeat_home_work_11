

char[] charsToTrim = { '*', ' ', '\''};

Console.WriteLine("Enter your name:");
string name = Console.ReadLine().Trim(charsToTrim).ToUpper();
Console.WriteLine("Enter your surname:");
string surname = Console.ReadLine().Trim(charsToTrim).ToUpper();
Console.WriteLine("Enter the year of birth:");
int ear = Convert.ToInt32(Console.ReadLine().Trim(charsToTrim));
Console.WriteLine("Enter your born place");
string bornPlace = Console.ReadLine().Trim(charsToTrim).ToUpper();





Console.WriteLine($"Hello, {surname} {name}. You are {2025 - ear} years old. Your born place is {bornPlace}");


