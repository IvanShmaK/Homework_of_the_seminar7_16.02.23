//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

/*
double[,] Create2DArray(int row, int column, int minV, int maxV)
{
    double[,] create2DArray = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            create2DArray[i, j] = Math.Round(new Random().Next(minV, maxV) + new Random().NextDouble(), 2);
        }
    }
    return create2DArray;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

double [,] createArray = Create2DArray(rows, columns, minVal, maxVal);
Show2dArray(createArray);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет


int [,] Create2DArray(int row, int column, int minV, int maxV)
{
    int[,] createdArray = new int [row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            createdArray[i, j] = new Random().Next(minV, maxV + 1);
        }
    }
    return createdArray;
}

void Show2dArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "   ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

/*
Console.Write("Input count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int maxVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of row (numbering starts from 0!): ");
int row_number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of column (numbering starts from 0!): ");
int column_number = Convert.ToInt32(Console.ReadLine());

if (row_number > rows || column_number > columns)
    Console.Write("There is no such element in the array!");
else
{
    int [,] created2DArray = Create2DArray(rows, columns, minVal, maxVal);
    Show2dArray(created2DArray);
    Console.Write($"Your number is {created2DArray[row_number, column_number]}");
}
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void ArithmeticMean (int [,] array, int row, int column)
{
    for (int j = 0; j < column; j++)
    {
        int [] my_array = new int [row];// одномерный массив, в который будут записываться значения из столбцов. На каждый новый столбец - новый массив
        int a = 0;                      // а - индекс для одномерного массива
        double sum = 0;
        double arithm_mean = 0;
        for (int i = 0; i < row; i++)
        {
            my_array[a] = array[i, j];
            a++;
        }
        a = 0; // а обнуляется, чтобы заработал цикл по нахождению суммы элементов одномерного массива
        while(a < row)
        {
            sum = sum + my_array[a];
            a++;
        }    
        arithm_mean = Math.Round(sum / row, 1);
        Console.Write(arithm_mean + "  ");
    }
}

Console.Write("Input count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

int [,] created2DArray = Create2DArray(rows, columns, minVal, maxVal);
Show2dArray(created2DArray);
Console.WriteLine("The arithmetic mean of elements of every column is: "); 
ArithmeticMean(created2DArray, rows, columns);