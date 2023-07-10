using Codenames.Games;
using Codenames.Store;

namespace Codenames.Repository;

public class GameRepository : IGameRepository
{
    private readonly IGameStore _store;
    
    public GameRepository(IGameStore store)
    {
        _store = store;
    }


    public GameBoard GetGame(Guid gameId)
    {
        return _store.GetGame(gameId);
    }

    public bool TryDeleteGame(Guid gameId)
    {
        return _store.TryDeleteGame(gameId);
    }
}