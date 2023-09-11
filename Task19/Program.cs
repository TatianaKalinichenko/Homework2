// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

string result = PalindromCheck(num);
if (result = "1")  Console.WriteLine("Число является палиндромом.");
else Console.WriteLine("Число не является палиндромом.");

string PalindromCheck(int number)
{
    int digit1 = number / 10000;
    int digit2 = number / 1000 % 10;
    int digit4 = number / 10 % 1000;
    int digit5 = number % 10000;

    if (digit1 == digit5 && digit2 == digit4) return "1";
    else return "0";
}