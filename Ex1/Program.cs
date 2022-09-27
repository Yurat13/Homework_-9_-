// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Console.WriteLine("Enter number M:");
// int m = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Enter number N:");
// int n = int.Parse(Console.ReadLine() ?? "0");
// for (int i = m; i <= n; i++)
// {
//     Console.Write($"{i} ");
// }

void ShowNumberFromMtillN (int m, int n) // Решение с помощью рекурсии
{
    if (m < n) ShowNumberFromMtillN (m, n - 1);
    Console.Write (n + " ");
}

ShowNumberFromMtillN (4, 8);