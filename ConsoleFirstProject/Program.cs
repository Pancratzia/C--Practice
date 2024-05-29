var venta = new Venta();
var prestamo = new Prestamo();

Some(venta);
Some(prestamo);


void Some(ISave save)
{
    save.Save();
}

public interface IVenta
{
    public decimal Total { get; set; }
    public string GetInfo();
}

public interface ISave
{
    public void Save();
}


public class Venta : IVenta, ISave
{
    public decimal Total { get; set; }

    public Venta()
    {
        Total = 100;
    }
    public string GetInfo()
    {
        return "El total es: " + Total;
    }
    public void Save()
    {
        Console.WriteLine("Guardando venta");
    }
}

public class Prestamo : ISave
{
    public void Save()
    {
        Console.WriteLine("Guardando prestamo");
    }
}
