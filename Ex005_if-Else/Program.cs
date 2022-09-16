Console.WriteLine("Введите имя пользоваеля");
string username = Console.ReadLine();

if(username.ToLower() == "саша")
{
    Console.WriteLine("Ура, это же CАША! Привеет!");
}
else {
    Console.WriteLine($"Привет, {username}");
}