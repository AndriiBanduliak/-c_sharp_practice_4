using static System.Console;
Clear();

int ReadFromConsole(string message)
{
    WriteLine(message);
    return int.Parse(ReadLine());
}
int sumFrom(int a)
{
    int summ = 0;
    for (int i = 1; i <= a; i++)
        summ += i;
        return summ;
}
int a = ReadFromConsole("Enter a: ");
int suma = sumFrom(a);

Write(suma);