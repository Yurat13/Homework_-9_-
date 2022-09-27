// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Enter number M:");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter number N:");
int n = int.Parse(Console.ReadLine() ?? "0");
int a = 0;
for (int i = m; i <= n; i++)
{
    a = a + i;
}
Console.WriteLine($"Element's sum of interval from M till N: {a}");

// int ShowNumberFromMtillN (int m, int n) // Решение с помощью рекурсии
// {
//     int i = 0;
//     if (m == n) return m + n;
//     if (m < n) i = n + ShowNumberFromMtillN (m, n - 1);
//     return i;
//     // return 0;
// }

// Console.WriteLine(ShowNumberFromMtillN (1, 4));