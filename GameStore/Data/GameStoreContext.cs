namespace GameStore.Data;

using Microsoft.EntityFrameworkCore;
using Entities;

public class GameStoreContext(DbContextOptions<GameStoreContext> options) : DbContext(options)
{
    public DbSet<Game> Games => Set<Game>();
    public DbSet<Genre> genres => Set<Genre>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var genreid = Guid.Parse("11111111-1111-1111-1111-111111111111");
        modelBuilder.Entity<Genre>().HasData(
            new Genre()

            {
                Id = genreid,
                Name = "fight games"
            }
        );
        modelBuilder.Entity<Game>().HasData(
            new Game
            {
                Id = 1,
                Name = "Action-adventure",
                GenreId = genreid,
                Description = "The Legend of Zelda: Breath of the Wild",
                Price = 59.99m,
                ReleaseDate = new DateTime(2017, 3, 3)
            },
            new Game
            {
                Id = 2,
                Name = "Action-adventure",
                GenreId = genreid,
                Description = "Red Dead Redemption 2",
                Price = 59.99m,
                ReleaseDate = new DateTime(2018, 10, 26)
            },
            new Game
            {
                Id = 3,
                Name = "Action RPG",
                GenreId = genreid,
                Description = "Cyberpunk 2077",
                Price = 59.99m,
                ReleaseDate = new DateTime(2020, 12, 10)
            }
        );
    }
}
