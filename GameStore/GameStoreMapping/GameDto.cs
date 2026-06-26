using GameStore.Data;

namespace GameStore.GameStoreMapping;

using Entities;
using Dtos;

public static class GameDtoMapping
{
    public static GameDto ToDto(this Game game)
    {
        return new GameDto(
            game.Id,
            game.Name,
            game.Genre,
            game.GenreId,
            game.Description,
            game.Price,
            game.ReleaseDate
        );
    }

    public static Game ToEntity(this GameDto gameDto)
    {
        return new Game
        {
            Id = gameDto.Id,
            Name = gameDto.Name,
            Genre = gameDto.Genre,
            GenreId = gameDto.GenreId,
            Description = gameDto.Description,
            Price = gameDto.Price,
            ReleaseDate = gameDto.ReleaseDate
        };
    }

    public static GameSummaryDto ToSummryDto(this Game game)
    {
        return new GameSummaryDto(
            game.Id,
            game.Name,
            game.Genre.Name
        );
    }
}