// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


Console.Clear();
Console.WriteLine("Введите 1-ый элемент массива: ");
int element1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2-ый элемент массива: ");
int element2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 3-ый элемент массива: ");
int element3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 4-ый элемент массива: ");
int element4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 5-ый элемент массива: ");
int element5 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 6-ый элемент массива: ");
int element6 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 7-ый элемент массива: ");
int element7 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 8-ый элемент массива: ");
int element8 = Convert.ToInt32(Console.ReadLine());


void Array()
{
    Console.Write($"Ваш массив из 8 элементов -->> [{element1}, {element2}, {element3}, {element4}, {element5}, {element6}, {element7}, {element8}]");
}

Array();

//До конца не понял как принимать на вход все элементы массива сразу.