// Задача 26: Напишите программу, которая принимает на вход 
//число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

//на входе может быть вещественное число
//в функцию

// int SumNum(int num)
// {
//     int i = 0;
//     while (num > 0)
//     {
//         num /= 10;

//         i++;
//     }
//     return i;
// }


Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"Количество цифр в числе {num} равно {SumNum(num)}");


int SumNum(int num)
{
    int i = 0;
    while (num > 0)
    {
        num /= 10;

        i++;
    }
    return i;
}

//
// int x3 = (int)Math.Pow(10, 3 - 1); 
