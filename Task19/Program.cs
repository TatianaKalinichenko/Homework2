// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0) num = num * -1;

bool palindrom = PalindromCheck(num);
if (palindrom == true) Console.WriteLine("Это палиндром");
else Console.WriteLine("Это не палиндром");

bool PalindromCheck(int number)
{
    int digit1 = number / 10000;
    int digit2 = number / 1000 % 10;
    int digit4 = number / 10 % 10;
    int digit5 = number % 10;

    return digit1 == digit5 && digit2 == digit4;
}
