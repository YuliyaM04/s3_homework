// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// вычисления значения c Math.Pow
Console.Clear();
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= num)
{
 Console.WriteLine($"{i} | {Math.Pow(i, 3)}");
i++;
}

// Решение с i*i*i
// Console.Clear();
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// while (i <= num)
// {
//     Console.WriteLine($"{i} | {i*i*i}");   
//     i++;
// }



