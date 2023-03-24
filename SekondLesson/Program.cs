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

int CutThirdNumber (int num)
{
  while (num > 999)
  {
  num /= 10;
  }
return num % 10;
}

int Print(string message)
{
  Console.Write(message);
  string value = "";
  value = Console.ReadLine();
  int result = Convert.ToInt32(value);
  return result;
}

bool NotThird (int num)
{
  if (num < 100)
  {
    Console.WriteLine("Третьей цифры нет");
    return false;
  }
  return true;
}

int num = Print("введите число - ");
  if (NotThird(num))
{
  Console.WriteLine(CutThirdNumber(num));
}


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// int WeekDayRandom = new Random().Next(1,8);

// Console.WriteLine($"Сегодня {WeekDayRandom} по счету день");

// if (WeekDayRandom == 6)
//   {
//     Console.WriteLine("сегодня суббота");
//   }
//   if (WeekDayRandom == 7)
//   {
//   Console.WriteLine("сегодня воскресенье");
//   }
// else
//     Console.WriteLine("сегодня будний день");
  


