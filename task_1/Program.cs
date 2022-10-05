/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Введите трёхзначное число ");
int number = int.Parse(Console.ReadLine());

int middleSymbol = number % 100;
int result = middleSymbol / 10;

if (number < 1000)
{
    Console.WriteLine($"Вторая цифра числа {number} -> {result}" );
}

else
{
    Console.WriteLine("Введите трёхзначное число!!!");
}

