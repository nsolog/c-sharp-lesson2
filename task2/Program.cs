// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

string number = Console.ReadLine();

if (number.Length > 2)
{
    Console.WriteLine(number[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}