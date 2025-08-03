namespace MyFirstApi.Entities;

public sealed class Smartphone : Device // sealed: bloqueia a classe de ser pai de alguém
{

    public override string GetBrand() // implementado método abstrato de Device
    {
        return "Samsung";
    }

    public string GetModel()
    {
        var isConnected = IsConnected();
        if (isConnected)
            return "Galaxy S20";

        return "Unknown";
    }

    
}