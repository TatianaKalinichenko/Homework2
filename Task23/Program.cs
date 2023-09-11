// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0) CubeTable(number);
else Console.WriteLine("Введенное число не натуральное. Попробуйте еще раз.");

void CubeTable(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i,3} |{i * i * i,5}");
    }
}