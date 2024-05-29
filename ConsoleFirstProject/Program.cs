Console.WriteLine(Some((a, b) => a + b, 1));

int Some (Func <int, int, int> fn, int number)
{
    var result = fn(number, number);
    return result;
}
