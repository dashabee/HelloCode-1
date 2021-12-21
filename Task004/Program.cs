// Найти максимальное из трех чисел
int a = 12;
int b = 8;
int c = 10;
int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.Write("Max = ");
Console.WriteLine(max);
