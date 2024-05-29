var names = new List<string>()
{
    "Pancratzia", "Arhuro", "Tiffany", "Teresa"
};

var namesResult = from n in names
                  orderby n descending
                  select n;

foreach (var name in namesResult)
{
    Console.WriteLine(name);
}