// Задача 22:
// Напишите программу, которая
// принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 –> 1, 4, 9, 16, 25.
// 2 –> 1, 4.

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    SquareTable(number);
}
else
{
    Console.WriteLine("Число не натуральное.");
}

void SquareTable(int num)
{
    for (int count = 1; count <= num; count++)
    {
        Console.WriteLine($"{count, 5}{count * count, 10}"); // Форматирование вывода.
    }
}
