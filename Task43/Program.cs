// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, 
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

double[,] num = new double[2, 2];
double[] Cross = new double[2];

void InputNumbers()
{
  for (int x = 0; x < num.GetLength(0); x++)
  {
    Console.Write($"Введите значения {x+1}-го уравнения (y = k * x + b): ");
    Console.WriteLine();

    for (int y = 0; y < num.GetLength(1); y++)
    {
      if(y==0) Console.Write($"Введите значение k: ");
      else Console.Write($"Введите значение b: ");
      num[x,y] = Convert.ToInt32(Console.ReadLine());
      
    }
  }
}

double[] Equalisation(double[,] num)
{
  Cross[0] = (num[1,1] - num[0,1]) / (num[0,0] - num[1,0]);
  Cross[1] = Cross[0] * num[0,0] + num[0,1];
  return Cross;
}

void Output(double[,] num)
{
  if (num[0,0] == num[1,0] && num[0,1] == num[1,1]) 
  {
    Console.Write($"Прямые совпадают");
  }
  else if (num[0,0] == num[1,0] && num[0,1] != num[1,1]) 
  {
    Console.Write($"Прямые параллельны");
  }
  else 
  {
     Console.Write($"Точка пересечения прямых: -> ({Cross[0]}, {Cross[1]})");
  }
}

InputNumbers();
Equalisation(num);
Output(num);
