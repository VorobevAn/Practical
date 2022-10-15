
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Ведите число: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine(SumNamber(number));

int SumNamber(int nam)
{
int sum = 0;
    while(nam > 0)
    {
        sum = sum + nam % 10;
        nam = nam / 10;
    }
return sum;
}

