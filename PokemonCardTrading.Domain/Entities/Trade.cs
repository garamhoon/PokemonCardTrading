namespace PokemonCardTrading.Domain.Entities;

public class Trade
{
    public int Id { get; set; }
    public int RequestingUserId { get; set; }
    public User RequestingUser { get; set; } = null!;
    public int OfferingUserId { get; set; }
    public User OfferingUser { get; set; } = null!;
    public int RequestedCardId { get; set; }
    public PokemonCard RequestedCard { get; set; } = null!;
    public int OfferedCardId { get; set; }
    public PokemonCard OfferedCard { get; set; } = null!;
    public string Status { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}