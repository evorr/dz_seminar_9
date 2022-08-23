//Задача 68: Напишите программу вычисления функции 
//Аккермана с помощью рекурсии. Даны два 
//неотрицательных числа m и n.
//m = 3, n = 2 -> A(m,n) = 29

Console.Write("Задайте неотрицательное число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте неотрицательное число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());


int Akkerman(int m, int n) 
{
    if (m == 0)
    {
        return n + 1;
    }    
    if (m > 0)
    {
        if (n == 0)
        {
            return Akkerman(m - 1, 1);
        }
    }
    return Akkerman(m - 1, Akkerman(m, n - 1));
}
        
Console.Write($"m = {numberM}, n = {numberN} -> A(m,n) ");
Console.Write(Akkerman(numberM, numberN));


