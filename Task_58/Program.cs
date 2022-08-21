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


int[,] matrOne = SetArray(2, 2, 0, 2);

int[,] matrTwo = SetArray(2, 2, 0, 2);
Console.WriteLine("");
Console.WriteLine("первый массив");
Console.WriteLine("");
PrintMatrixTwoDimensional(matrOne);
Console.WriteLine("");
Console.WriteLine("второй массив");
Console.WriteLine("");
PrintMatrixTwoDimensional(matrTwo);
Console.WriteLine();




void MultipclicMatrix(int[,] matrixOne, int[,] matrixTwo)

{
   int[,] multipclicMatrix = new int[matrixOne.GetLength(1), matrixOne.GetLength(0)];

   for (int i = 0; i < multipclicMatrix.GetLength(0); i++)
   {

      for (int j = 0; j < multipclicMatrix.GetLength(1); j++)
      {
         int multi = 0;
         for (int ii = 0; ii < matrixOne.GetLength(1); ii++)
         {
            multi += matrixOne[i, ii] * matrixTwo[ii, j];
         }
         multipclicMatrix[i, j] = multi;
      }
   }
   PrintMatrixTwoDimensional(multipclicMatrix);

}

Console.WriteLine("");
Console.WriteLine("Произведение матрица");
Console.WriteLine("");

MultipclicMatrix(matrOne, matrTwo);


