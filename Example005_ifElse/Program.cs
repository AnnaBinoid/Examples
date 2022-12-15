Console.WriteLine("Write user name: ");
string userName = Console.ReadLine();

if (userName.ToLower() == "mary")
{
    Console.WriteLine("Hurray! It's Mary!");
}
else
{
    Console.WriteLine("Hi, " + userName + "!");
}