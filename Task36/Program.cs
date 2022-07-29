/*Задача 36: Задайте одномерный массив, 
заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
*/

Console.WriteLine("Enter array length: ");
int N = int.Parse(Console.ReadLine()!);
int[] array = new int[N];

int sum = 0;

for (int i = 0; i < N; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write($"{array[i]} ");
    if ((i % 2) == 0) sum = sum + array[i];
}

Console.WriteLine($"\nSum of numbers with uneven index: {sum}");