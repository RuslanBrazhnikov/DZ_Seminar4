// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



Console.Clear();

int element = 8;
int[] arr = new int[element];

void FillArray(int elem, int[] array)
{
    for (int i = 0; i < elem; i++)
    {
        array[i] = new Random().Next(1, 9); 
    }
}
void PrintArray(int elem_2, int[] array_2)
{
    Console.Write($"array = [ ");
    for (int i = 0; i < elem_2; i++)
    {
        Console.Write($"{array_2[i]}, ");
    }
    Console.Write($"]");
}



FillArray(8, arr);
PrintArray(8, arr);



