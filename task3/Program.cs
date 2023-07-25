/*Задача 3: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int AckFun(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m != 0) && (n == 0))
    {
        return AckFun(m - 1, 1);
    }

    return AckFun(m - 1, AckFun(m, n - 1));

}
int m = ReadInt("Введите число M => ");
int n = ReadInt("Введите число N => ");
System.Console.WriteLine(AckFun(m, n));