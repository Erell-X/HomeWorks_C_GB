// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Num, Res, lastFigure;
  
  lastFigure = 0;
  Res = 0;
  
  Console.Clear();
  Console.WriteLine("Введите число: ");
  Num = Convert.ToInt32(Console.ReadLine());
  
  Res = Num;
  
  if (Num > 99 && Num < 1000)
  {
    lastFigure = Num % 10;
    
    Console.WriteLine($"Третья цифра заданного числа равна {lastFigure}");
  }
  
  else if (Num < 100)
  {
    Console.WriteLine("Третьей цифры у заданного числа нет");
  }
  
  
  while (Res > 999)
  {
    Res = Res / 10;
  
    if (Res > 99 && Res < 1000)
    {
    lastFigure = Res % 10;
    Console.WriteLine($"Третья цифра заданного числа равна {lastFigure}");
    }
  }