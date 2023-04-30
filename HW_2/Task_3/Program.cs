// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

int Day;
  
  Console.WriteLine("Введите день недели:");
  Day = Convert.ToInt32(Console.ReadLine());
  
  switch(Day) {
    
    case 1:
      {
          Console.WriteLine("Не является выходным днём");
          Console.WriteLine();
          break;
      }

    case 2:
      {
          Console.WriteLine("Не является выходным днём");
          Console.WriteLine();
          break;
      }

    case 3:
      {
          Console.WriteLine("Не является выходным днём");
          Console.WriteLine();
          break;
      }

    case 4:
      {
          Console.WriteLine("Не является выходным днём");
          Console.WriteLine();
          break;
      }

    case 5:
      {
          Console.WriteLine("Не является выходным днём");
          Console.WriteLine();
          break;
      }

    case 6:
      {
          Console.WriteLine("Выходной день");
          Console.WriteLine();
          break;
      }

    case 7:
      {
          Console.WriteLine("Выходной день");
          Console.WriteLine();
          break;
      }
    
    default:
      {
          Console.WriteLine("Нет такого дня недели");
          Console.WriteLine();
          break;
      }

  }