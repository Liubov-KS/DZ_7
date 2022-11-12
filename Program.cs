//Задача 47.
/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
Console.WriteLine("Задайте количество строк двумерного массива:"); // m
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте количество столбцов двумерного массива:"); // n
int n = Convert.ToInt32(Console.ReadLine());

double[,] twoDimArray = new double[m, n];

Random rnd = new Random();

void PrintArray(double[,] matrix)
{ 
    for (int i = 0; i < m; i++)
    { 
    for (int j = 0; j < n; j++)
        { 
        Console.Write($"{matrix[i, j]} ");
        }
 Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{ 
    for (int i = 0; i < m; i++)
    { 
    for (int j = 0; j < n; j++)
        { 
         matr[i,j] = Convert.ToDouble(rnd.Next(-100, 100)/10.0);  // конверт матриц в дабл тип чисел
        }
    }
}

FillArray(twoDimArray);

Console.WriteLine();

PrintArray(twoDimArray);



//Задача 50.
/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4                    17 -> такого числа в массиве нет
*/







// Задача 52.
/* Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. 
*/