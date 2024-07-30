using System.Data.Entity;

public class HotelContext : DbContext
{
    public DbSet<Hospede> Hospedes { get; set; }
    public DbSet<Quarto> Quartos { get; set; }
    public DbSet<Reserva> Reservas { get; set; }

    public HotelContext() : base("name=HotelDB")
    {
    }
}
