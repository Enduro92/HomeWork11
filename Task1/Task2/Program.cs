// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.WriteLine("Введите цифру дня недели :");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 1 && number <=7) {
	if (number >= 6) {
		Console.WriteLine("Это выходной");
	} else {
		Console.WriteLine("Это рабочий день");
	}
} else {
	
}