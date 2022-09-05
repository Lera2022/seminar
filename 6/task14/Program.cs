﻿// Напишите программу, которая перевернёт одномерный целочисленный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.) Пример: [1 2 3 4 5] -> [5 4 3 2 1] [6736] -> [6 3 7 6]
int[] arr = new int[] { 1, 2, 3, 4, 5 };
// 0 1 2 3 4
//arr[0] <-> arr[N-1]
//arr[1] <-> arr[N-2]
for (int i = 0; i < arr.Length / 2; i++)
{
    int tmp = arr[i];
    arr[i] = arr[arr.Length - (i + 1)];
    arr[arr.Length - (i + 1)] = tmp;
    Console.WriteLine(i + " " + arr[i]);
}