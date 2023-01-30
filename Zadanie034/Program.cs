/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int[] GetArray(int dimension)
{
  int[] arr = new int[dimension];
  Random rnd = new Random();

  for (int i = 0; i < dimension; i++)
  {
    arr[i] = rnd.Next(100, 1000);
  }
  return arr;
}

int FindNumberEven(int[] arr)
{
  int count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] % 2 == 0) count = count + 1;
  }
  return count;
}

int getSizeArray(string message)
{
  int result = 0;
  while (true)
  {
    Console.WriteLine(message);
    if (int.TryParse(Console.ReadLine(), out result) && result > 0)
    { break; }
    else
    {
      Console.WriteLine("Введено неверное число!");
      Console.WriteLine();
    }
  }
  return result;
}

int size = getSizeArray("Введите размер массива (количество элементов массива)");
int[] array = GetArray(size);
Console.WriteLine($"Массив {string.Join(", ", array)} ");
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве = {FindNumberEven(array)} ");

