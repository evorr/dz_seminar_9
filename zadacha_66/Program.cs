//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в 
//промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.Write("Задайте число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());


void SumNaturalNumber (int numM, int numN, int sum)
{
    if(numN==numM) 
    {
        Console.Write($"{sum+numN} ");
        return;
    }  
    sum=sum+numN;
    SumNaturalNumber(numM, numN-1,sum);
}
Console.Write($"M = {numberM}; N = {numberN} -> ");
if(numberM<numberN)SumNaturalNumber(numberM,numberN,0);
else SumNaturalNumber(numberN,numberM,0);
