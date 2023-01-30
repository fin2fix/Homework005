/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/


double[] GetArray(int dimension)
{
  double[] arr = new double[dimension];
  Random rnd = new Random();

  for (int i = 0; i < dimension; i++)
  {
    arr[i] = Math.Round((rnd.NextDouble() * 100), 1);
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

void PrintDeltaMaxMin(double[] arr)
{
  double maxNumber = arr[0];
  double minNumber = arr[0];
  double delta = 0;

  for (int i = 1; i < arr.Length; i++)
  {
    if (arr[i] > maxNumber) maxNumber = arr[i];
    if (arr[i] < minNumber) minNumber = arr[i];
  }
  delta = maxNumber - minNumber;

  Console.WriteLine($"Максимальное число массива = {maxNumber}");
  Console.WriteLine($"Минимальное число массива = {minNumber}");
  Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {delta}");
}

int size = getSizeArray("Введите размер массива (количество элементов массива)");
double[] array = GetArray(size);
Console.WriteLine("---------");
Console.WriteLine($"Массив {string.Join("  ", array)} ");
PrintDeltaMaxMin(array);

