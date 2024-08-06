namespace PokemonCardTrading.Domain.Entities;

public class Favorite
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public int CardId { get; set; }
    public PokemonCard Card { get; set; } = null!;
}