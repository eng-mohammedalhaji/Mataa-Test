using GameStore.Dtos;
using GameStore.GameStoreMapping;
using Microsoft.EntityFrameworkCore;


namespace GameStore.Repository;

using Data;
using Entities;

public class GameStoreRepository(GameStoreContext context) : IGameRepository
{
    public List<GameSummaryDto> GetAll()
    {
        return context.Games.Include(g => g.Genre)
            .Select(g => g.ToSummryDto()).ToList()!;
    }

    public Game? GetById(int id)
    {
        return context.Games.Find(id);
    }

    public Game? GetByName(String name)
    {
        return context.Games.FirstOrDefault(game => game.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public int? GetMaxId(Game game)

    {
        return context.Games.Max(g => g.Id);
    }

    public void Add(Game game)
    {
        context.Add(game);
        context.SaveChanges();
    }

    public bool Update(int index, UpdateGameDto updatedgame)
    {
        var game = GetById(index);
        if (game is null) return false;
        context.Entry(game).CurrentValues.SetValues(updatedgame);
        context.SaveChanges();
        return true;
    }

    public void Delete(Game game)
    {
        context.Remove(game);
        context.SaveChanges();
    }
}



