// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number *= -1;

int secondDigit = number / 10 % 10;

if (number < 100 || number > 999) Console.WriteLine("Введенное число не трехзначное. Попробуйте еще раз.");
else Console.WriteLine($"Вторая цифра -> {secondDigit}");
