namespace Codenames.Client;

public interface IGameClient
{
    public void CreateGame(string gameRoomName);

    public void JoinGame(string gameRoomName);

    public void ResetGame(string gameRoomName);

    public void LeaveGame(string gameRoomName);

    public void JoinAsOperative(string userId);

    public void JoinAsSpyMaster(string userId);

    public void SelectCell(int cellId);

    public void ReturnBoard();
}