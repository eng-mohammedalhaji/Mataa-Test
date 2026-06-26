namespace GameStore.Dtos;

using Entities;

public record GameDto(
    int Id,
    string Name,
    Genre Genre,
    Guid GenreId,
    string Description,
    decimal Price,
    DateTime ReleaseDate
);

public record UpdateGameDto(
    string Name,
    string Description,
    decimal Price,
    DateTime ReleaseDate
);

public record GameSummaryDto(
    int Id,
    string Name,
    string Genre
);