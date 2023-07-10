using System.Collections.Concurrent;
using Codenames.Client;
using Codenames.Games;

namespace Codenames.Store;

public class InMemoryGameStore : IGameStore
{
    private ConcurrentDictionary<Guid, GameBoard> _gamesById;

    public InMemoryGameStore()
    {
        _gamesById = new ConcurrentDictionary<Guid, GameBoard>();
    }
    
    public bool TryAddGame(GameBoard game, out Guid? gameId)
    {
        var newGameId = Guid.NewGuid();
        
        try
        {
            var isAdded = _gamesById.TryAdd(newGameId, game);
            gameId = isAdded ? newGameId : null;
            return isAdded;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            gameId = null;
            return false;
        }
    }

    public GameBoard GetGame(Guid gameId)
    {
        throw new NotImplementedException();
    }

    public bool TryDeleteGame(Guid gameId)
    {
        throw new NotImplementedException();
    }
}