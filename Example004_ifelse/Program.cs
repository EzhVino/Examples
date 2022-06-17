
Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "misha")
{
    Console.WriteLine("You are not welcome anymore, " + username);
}
else{
    Console.Write("Welcome, ");
    Console.WriteLine(username);
}

