namespace PokemonCardTrading.Domain.Entities;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string ProfilePictureUrl { get; set; } = string.Empty;

    // 탐색 속성
    public ICollection<PokemonCard> PokemonCards { get; set; } = new List<PokemonCard>();
}