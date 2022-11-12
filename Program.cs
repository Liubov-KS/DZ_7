//Задача 47.
/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
/* Console.WriteLine("Задайте количество строк двумерного массива:"); // m
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
*/


//Задача 50.
/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4                    17 -> такого числа в массиве нет
*/
Console.WriteLine("Введите размеры массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0,10));  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t  ");
        Console.WriteLine();
}
 
 Console.WriteLine("Введите позицию элемента в двумерном массиве");
 int a = Convert.ToInt32(Console.ReadLine());
 int b = Convert.ToInt32(Console.ReadLine());
 
 if (a > m && b > n)
 Console.WriteLine("такого числа нет");
 else
 {
 object c = array.GetValue(a,b);
 Console.WriteLine(c);
 }






// Задача 52.
/* Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. 
*/