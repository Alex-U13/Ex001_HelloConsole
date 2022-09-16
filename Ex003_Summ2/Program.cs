//Console.WriteLine("Введите первое целое число");
// string a = Console.ReadLine();
//int numberA = Convert.ToInt32(a);

//Console.WriteLine("Введите второе целое число");
//string b = Console.ReadLine();
//int numberB = Convert.ToInt32(b);

//int Summ = numberA + numberB;
//Console.WriteLine($"Сумма чисел равна {Summ}"); 

int numberA = new Random().Next(1, 10); // случайные целые цисла от 1 до 9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine($"Сумма двух случайных чисел {result}");