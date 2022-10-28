/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1,7] -> такого элемента в массиве нет */

int m = 5;
int n = 5;
int[,] array = new int[m, n];

Console.Write("Введите номер строки: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x < 0 | y < 0)
{
    Console.WriteLine("Неверный ввод!");
    Environment.Exit(-1);
}
else
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(-100, 100));
            Console.Write(array[i,j] + "; ");
        }
        Console.WriteLine();
    }

    if (x > m | y > n)
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
    else
    {
        Console.WriteLine($"Элемент с координатами {x} и {y} является: {array[x, y]}");
    }    
}


