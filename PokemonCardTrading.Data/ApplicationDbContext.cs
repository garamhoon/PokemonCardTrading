using Microsoft.EntityFrameworkCore;
using PokemonCardTrading.Domain.Entities;

namespace PokemonCardTrading.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<PokemonCard> PokemonCards { get; set; }
    public DbSet<Trade> Trades { get; set; }
    public DbSet<Rating> Ratings { get; set; }
    public DbSet<Favorite> Favorites { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // 필요한 엔티티 구성
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.HasMany(e => e.PokemonCards)
                .WithOne(pc => pc.User)
                .HasForeignKey(pc => pc.UserId);
        });

        modelBuilder.Entity<PokemonCard>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.HasOne(e => e.User)
                .WithMany(u => u.PokemonCards)
                .HasForeignKey(e => e.UserId);
        });

        modelBuilder.Entity<Trade>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.HasOne(e => e.RequestingUser)
                .WithMany()
                .HasForeignKey(e => e.RequestingUserId);
            entity.HasOne(e => e.OfferingUser)
                .WithMany()
                .HasForeignKey(e => e.OfferingUserId);
            entity.HasOne(e => e.RequestedCard)
                .WithMany()
                .HasForeignKey(e => e.RequestedCardId);
            entity.HasOne(e => e.OfferedCard)
                .WithMany()
                .HasForeignKey(e => e.OfferedCardId);
        });

        modelBuilder.Entity<Rating>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.HasOne(e => e.Trade)
                .WithMany()
                .HasForeignKey(e => e.TradeId);
            entity.HasOne(e => e.Rater)
                .WithMany()
                .HasForeignKey(e => e.RaterId);
            entity.HasOne(e => e.RatedUser)
                .WithMany()
                .HasForeignKey(e => e.RatedUserId);
        });

        modelBuilder.Entity<Favorite>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.HasOne(e => e.User)
                .WithMany()
                .HasForeignKey(e => e.UserId);
            entity.HasOne(e => e.Card)
                .WithMany()
                .HasForeignKey(e => e.CardId);
        });
    }
}