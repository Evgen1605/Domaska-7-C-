﻿// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17->такого числа в массиве нет

using System;
using static System.Console;// эти 2 строчки заменяют Console. теперь на каждом вызове консоли можно не писать


Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine()!);

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine()!);

Write("Введите значение элемента: ");
int element = int.Parse(ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);// выводим в консоль рандомный 2-мерный массив

if (FindElement(array, element))// проверяем если действие функции FindElement вернёт true
{
  WriteLine($"Элемент {element} найден");// то выводим в консоль
}
else
{
  WriteLine($"{element} -> такого числа в массиве нет");// если вернёт false, выводим в консоль
}

int[,] GetArray(int m, int n, int minValue, int maxValue)// функция возвращает 2-мерный массив, на вход принимает 2 агумента, кол-во массивов(m) и кол-во элементов в каждом массиве(n)
{
  int[,] result = new int[m, n];// создали переменную в которую будем складывать кол-во массивов(m) и кол-во элементов в каждом массиве(n)
  for (int i = 0; i < m; i++)// первым циклом проходим массивам
  {
    for (int j = 0; j < n; j++)// второй цикл проходит по элементам массива
    {
      result[i, j] = new Random().Next(minValue, maxValue + 1);// обращаемся к каждому элементу массива и складывем рандомные числа
    }
  }
  return result;// возвращаем реезультат
}


void PrintArray(int[,] inArray)// функция вывода 2-мерного массива в консоль
{
  for (int i = 0; i < inArray.GetLength(0); i++)// первым циклом проходим по массивам
  {
    for (int j = 0; j < inArray.GetLength(1); j++)// второй проходит по элементам
    {
      Write($"{inArray[i, j]} ");// сначала записываем все элементы перврго массива, потом все элементы второго массива и т.д
    }
    WriteLine();//переносим на новую строчку
  }
}

bool FindElement(int[,] array, int el)// функция возвращает либо true либо false на вход принимает 2-мерный массив и элемент
{
  for (int i = 0; i < array.GetLength(0); i++)// первым циклом проходит по массивам
  {
    for (int j = 0; j < array.GetLength(1); j++)// второй проходит по элементам
    {
      if (array[i, j] == el) return true;// проверяем есть ли элемент в массиве, если да то возвращаем 
    }
  }
  return false;// возвращаем если нету элемента
}