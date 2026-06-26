namespace GameStore.Repository;

using Dtos;
using Entities;

public interface IGameRepository
{
    List<GameSummaryDto> GetAll();
    Game? GetById(int id);

    Game? GetByName(String name);

    int? GetMaxId(Game game);

    void Add(Game game);

    bool Update(int index, UpdateGameDto updatedgame);
    void Delete(Game game);
}

