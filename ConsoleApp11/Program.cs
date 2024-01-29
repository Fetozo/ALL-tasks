using System;

class task11
{
    static void Main(string[] args)
    {
        string[] arr = { "строка1", "строка2", "строка3" };
        Console.WriteLine("Введите строку:");
        string searchString = Console.ReadLine();
        bool found = false;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == searchString)
            {
                found = true;
                break;
            }
        }
        if (found)
        {
            Console.WriteLine("Строка найдена!");
        }
        else
        {
            Console.WriteLine("Строка не найдена!");
        }
        Console.ReadLine();
    }
}
