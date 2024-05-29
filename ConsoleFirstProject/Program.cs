Func<int, int, int> sub = (a,b) => a - b;
Func<int, int> doubleNum = x => x * 2;
Func<int, int> tripleNum = x =>
{
    int aux = 3;
    return x * aux;
};

int result = sub(10, 5);
Console.WriteLine(result);

result = doubleNum(result);
Console.WriteLine(result);

result = tripleNum(result);
Console.WriteLine(result);