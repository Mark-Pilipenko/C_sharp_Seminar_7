// Задача 51: 
// Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array= new int[m,n];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Сумма элементов главной диагонали: {DiaSum(array)}");


void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0,10);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int DiaSum(int[,] matrix)
{
    int edge = 0;
    int sum = 0;
    if (matrix.GetLength(0) < matrix.GetLength(1)) edge = matrix.GetLength(0);
    else edge = matrix.GetLength(1);
    for (int i = 0; i < edge; i++)
    {
        sum = sum + matrix[i,i];
    }
    return sum;
}