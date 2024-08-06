namespace PokemonCardTrading.Domain.Entities;

public class PokemonCard
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public string Condition { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }

    // 외래 키 및 탐색 속성
    public int UserId { get; set; }
    public User User { get; set; } = null!;
}