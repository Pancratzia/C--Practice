var beer = new Beer()
{
    Name = "Corona"
};


Console.WriteLine(ToUpper(beer).Name);
Console.WriteLine(beer.Name);



Beer ToUpper (Beer beer) //No es pura pues modifica el objeto original
{
    beer.Name = beer.Name.ToUpper();
    return beer;
}

class Beer
{
    public string Name { get; set; }
}