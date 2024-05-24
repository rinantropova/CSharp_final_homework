// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29


int CalculateAckermannFunc(int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return CalculateAckermannFunc(m - 1, 1);
    }
    else
    {
        return CalculateAckermannFunc(m - 1, CalculateAckermannFunc(m, n - 1));
    }
    
}

Console.WriteLine("Input number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(CalculateAckermannFunc(m, n));