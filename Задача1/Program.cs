/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.WriteLine("Введите трехзначное число: ");
string numStr = Console.ReadLine();
int num = int.Parse(numStr);

num = num < 0 ? num * -1 : num;

if (num > 99 && num < 1000)
{
    int num2 = num / 10;
    num2 = num2 % 10;
    Console.WriteLine(num2);
}
else
{
    Console.WriteLine("Это не трехзначное число");
}