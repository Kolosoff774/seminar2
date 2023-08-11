/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.WriteLine ("Введите число, обозначающее день недели: ");
string numDayStr = Console.ReadLine();
int numDay = int.Parse(numDayStr);

if (numDay > 0 && numDay < 8)
{
    if (numDay < 6)
    {
        Console.WriteLine ("Нет");
    }
    else {
        Console.WriteLine ("Да");
    }
}  
else
{
    Console.WriteLine ("Такого дня нет");
}

