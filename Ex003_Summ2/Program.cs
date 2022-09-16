Console.WriteLine("Введите первое целое число");
string a = Console.ReadLine();
int numberA = Convert.ToInt32(a);

Console.WriteLine("Введите второе целое число");
string b = Console.ReadLine();
int numberB = Convert.ToInt32(b);

int Summ = numberA + numberB;
Console.WriteLine($"Сумма чисел равна {Summ}");