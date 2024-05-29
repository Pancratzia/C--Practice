
var show = Show;

show("Hello World!");

Some(Show, "Some message");
void Show(string message)
{
    Console.WriteLine(message);
}

void Some(Action<string> fn, string message)
{
    Console.WriteLine("Hola!");
    fn(message);

    Console.WriteLine("Adios!");
}