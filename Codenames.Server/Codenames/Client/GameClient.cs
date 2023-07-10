namespace Codenames.Client;

public class GameClient : IGameClient
{
    public Guid GameId { get; private init; }

    public GameClient()
    {
        GameId = new Guid();
    }

    public void CreateGame(string gameRoomName)
    {
        throw new NotImplementedException();
    }

    public void JoinGame(string gameRoomName)
    {
        throw new NotImplementedException();
    }

    public void ResetGame(string gameRoomName)
    {
        throw new NotImplementedException();
    }

    public void LeaveGame(string gameRoomName)
    {
        throw new NotImplementedException();
    }

    public void JoinAsOperative(string userId)
    {
        throw new NotImplementedException();
    }

    public void JoinAsSpyMaster(string userId)
    {
        throw new NotImplementedException();
    }

    public void SelectCell(int cellId)
    {
        throw new NotImplementedException();
    }

    public void ReturnBoard()
    {
        throw new NotImplementedException();
    }
}