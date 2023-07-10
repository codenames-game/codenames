using Codenames.Client;
using Codenames.Games;
using Codenames.Repository;
using Codenames.Store;
using Microsoft.Extensions.DependencyInjection;

namespace Codenames;

public static class CodenamesDependencyInjection
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddSingleton<IGameClient, GameClient>();
        services.AddSingleton<IGameRepository, GameRepository>();
        services.AddSingleton<IGameStore, InMemoryGameStore>();
        services.AddTransient<IBoardGenerator, BoardGenerator>();
    }
}