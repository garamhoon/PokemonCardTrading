namespace PokemonCardTrading.Domain.Entities;

public class Rating
{
    public int Id { get; set; }
    public int TradeId { get; set; }
    public Trade Trade { get; set; } = null!;
    public int RaterId { get; set; }
    public User Rater { get; set; } = null!;
    public int RatedUserId { get; set; }
    public User RatedUser { get; set; } = null!;
    public int RatingValue { get; set; }
    public string Comment { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}