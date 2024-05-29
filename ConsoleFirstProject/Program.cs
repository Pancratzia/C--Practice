using System.Text.Json;

var pancratzia = new People()
{
    Name = "Pancratzia",
    Age = 23
};

string json = JsonSerializer.Serialize(pancratzia);
Console.WriteLine(json);


string myJSON = @"{
""Name"":""Pancratzia"",
""Age"":23
}";

var pancratzia2 = JsonSerializer.Deserialize<People>(myJSON);
Console.WriteLine(pancratzia2?.Name);
Console.WriteLine(pancratzia2?.Age);

People? pancratzia3 = null;

Console.WriteLine(pancratzia3?.Name);
Console.WriteLine(pancratzia3?.Age);


public class People
{
    public string Name { get; set; }
    public int Age { get; set; }

}