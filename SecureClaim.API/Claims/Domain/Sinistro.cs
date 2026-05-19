namespace SecureClaim.API.Claims.Domain.Entities;

public class Sinistro
{
    public long Id { get; set; }

    public string Descricao { get; set; }

    public string Status { get; set; }

    public DateTime DataOcorrencia { get; set; }

    public void Abrir()
    {
        Status = "ABERTO";
    }

    public void Aprovar()
    {
        Status = "APROVADO";
    }

    public void Encerrar()
    {
        Status = "ENCERRADO";
    }
}