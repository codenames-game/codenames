using Codenames.Client;
using Microsoft.AspNetCore.SignalR;

namespace Server.GameHubs;

public class GameHub : Hub<IGameClient>
{
    public override async Task OnConnectedAsync()
    {
    }
}