// Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9
// double p = new Random().NextDouble()*(max-min)+min

using System;
using static System.Console;// эти 2 строчки заменяют Console. теперь на каждом вызове консоли можно не писать

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine()!);

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine()!);

double[,] array = GetArray(rows, columns, -10, 10);// в переменную записываем действие функции по заполнению рандомными вещественными числами
PrintArray(array);
WriteLine();

double[,] GetArray(int m, int n, int minValue, int maxValue)// функция для заполнения 2-мерного массива рандомными вещественными элементами
{
  double[,] result = new double[m, n];// создали переменную в которую будем складывать кол-во массивов(m) и кол-во элементов в каждом массиве(n)
  for (int i = 0; i < m; i++)// первым циклом проходим по массивам(строкам)
  {
    for (int j = 0; j < n; j++)// втоорым циклом проходим по элементам массива(столбцам)
    {
      result[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;// обращаемся к каждому элементу массива и складывем рандомные числа
    }
  }
  return result;// возвращаем результат
}

void PrintArray(double[,] inArray)// функция вывода 2-мерного массива в консоль
{
  for (int i = 0; i < inArray.GetLength(0); i++)// первым циклом проходит по массивам
  {
    for (int j = 0; j < inArray.GetLength(1); j++)// второй проходит по элементам
    {
      Console.Write($"{inArray[i, j]:f2} / ");// сначала записываем все элементы перврго массива, потом все элементы второго массива и т.д
    }
    Console.WriteLine();//переносим на новую строчку
  }
}
