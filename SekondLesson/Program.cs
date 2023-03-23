// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int CutNumber (int num)
// {
//   int dozens = num / 10;
//   int last = dozens % 10;
//   int result = last;
//   return result;
// }

// int randNumber = new Random().Next(100, 1000);
// int newNumber = CutNumber(randNumber);
// Console.WriteLine($"Second number of {randNumber} is {newNumber}")
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int randNumber1= new Random().Next(0, 10000);
// Console.WriteLine("Случайное число - " + randNumber1);

// int chooisNumber (int num1)

// {
//   int third = num1 % 100;

//   if (third <= 0)
//   Console.Write($"третьего числа в {randNumber1} нет");
//   if (third > 1 && third <10)
//     {
//       int first = num1;
//       Console.Write($"третье число в {randNumber1} = {first}");
//       break
//     }
// }




// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int WeekDayRandom = new Random().Next(1,8);

Console.WriteLine($"Сегодня {WeekDayRandom} по счету день");

if (WeekDayRandom == 6)
  {
    Console.WriteLine("сегодня суббота");
  }
  if (WeekDayRandom == 7)
  {
  Console.WriteLine("сегодня воскресенье");
  }
else
    Console.WriteLine("сегодня будний день");
  


