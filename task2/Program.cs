void FillArray(int[,] matrix)
{ 
  Random rand = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i,j]=rand.Next(1,100);
    }
  }
}

void PrintArray(int[,] matr)
{
  for(int i = 0;i < matr.GetLength(0);i++)
  {
    for(int j = 0;j < matr.GetLength(1);j++)
    {
      System.Console.Write(matr[i,j] + "  ");
    }
    System.Console.WriteLine();
  }
}

System.Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array = new int [n,m];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
for(int i = 0;i < array.GetLength(1);i++)
  {
    for(int j = 0;j < array.GetLength(0);j++)
    {
      System.Console.Write(array[j,i] + "  ");
    }
    System.Console.WriteLine();
  }