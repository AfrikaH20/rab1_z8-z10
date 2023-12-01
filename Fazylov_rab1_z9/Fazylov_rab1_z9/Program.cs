using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите тип показа (премьера, обычный, льготный): ");
        string showType = Console.ReadLine();

        Console.WriteLine("Введите количество рядов в зале: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов в зале: ");
        int columns = Convert.ToInt32(Console.ReadLine());

        int totalSeats = rows * columns;
        int totalIncome = 0;

        switch (showType)
        {
            case "премьера":
                totalIncome = totalSeats * 600;
                break;
            case "обычный":
                totalIncome = totalSeats * 410;
                break;
            case "льготный":
                totalIncome = totalSeats * 250;
                break;
            default:
                Console.WriteLine("Ошибка! Неправильный тип показа.");
                return;
        }

        Console.WriteLine("Общий доход от билетов при полном зале: " + totalIncome + " рублей.");
    }
}
