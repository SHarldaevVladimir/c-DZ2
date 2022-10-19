// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


Console.WriteLine("Задача 13 ");
Console.WriteLine("Введите число");

int num = int.Parse(Console.ReadLine());

void CheckNumber(int num)
{
    if (num < 100 )
    {
        Console.WriteLine("Третьей Цифры нет...");

    }
    else Console.WriteLine("Третья цифра " + FindThirdNumber(num));
}


int FindThirdNumber(int num)
{
    
while (num > 999) 
{
    num = num/10;
}
int ThirdNum = num % 10;
return ThirdNum;
}
CheckNumber(num);
FindThirdNumber(num);

