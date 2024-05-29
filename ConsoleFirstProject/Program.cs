
var show = Show;

Some(show, "Hello World!");


string Show(string message)
{
    return message.ToUpper();
}

void Some(Func<string, string> fn, string message)
{
    Console.WriteLine("Hola!");
    Console.WriteLine(fn(message));
    Console.WriteLine("Adios!");
}