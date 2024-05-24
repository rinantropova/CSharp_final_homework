// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void PrintNaturalNum(int a, int b)
{

    Console.Write($"{a} ");
    if (a == b) return;
    int increment = (b - a) / Math.Abs(b - a);
    PrintNaturalNum(a + increment, b);


}



Console.WriteLine("Input number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintNaturalNum(m, n);