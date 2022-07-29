/* Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел
в массиве.
*/

Console.WriteLine("Enter array length: ");
int N = int.Parse(Console.ReadLine()!);
int[] array = new int[N];

int count = 0;

for (int i = 0; i < N; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write($"{array[i]} ");
    if ((array[i] % 2) == 0) count ++;
}

Console.WriteLine($"\nCount of even numbers: {count}");