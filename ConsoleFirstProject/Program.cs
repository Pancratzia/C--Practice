var sale = new Sale(15);

var message = sale.GetInfo();
Console.WriteLine(message);

sale.Total = 20;
message = sale.GetInfo();
Console.WriteLine("Ahora el total ha cambiado!");
Console.WriteLine(message);


Console.WriteLine("Ahora creamos una venta con impuestos");
var saleWithTax = new SaleWithTax(20, 15);
message = saleWithTax.GetInfo();
Console.WriteLine(message);

message = saleWithTax.GetInfo("Hola, soy un método sobrecargado");
Console.WriteLine(message);

message = saleWithTax.GetInfo(20);
Console.WriteLine(message);

class Sale
{
    //public se puede acceder desde cualquier lugar
    //private solo se puede acceder desde dentro de la clase
    //protected solo se puede acceder desde dentro de la clase o de las clases derivadas
    public decimal Total { get; set; }
    private decimal _some;

    public Sale(decimal total)
    {
        Total = total;
        _some = 0;
    }

    public virtual string GetInfo()
    {
        return "El total es: " + Total;
    }

    public string GetInfo(string message)
    {
        return message;
    }

    public string GetInfo(int total)
    {
        return "El total manual: " + total;
    }
}

class SaleWithTax : Sale
{

    public decimal Tax { get; }
    public SaleWithTax(decimal total, decimal tax) : base(total)
    {
        Tax = tax;
    }

    public override string GetInfo()
    {
        return base.GetInfo() + " y el impuesto es: " + Tax;
    }
}
