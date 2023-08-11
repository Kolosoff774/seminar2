/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать массив
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Введите число: ");
string numStr = Console.ReadLine();
int num = int.Parse(numStr);

if (num < 0) num *=  -1;

if (num > 99)
{
    while (num > 999)
    {
        num /= 10;
    }
    num %= 10;
    Console.WriteLine($"Третья цифра: {num}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}