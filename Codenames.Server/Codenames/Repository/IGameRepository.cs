using Codenames.Games;

namespace Codenames.Repository;

public interface IGameRepository
{
    public GameBoard GetGame(Guid gameId);

    public bool TryDeleteGame(Guid gameId);
}