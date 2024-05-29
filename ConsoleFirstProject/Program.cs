using System.Runtime.CompilerServices;

var numbers = new MyList<int>(5);
var names = new MyList<string>(4);
var beers = new MyList<Beer>(3);

numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);
numbers.Add(6); // Will not be added

Console.WriteLine(numbers.GetContet());

names.Add("Pancratzia");
names.Add("Teresa");
names.Add("Arthuro");
names.Add("Tiffany");
names.Add("Cristian"); // Will not be added

Console.WriteLine(names.GetContet());

beers.Add(new Beer
{
    Name = "Corona",
    Price = 9.99m
});

beers.Add(new Beer
{
    Name = "Heineken",
    Price = 8.99m
});

beers.Add(new Beer
{
    Name = "Stella Artois",
    Price = 7.99m
});

beers.Add(new Beer
{
    Name = "Budweiser",
    Price = 6.99m
}); // Will not be added

Console.WriteLine(beers.GetContet());

public class MyList<T>
{
    private List<T> _list;
    private int _limit;

    public MyList(int limit)
    {
        _limit = limit;
        _list = new List<T>();
    }


    public void Add(T element)
    {
        if (_list.Count < _limit)
        {
            _list.Add(element);
        }
    }

    public string GetContet()
    {
        string content = "";
        foreach (var item in _list)
        {
            content += item + " ";
        }
        return content;
    }
}

class Beer
{
    public string Name { get; set; }

    public decimal Price { get; set; }

    public override string ToString()
    {
        return "Nombre: " + Name + " - Precio: " + Price;
    }
}
