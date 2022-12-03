// Задача 28: Напишите программу, которая принимает на вход число N и 
//выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120


// int SumNumbers(int num)
// {
//     int sum = 0;

//     for (int i = 1; i <= num; i++) sum += i;
//     return sum;
// }

// int CopNum (int num)
// {
// int comp = 1;
// for (int i = 1; i <= num; i++)
// {

//     comp = comp * i;
// }
// return comp;
// }
// Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{CopNum(num)}");

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
//больше ли единииц чем нулей true or faulse



int count0 = 0;
int count1 = 0;
int[] arr = new int[8];
for (int i = 0; i < 8; i++)
{
    arr[i] = new Random().Next(0, 2);
    Console.Write($"{arr[i]}  ");}
//     if (arr[i] == 0) //вариант с подсчетом 0 и 1 неверный
//     {
//         count0 = count0++;
//         Console.Write($"{Нулей больше");
//     }
//     else 
//     {
//         count1 = count1++;
//         Console.Write("Единиц больше");
// }}


// if (count0 > count1) 

// else if (count1 > count0) 
// else Console.Write ("Равное количество");


/// пример решения 2й задачи
// int[] rendr(int len)
// {
//     int[] array = new int[len];
//     Random rnd = new Random();
//     for (int i = 0; i < len; i++)
//     {
//         array[i] = rnd.Next(0, 2);
//     }
//     return array;
// }
// int len = 8;
// int[] array = rendr(len);
// // Array.ForEach(array, Console.WriteLine);
// for (int i = 0; i < len; i++)
// {
//     Console.Write($"{array[i]} ");
// }
