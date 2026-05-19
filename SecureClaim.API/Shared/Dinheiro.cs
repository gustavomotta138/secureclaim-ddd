namespace SecureClaim.API.Shared.ValueObjects;

public class Dinheiro
{
    public decimal Valor { get; }

    public string Moeda { get; }

    public Dinheiro(decimal valor, string moeda)
    {
        Valor = valor;
        Moeda = moeda;
    }
}