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
  /*
            int[,] mas = new int[3,4] {{1,4,7,2},{5,9,2,3},{8,4,2,4}};
 
            for (int i = 0; i < 3; i++) 
            {
                int srAr = 0;
                int ColChetn = 0;
                for (int j = 0; j < 4; j++)
                {
                    srAr += mas[i, j];
                    ColChetn += (mas[i, j] % 2 == 0) ? 1 : 0;
                }
                Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(float)srAr/3}");
                Console.WriteLine($"Количество четных элементов столбца {i + 1} = {ColChetn}");
            }
 */       



System.Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int array = GetArray(rows, columns, 0, 10);
PrintArray(array);

double[] averageColumns = GetResultArray(array);
Console.WriteLine($"Cреднее арифметическое каждого столбца = {String.Join("; ", averageColumns)}");

char input1 = Console.ReadKey().KeyChar;

double[] GetResultArray(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum+= array[j, i];
        }
        sum = Math.Round(sum / array.GetLength(0), 2);
        result[i] = Math.Round(sum / array.GetLength(0), 2);
        Console.WriteLine($"Среднее арифметическое {sum}");
    }
    return result;
}

