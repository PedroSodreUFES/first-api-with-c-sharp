namespace MyFirstApi.Entities;

public sealed class Laptop : Device // sealed: bloqueia a classe de ser pai de alguém
{
    public override string GetBrand() // implementado método abstrato de Device
    {
        return "Apple";
    }

    public string GetModel()
    {
        var isConnected = IsConnected();
        if (isConnected)
            return "MacBook";

        return "Unknown";
    }

    public override string Hello()  // sobrescrevendo método virtual de device
    {
        return "Hello, Sodras, mensagem alterada em laptop";
    }
}