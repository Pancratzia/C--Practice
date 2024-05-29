var beer = new Beer()
{
    Name = "Corona"
};


Console.WriteLine(ToUpper(beer).Name);
Console.WriteLine(beer.Name);



Beer ToUpper (Beer beer) //Es pura, ya que crea una nueva instancia y no modifica el valor original
{
    var newBeer = new Beer()
    {
        Name = beer.Name.ToUpper()
    };

    return newBeer;
}

class Beer
{
    public string Name { get; set; }
}