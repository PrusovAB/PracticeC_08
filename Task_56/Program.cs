// Создаем двухмерный рандомный массив

int[,] SetArray(int rows, int columns, int min, int max)
{
   var array = new int[rows, columns];
   var rnd = new Random();

   for (int i = 0; i < rows; i++)
   {
      for (int j = 0; j < columns; j++)
      {
         array[i, j] = rnd.Next(min, max + 1);
      }
   }
   return array;
}

// ## Выводим двухмерный рандомный массив

void PrintMatrixTwoDimensional(int[,] matrixTwoDimensional)
{
   for (int i = 0; i < matrixTwoDimensional.GetLength(0); i++)
   {
      Console.Write("[ ");
      for (int j = 0; j < matrixTwoDimensional.GetLength(1); j++)
      {
         if (matrixTwoDimensional[i, j] >= 0)
            Console.Write($" {matrixTwoDimensional[i, j]} ");
         else Console.Write($"{matrixTwoDimensional[i, j]} ");
      }
      Console.Write(" ]");
      Console.WriteLine();
   }
}


int[,] matr = SetArray(4, 4, 0, 10);


PrintMatrixTwoDimensional(matr);
Console.WriteLine();



int SerchMinLines(int[,] matrix)
{

   int sum = 0;
   int min = 0;
   int count = 0;
   for (int i = 0; i < matr.GetLength(1); i++)
   {
      sum = 0;
      for (int j = 0; j < matr.GetLength(0); j++)
      {
         sum += matr[i, j];
      }
      if (i == 0)
      {
         min = sum;
      }
      if (sum < min)
      {
         count = i + 1;
         min = sum;
      }

   }
   return count;
}

int serchMinLines = SerchMinLines(matr);
Console.WriteLine($"Строка с наименьшей суммой элементов = {serchMinLines}");