// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трехзначное число :");
string number2Str = Console.ReadLine();
string str = number2Str.ToString();
Console.WriteLine(str[1]);




