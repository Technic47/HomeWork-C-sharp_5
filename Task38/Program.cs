/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
*/

Console.WriteLine("Enter array length: ");
int N = int.Parse(Console.ReadLine()!);
double[] array = new double[N];

double max = 0;
double min = 99999;

Console.WriteLine("Enter number: ");
for (int i = 0; i < N; i++)
{
    array[i] = double.Parse(Console.ReadLine()!);
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}

Console.Write($"Your array: ");
for (int i = 0; i < N; i++) Console.Write($"{array[i]}; ");

Console.WriteLine($"\nDifferense between max and min: {max - min}");