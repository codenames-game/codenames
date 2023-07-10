using Codenames.Contracts;

namespace Codenames.Games;

public interface IBoardGenerator
{
    public Cell[,] GenerateBoard(List<string> wordList, CellTeam firstTeam);
}