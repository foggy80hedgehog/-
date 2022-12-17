
Console.WriteLine("Введите число: ");

string numberStr = Console.ReadLine() ?? "";
int number = int.Parse(numberStr);
int result = number * number;

Console.WriteLine($"Квадрат числа {number} = {result}");
