/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int n = 5;
int m = 7;
int[,] array = new int[n, m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i, j] = Convert.ToInt32(new Random().Next(0, 5));
        Console.Write(array[i,j] + "; ");
    }
    Console.WriteLine();
}

Console.Write("Среднее арифметическое: ");
for (int j = 0; j < m; j++)
{
    double sum = 0;
    for (int i = 0; i < n; i++)
    {
        sum += array[i, j];
    }
    Console.Write($"{Math.Round(sum / n, 2)}; ");
}