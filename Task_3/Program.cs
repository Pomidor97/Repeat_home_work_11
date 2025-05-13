

Console.WriteLine("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int [] numbers = { num, num2, num3 };

Console.WriteLine("enter the array inde from 0 to 2: ");
int arrayIndex = Convert.ToInt32(Console.ReadLine());

TheComparator comparator = new TheComparator();

foreach (var number in numbers)
{
    comparator.CompareTo(numbers[arrayIndex], number);
}

comparator.CompareTo(5, 5);


public class TheComparator
{
    
    public void CompareTo(int n1, int n2)
    {
        if (n1 < n2)
            Console.WriteLine($"{n1} < {n2} = true");
        else
            Console.WriteLine($"{n1} < {n2} = false");
    }
}



