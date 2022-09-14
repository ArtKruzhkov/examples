Console.WriteLine("enter your name");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("yey, welcome Masha");
}
else
{
    Console.Write("hello,");
    Console.WriteLine(username);
}