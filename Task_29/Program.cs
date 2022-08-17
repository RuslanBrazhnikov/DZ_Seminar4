// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите 8 элементов массива: ");
int[] array = Convert.ToInt32(Console.ReadLine());

int[] array.Length == 8;
if (array.Length > 8)
{
    Console.Write("Введите 8 элементов!");
}
else
{
    Console.Write($"{array} + ,");
}