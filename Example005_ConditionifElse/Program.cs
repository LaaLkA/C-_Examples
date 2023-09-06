Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();
if(username.ToLower() == "юля")
{
Console.WriteLine("Ура, это же Юля!");
}
else
{
    Console.Write("Привет,");
    Console.Write(username);
}