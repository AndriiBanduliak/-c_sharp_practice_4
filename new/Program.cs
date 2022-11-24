using static System.Console;
Clear();

Write("Введите число, факториал которого надо посчитать: ");
int fact = Convert.ToInt32(ReadLine());

int i = 1;

for (int j = 1; fact >= j; j++)
{
    i = i * j;
}

WriteLine($"факториал числа {fact} , равен - {i} ");