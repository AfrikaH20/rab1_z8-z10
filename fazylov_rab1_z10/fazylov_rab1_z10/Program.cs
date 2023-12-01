using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите индекс N: ");
        int index = Convert.ToInt32(Console.ReadLine());

        int result = FindNthDigit(number, index);

        Console.WriteLine("N-я цифра числа: " + result);
    }

    public static int FindNthDigit(int number, int index)
    {
        int count = 0;

        while (number != 0)
        {
            count++;
            if (count == index)
            {
                return number % 10;
            }
            number /= 10;
        }

        return 0;
    }
}
