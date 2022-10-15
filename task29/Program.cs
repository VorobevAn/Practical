

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 2, 4, 9 -> [1, 2, 5, 7, 19, 2, 4, 9 ]
// 6, 1, 33, 2, 93, 15, 424, 0-> [6, 1, 33, 2, 93, 15, 424, 0]


int[] rey = new int[8]; 
Arrey(rey);
PrintArrey(rey);

void Arrey(int[]rey1)
{
       for (int i = 0; i < rey1.Length; i++)
    {
        rey1[i] = new Random().Next(0,1000);
    }
}

 void PrintArrey(int[] rey1)
{
    for (int i = 0; i < rey1.Length; i++)
    {
        Console.Write($"{rey1[i]}, ");
    }
}






// int[] arrey = new int[10];

// for (int i = 0; i < arrew.Length; i++)
// {
//     arrey[i] = new Random().Next();
//     Console.Write($"{arrey[i]}, ");

// }






