using static System.Console;
Clear();

WriteLine("Введите число, колличество цифр в котором нужно посчитать: ");
float n = float.Parse(ReadLine());

int digitCount = (int)Math.Log10(n) + 1;

Console.WriteLine($"Количество цифр в числе 'N': {digitCount}");
