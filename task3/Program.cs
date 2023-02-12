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

void PrintArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      System.Console.Write(matr[i, j] + "  ");
    }
    System.Console.WriteLine();
  }
}

System.Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, m];
FillArray(matrix);
PrintArray(matrix);
int sum = int.MaxValue;
int index = 0;
for (int i = 0; i < n; i++)
{
  int temp = 0;
  for (int j = 0; j < m; j++)
  {
    temp += matrix[i, j];
  }
  if (temp < sum)
  {
    sum = temp;
    index = i;
  }
}
Console.WriteLine("Строка: " + index + " Сумма - " + sum);
Console.WriteLine();
for (int i = 0; i < m; i++)
{
  Console.Write(matrix[index, i] + " ");

}
Console.ReadKey();