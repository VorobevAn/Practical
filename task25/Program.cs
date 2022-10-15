

// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Write("Ведите число: ");
int number1 = int.Parse(Console.ReadLine()!);

Console.Write("Ведите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

Degree(number1);

int Degree(int result)
{
     result = 1;
    for (int i = 1; i <= number2; i++)
    {
        result = result * number1;
    }
    Console.WriteLine(result);
 return result; 
}