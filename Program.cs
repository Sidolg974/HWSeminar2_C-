/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

/*
Console.Write("Введите число N ");
int num = new Random().Next(100, 1000);
int secondNumber = num / 10 % 10;
Console.WriteLine($"Вторая цифра числа {num} -> {num / 10 % 10}");
*/


/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

/*
    Console.Write("Введите число: ");
    int num = int.Parse(Console.ReadLine());
    if (num < 100)
    {
    Console.WriteLine($"Третьей цифры нет!");
    return;
    }
int thirdNumber = 0;
if (num > 99 && num < 1000)
{
    thirdNumber = (num % 100) % 10;
}
if (num > 999 && num < 10000)
{
    thirdNumber = (num % 100) / 10;
}
if (num > 9999 && num < 100000)
{
    thirdNumber = (num % 100) / 100;
}
if (num > 99999 && num < 1000000)
{
    thirdNumber = (num % 10000) / 1000;
}
Console.WriteLine($"Третья цифра числа {num} -> {thirdNumber}");
*/

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

/*
int dayNumber = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(WorkHoliday(dayNumber));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
string WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("Под цифрой " + a + " - Выходной");
        }
        else
        {
            Console.Write("Под цифрой " + a + " - Рабочий");
        }
    }
    else
    {
        Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
    }
    return " день.";
}
*/