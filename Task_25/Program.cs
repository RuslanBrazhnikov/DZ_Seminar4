// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите число А: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число В: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int num1_num2 = 1;
for (int i = 0; i < num2; i++)
{
    num1_num2 *= num1;
}
Console.WriteLine($"{num1} в степени {num2} = *{num1_num2}*");
Console.ReadKey();

