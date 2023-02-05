// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трёхзначное число :");
string numberStr = Console.ReadLine();
int numberN = Convert.ToInt32(numberStr);
Console.WriteLine(numberN % 10);

Console.WriteLine("Введите двухзначное число");
string number2Str = Console.ReadLine();
string str = number2Str.ToString();
Console.WriteLine(str[1]);



