// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

string number = Console.ReadLine();

if (number.Length > 3)
{
    Console.WriteLine("Число не трехзначное");
}
else
{
    Console.WriteLine(number[1]);
}