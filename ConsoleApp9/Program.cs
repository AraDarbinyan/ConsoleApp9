//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//В итоге получается вот такой массив:

//1 2 4 7

//2 3 5 9

//2 4 4 8
using System.ComponentModel;

int[,] array = new int[4, 4];
int[,] creatingarray(int[,] array)
{
    for (int i =0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Random.Shared.Next(1, 10);
        }
    }
    return array;
}
int[,] SortingArray(int[,] array)
{
    int max = array[0, 0];
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > max) { max = array[i, j];}
            if (array[i, j] < min) { min = array[i, j];}
        }
    }
    return array;
}
int[,] array1 = creatingarray(array);
int[,] array2 = SortingArray(array1);
Console.WriteLine($"{string.Join(" ", array2)}");

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:

//1 4 7 2
//5 9 2 3

//8 4 2 4

//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int[,] rectangleArray = new int[4, 8];
int[] FindingRow(int[,] array)
{
    int[] ArrayOfSums = new int[array.GetLength(0)];
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {

            sum += array[i, j];
            break;
        }
        ArrayOfSums[i] = sum;
    }
    return ArrayOfSums;
}
int FindingTheBiggestSum(int[] array)
{
    int result = 0;
    int index = 0;
    for (int i = 0; i<array.GetLength(0); i++)
    {
        if (array[i] > result)
        {
            result = array[i];
            index= i;
        }
    }
    return index + 1;
}
int[,] ints2 = creatingarray(rectangleArray);
int[] ints3 = FindingRow(ints2);
int row = FindingTheBiggestSum(ints3);
Console.WriteLine($"The row that has the biggest sum of its elements is {row} row"); 


//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

//Например, заданы 2 массива:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//5 2 6 7

//и

//1 5 8 5

//4 9 4 2

//7 2 2 6

//2 3 4 7

//Их произведение будет равно следующему массиву:

//1 20 56 10

//20 81 8 6

//56 8 4 24

//10 6 24 49
int[,] array3 = new int[4, 4];
int[,] array4 = new int[4, 4];
int[,] MatrixMultiplication(int[,] matrix, int[,] matrix1)
{
    int[,] MatrixMulty = new int[4, 4];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            MatrixMulty[i, j] = matrix[i, j] * matrix1[i, j];
        }
    }
    return MatrixMulty;
}
static void PrintArray(int[,] array)
{
    Console.WriteLine($"{string.Join(" ", array)}");
}
int[,] ints = creatingarray(array3);
int[,] ints1 = creatingarray(array4);
int[,] int2 = MatrixMultiplication(ints, ints1);
PrintArray(int2);


//Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

//массив размером 2 x 2 x 2

//12(0,0,0) 22(0, 0, 1)

//45(1, 0, 0) 53(1, 0, 1)

int[, ,] ThreeDArray = new int[3, 3, 3];
int[, ,] Creating3Darray(int[,,] array)
{
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {
            for (int z = 0; z<array.GetLength(2); z++)
            {
                array[i, j, z] = Random.Shared.Next(10, 100);
            }
        }
    }
    return array;
}
void print3darray(int[, , ] array)
{
    int num = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                num = array[i, j, z];
                Console.WriteLine($"{num}({i}, {j}, {z})");
            }
        }
    }
}
int[,,] New3Darray = Creating3Darray(ThreeDArray);
print3darray(New3Darray);
//Задача 62.Заполните спирально массив 4 на 4.

//Например, на выходе получается вот такой массив:

//1  2  3  4

//12 13 14 5

//11 16 15 6

//10 9  8  7
