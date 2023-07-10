using Codenames.Contracts;

namespace Codenames.Games;

public class GameBoard : IGameBoard
{
    private Cell[,] _board;
    private readonly IBoardGenerator _boardGenerator;
    private CellTeam _firstTurn;

    public GameBoard(IBoardGenerator boardGenerator)
    {
        InitializeBoard();
        _firstTurn = CellTeam.Blue;
    }

    private void InitializeBoard()
    {
        var wordList = WordListGenerator.GenerateWordList();

        _board = _boardGenerator.GenerateBoard(wordList, _firstTurn);
    }
}