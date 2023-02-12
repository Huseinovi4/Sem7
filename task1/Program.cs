void FillArray(int[,] matrix)
{
  Random rand = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rand.Next(1, 100);
    }
  }
}
void PrintArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      System.Console.Write(arr[i, j] + "  ");
    }
    System.Console.WriteLine();
  }
}

System.Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, m];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();

var arr = array.Cast<int>().OrderByDescending(a => a).ToArray();

int count = 0;
for (int j = 0; j < array.GetLength(0); j++)
{
  for (int k = 0; k < array.GetLength(1); k++)
  {
    array[j, k] = arr[count];
    Console.Write(array[j, k] + "  ");
    count++;
  }
  Console.WriteLine();
}
Console.ReadKey();

