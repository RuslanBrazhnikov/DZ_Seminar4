// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int s = 0;

int SumNum()
{
    while (a > 0)
    {
        s = s + a % 10;
        a = a / 10;
    }
    return s;
}

int result = SumNum();
Console.WriteLine($"Сумма цифр вашего числа -->> *{result}*");