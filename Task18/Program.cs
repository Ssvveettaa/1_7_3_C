// Задача 18:
// Напишите программу, которая
// по заданному номеру четверти
// показывает диапазон возможных координат – точек в этой четверти (х и у).
//      y
//      ∧
//   2  |  1
// —————|————> x
//   3  |  4
//      |

Console.Write("Введите номер четверти: ");
string quarter = Console.ReadLine()!;

string range = QuarterToRange(quarter);
if (range != null) Console.WriteLine(range);
else Console.WriteLine("Некорректная четверть.");

string QuarterToRange(string quart)
{
    if (quart == "1") return "x > 0, y > 0";
    if (quart == "2") return "x < 0, y > 0";
    if (quart == "3") return "x < 0, y < 0";
    if (quart == "4") return "x > 0, y < 0";
    return null!;
}
