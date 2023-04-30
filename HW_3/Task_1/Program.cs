// Задача 19.
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Clear();

int Number, FirstDigit, SecondDigit, FourthDigit, FifthDigit;

Console.Write("Введите пятизначное число: ");
Number = Convert.ToInt32(Console.ReadLine());

if (9999 < Number && Number < 100000)
{

FirstDigit = Number / 10000;
SecondDigit = Number / 1000 % 10;
FourthDigit = Number / 10 % 10;
FifthDigit = Number % 10;

  if (FirstDigit == FifthDigit && SecondDigit == FourthDigit)
  {
    Console.WriteLine("Введённое пятизначное число является ПАЛИНДРОМОМ");
  }
  
  else
  {
    Console.WriteLine("Введённое пятизначное число НЕ является ПАЛИНДРОМОМ");
  }

}

else Console.WriteLine("Число не является ПЯТИЗНАЧНЫМ");