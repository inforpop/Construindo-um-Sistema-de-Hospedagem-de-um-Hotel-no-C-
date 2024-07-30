public class Hospede
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Documento { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
}

public class Quarto
{
    public int Id { get; set; }
    public string Numero { get; set; }
    public string Tipo { get; set; }
    public decimal Preco { get; set; }
    public bool Disponivel { get; set; }
}

public class Reserva
{
    public int Id { get; set; }
    public int HospedeId { get; set; }
    public int QuartoId { get; set; }
    public DateTime DataEntrada { get; set; }
    public DateTime DataSaida { get; set; }
    public decimal ValorTotal { get; set; }
}
