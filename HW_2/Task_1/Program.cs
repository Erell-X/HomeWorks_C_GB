﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int Num, secondFigure;
  
  Console.Clear();
  
  Console.WriteLine("Введите трёхзначное число:");
  Num = Convert.ToInt32(Console.ReadLine());
  
  if (99 < Num && Num < 1000 || -1000 < Num && Num < -99)
  {
    
    if (Num < 0)
    {
      Num = -Num;
    }
    
    secondFigure = Num / 10;
    secondFigure = secondFigure % 10;
    
    Console.WriteLine($"Вторая цифра введённого числа = {secondFigure}");
  }
  
  else
  {
   Console.WriteLine("Число не является трёхзначным"); 
  }