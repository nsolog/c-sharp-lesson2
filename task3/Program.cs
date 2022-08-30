// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

string day = Console.ReadLine();

if (day == "6" || day == "7")
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}