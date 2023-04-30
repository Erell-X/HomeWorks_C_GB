// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();

int Num;

Console.Write("Введите число: ");
Num = Convert.ToInt32(Console.ReadLine());

if (Num % 2 == 0 && Num != 0)
{
 Console.WriteLine($"Число является чётным");
}

else if (Num % 2 == 1 || Num % 2 == -1)
{
 Console.WriteLine($"Число является нечётным");
}

else if (Num == 0)
{
 Console.WriteLine($"Число не является ни чётным, ни нечётным");
}