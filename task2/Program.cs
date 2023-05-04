// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 1 -> 1

System.Console.WriteLine("Введите номер строк");
int Line = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите номер столбцов");
int colmuns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[10, 10];

FillArray(matrix);
PrintArray(matrix);
CheckArray(matrix);

void CheckArray(int [,] matr)
{
    if (Line > matr.GetLength(0) || colmuns > matr.GetLength(1))
    {
        Console.WriteLine("такого элемента нет");
    }
    else
    {
        Console.WriteLine($"значение элемента {Line} строки и {colmuns} столбца равно {matr[Line - 1, colmuns - 1]}");
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}


