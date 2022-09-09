// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
PrintNumbers(M, N);
Console.Write($"{PrintNumbers(M,N)} ");
int PrintNumbers(int x, int y)
{   
    int sum = x;
    if (x == y) return sum;
    sum = sum + PrintNumbers (x +1, y);
    return sum;
}