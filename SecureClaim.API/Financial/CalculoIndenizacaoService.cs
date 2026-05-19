namespace SecureClaim.API.Financial.Domain.Services;

public class CalculoIndenizacaoService
{
    public decimal Calcular(
        decimal valorDano,
        decimal franquia)
    {
        return valorDano - franquia;
    }
}