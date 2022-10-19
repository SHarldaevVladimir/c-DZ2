// Задача 11 HARD - необязательная: Напишите программу, которая принимает на вход целое число любой разрядности и
//  удаляет вторую цифру слева направо этого числа. И, конечно же, через строку решать нельзя.

Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());

int onlyNumber = 0;
int num2 = 0;
 while (num > 99)
{
    onlyNumber = num % 10;
    num2 = num2 * 10;
    num2 = num2 + onlyNumber;
    num = num / 10;

}
onlyNumber = num / 10;
num2 = num2 * 10;
num2 = num2 + onlyNumber;

Console.WriteLine(num2);


// int FindSecondNumber(int num)
// { 
// while (num > 99) 
// {

//     num = num/10;
// }
// int secondNum = num % 10;
// return secondNum;
// }
// FindSecondNumber(num);