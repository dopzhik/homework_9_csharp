/*Задача 1: Задайте значение N. Напишите программу, которая выведет все 
ЧЕТНЫЕ натуральные числа в промежутке от 1 до N. Выполнить с помощью рекурсии.
N = 5, M = 9 -> "6, 8"
N = 2, M = 10 -> "2, 4, 6, 8, 10"*/

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void EvenNumbers(int n, int m)
{
    if (n > m) return;
    if (n % 2 == 1) n++;
    System.Console.WriteLine(n);
    n += 2;
    EvenNumbers(n, m);
}

int n = ReadInt("Введите число N => ");
int m = ReadInt("Введите число M => ");
EvenNumbers(n, m);