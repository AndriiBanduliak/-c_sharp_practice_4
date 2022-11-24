using static System.Console;
Clear();


Write("Введите число, факториал которого надо посчитать : ");
int x = Convert.ToInt32(ReadLine());

int g = 1;

for (int i = 1; x >= i; ++i)
{
    g = g * i;
}

WriteLine($"Факториал числа: {x} равен: {g}");

