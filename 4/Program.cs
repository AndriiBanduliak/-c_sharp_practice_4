using static System.Console;
Clear();



int n = 0, a = 0, b = 0;
int[] arr = null;

Write("Введите n - размер массива arr (n > 1): ");
n = Int32.Parse(ReadLine());
while (n < 2)
{
    WriteLine("Ошибка: значение n должно быть больше 1!");
    Write("Повторите ввод: ");
    n = Int32.Parse(ReadLine());
}

Write("Введите a - левую границу промежутка для заполнения нулями (a < n): ");
a = Int32.Parse(ReadLine());
while (a <= 0 || a >= n)
{
    WriteLine("Ошибка: значение a должно быть больше 0 и меньше n!");
    Write("Повторите ввод: ");
    a = Int32.Parse(ReadLine());
}

Write($"Введите b - правую границу промежутка для заполнения нулями (b > a и b <= n): ");
b = Int32.Parse(ReadLine());
while (b <= a || b > n)
{
    WriteLine($"Ошибка: значение b должно быть больше a и меньше или равно n!");
    Write("Повторите ввод: ");
    b = Int32.Parse(ReadLine());
}

arr = new int[n];
Write("Полученный массив arr: ");
for (int i = 0; i < arr.Length; i++)
    arr[i] = Convert.ToInt32(!((i + 1 > a) && (i + 1 < b)));
WriteLine(String.Join(", ", arr));

ReadKey(true);
