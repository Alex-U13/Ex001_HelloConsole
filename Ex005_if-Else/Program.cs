Console.WriteLine("Введите имя пользоваеля");
string username = Console.ReadLine();

if(username == "Cаша")
{
    Console.WriteLine("Ура, это же CАША");
}
else {
    Console.WriteLine($"Привет, {username}");
}