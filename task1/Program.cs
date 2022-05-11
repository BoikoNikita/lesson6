Console.WriteLine("Введите количество вводимых чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];

void InNum(int M)
{
    for (int i = 0; i < M; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}


int A(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i] > 0 ) count ++; 
  }
  return count;
}

InNum(M);
Console.WriteLine($"Введено чисел больше нуля: {A(array)} ");