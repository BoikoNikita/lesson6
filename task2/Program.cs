double[,] val = new double[2, 2];
double[] cross = new double[2];

void InValue(){
  for (int i = 0; i < val.GetLength(0); i++)
  {
    Console.Write($"Введите значения переменных {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < val.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите значение k: ");
      else Console.Write($"Введите значение b: ");
      val[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] val)
{
  cross[0] = (val[1,1] - val[0,1]) / (val[0,0] - val[1,0]);
  cross[1] = cross[0] * val[0,0] + val[0,1];
  return cross;
}

void OutValue(double[,] val)
{
  if (val[0,0] == val[1,0] && val[0,1] == val[1,1]) 
  {
    Console.WriteLine("Прямые совпадают");
  }
  else if (val[0,0] == val[1,0] && val[0,1] != val[1,1]) 
  {
    Console.WriteLine("Прямые параллельны");
  }
  else 
  {
    Decision(val);
    Console.WriteLine($"Точка пересечения прямых: ({cross[0]}, {cross[1]})");
  }
}

InValue();
Console.WriteLine();
OutValue(val);