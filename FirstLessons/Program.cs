//Homework 1.

//Task 1
// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

// Console.Write("Input yor number A: ");
// int num1 = Convert.ToInt32(Console.ReadLine ());
// Console.WriteLine("Число А = " + num1);

// Console.WriteLine("Input yor number B: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Число B = " + num2);

// if(num1 > num2)
// {
// Console.WriteLine($"Число А = {num1} больше числа B = {num2}.");
// }
// if (num1 == num2)
// {
//   Console.WriteLine("Числа равны!");
// }
// else
// {
//   Console.WriteLine($"Число B = {num2} больше числа A = {num1}.");
// }

//Task 2
// Напишите программу, 
//которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Console.Write("Input your number A: ");
// int num1 = Convert.ToInt32(Console.ReadLine ());
// Console.WriteLine("Число А = " + num1);

// Console.WriteLine("Input your number B: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Число B = " + num2);

// Console.Write("Input your number C: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Число С =" + num3);

// int max = num1;

// if (max < num2)
//    {
//     max = num2;
//    }

// else max = num1;

// if (max < num3)
//    {
//     max = num3;
//    }

// else max = num1;
// {
//   Console.Write("Максимальное число: "+ max);
// }
//Task 3
//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Input your number");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 2 > 0)
//   {
//     Console.WriteLine(num + " - Нечетное число");
//   }
//   else
//   {
//     Console.WriteLine(num + " - Четное число");
//   }


// Task 4
//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите любое положительное число N: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current <= num)
{
  if (current % 2 == 0)
  {
    Console.Write(current + " ");
  }
current ++;
}