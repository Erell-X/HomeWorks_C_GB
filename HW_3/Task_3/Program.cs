// Задача 23.
// Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

int num, cube, multi;

cube = 0;
multi = 1;

Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

Console.Write("Ряд кубов: ");

while (multi < num)
{
  cube = multi * multi * multi;
  Console.Write($"{cube}, ");
  multi++;
  
  if (multi == num)
  {
    cube = multi * multi * multi;
    Console.Write(cube);
  }
}