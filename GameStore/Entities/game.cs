using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace GameStore.Entities;

public class Game
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public  Genre Genre { get; set; } = null;
    public required Guid GenreId { get; set; }
    public required string Description { get; set; }
    public required decimal Price { get; set; }
    public required DateTime ReleaseDate { get; set; }
}

public class Genre()

{
    public Guid Id { get; set; }
    public String Name { get; set; }
}