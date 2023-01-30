/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] GetArray(int dimension)
{
  int[] arr = new int[dimension];
  Random rnd = new Random();

  for (int i = 0; i < dimension; i++)
  {
    arr[i] = rnd.Next(-1000, 1001);
  }
  return arr;
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

int FindSumOddPosition(int[] arr)
{
  int sum = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (i % 2 == 1) sum = sum + arr[i];
  }
  return sum;
}

int size = getSizeArray("Введите размер массива (количество элементов массива)");
int[] array = GetArray(size);
Console.WriteLine($"Массив {string.Join(", ", array)} ");
Console.WriteLine();
Console.WriteLine($"Сумма чисел на нечетной позиции массива = {FindSumOddPosition(array)} ");
