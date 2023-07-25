/*Задача 2: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int m, int n)
{
    if (m > n)
    {
        return 0;
    }
    return m + SumNumbers(m + 1, n);
}
int m = ReadInt("Введите число M => ");
int n = ReadInt("Введите число N => ");
System.Console.WriteLine(SumNumbers(m, n));