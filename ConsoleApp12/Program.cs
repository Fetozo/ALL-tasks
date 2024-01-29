using System;
class task12
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 , 6, 7, 8, 9, 10 };
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        double average = (double)sum / numbers.Length;
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Average: " + average);
    }
}
