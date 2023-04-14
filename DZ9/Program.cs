//Задача 64: Задайте значение N. Напишите программу, которая выведет
//все натуральные числа в промежутке от N до 1
//Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"

/*
void Print(int num)
{
    if(num > 0)
    {
        Console.Write(num + " ");
        Print(num - 1);
    } 
}
Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
Print(num);
*/

//Задача 66: Задайте значения M и N. Напишите программу,
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120


// int PLusNums(int numM, int numN)
// {
//     if (numM != numN)
//     {
//         if(numM > numN) return PLusNums(numM - 1, numN) + numM;
//         else return PLusNums(numM + 1, numN) + numM;
//     } 
//     return numN;
// }
// Console.WriteLine("Найдём сумму цифр в промежутке от M до N!");
// Console.Write("Введите число M: ");
// int numM = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int numN = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Искомое число = {PLusNums(numM, numN)}");


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

// int FindAkkerman(int num1, int num2)
// {
//     if (num1 == 0) return num2 + 1;
//     if (num1 > 0 && num2 == 0) return FindAkkerman(num1 - 1, 1);
//     if (num1 > 0 && num2 > 0) return FindAkkerman(num1 - 1, FindAkkerman(num1, num2 - 1));
//     return FindAkkerman(num1, num2);
// }

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($" Функция Аккермана равна: {FindAkkerman(num1, num2)}");