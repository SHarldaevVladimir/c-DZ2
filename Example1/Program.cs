// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Задача 10 ");
Console.Write("Введи трёхзначное число: ");

int num = int.Parse(Console.ReadLine());

void CheckNumber(int num)
{
    if (num < 100 || num > 999)
    {
        Console.WriteLine("Это не трёхзначное...");

    }
    else Console.WriteLine("Вторая цифра " + ShowSecondNum(num));
}

int ShowSecondNum(int num)
{
    int SecondNum2 = num / 10;
    int SecondNum = SecondNum2 % 10;
    return SecondNum;

}
CheckNumber(num);
