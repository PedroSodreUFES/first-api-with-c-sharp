namespace MyFirstApi.Entities;

public abstract class Device
{
    protected bool IsConnected() => true; // só pode ser usado em operações dentro da classe ou da classe filha

    public abstract string GetBrand(); // classes filhas devem implementar

    public virtual string Hello() // pode ser sobrescrita em uma classe filha
    {
        return "Hello, Sodras: mensagem original";
    }
}