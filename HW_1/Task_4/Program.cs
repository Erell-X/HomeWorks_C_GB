// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int N, F;
  
  F = 1;
  
  Console.Clear();
  Console.Write("Введите число: ");
  
  N = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine();
  Console.Write("Ряд чётных чисел: ");

  while (F <= N-2)
  {
    if (F % 2 == 0)
    {
    Console.Write($"{F}, ");
    }
  
    F++;
  }
    
    if (F % 2 == 0)
    {
      Console.Write(F);
    }
    
    else if (F % 2 == 1 && N > 1)
    {
      F++;
      Console.Write(F);
    }