using Codenames.Games;

namespace Codenames.Store;

public interface IGameStore
{
    public bool TryAddGame(GameBoard game, out Guid? gameId);
    
    public GameBoard GetGame(Guid gameId);

    public bool TryDeleteGame(Guid gameId);
}