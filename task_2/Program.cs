/*
Задача 13: Напишите программу, которая выводит третью цифру заданного
числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());
int numberThree = 0;
if (number < 100)
{
    Console.WriteLine($"Третьей цифры нет");
    return;
}
if (number > 100)
{
    while (number > 1000)
    {
        number = number / 10;
    }
    numberThree = number % 10;
}
Console.WriteLine($"Третья цифра числа -> {numberThree}" );





