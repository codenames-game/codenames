using Codenames.Contracts;

namespace Codenames.Games;

public class BoardGenerator : IBoardGenerator
{
    private int blueLeft = 8;
    private int redLeft = 8;
    private int greyLeft = 7;
    private int assassinLeft = 1;
    
    private Random _rnd;

    public BoardGenerator()
    {
        _rnd = new Random();
    }

    public Cell[,] GenerateBoard(List<string> wordList, CellTeam firstTurn)
    {
        if (firstTurn == CellTeam.Blue)
            blueLeft += 1;
        else
            redLeft += 1;
        
        var board = new Cell[5, 5];
        
        for (var i = 0; i < 5; i++)
        {
            for (var j = 0; j < 5; i++)
            {
                var word = GetRandomWord(wordList);
                board[i, j] = CreateCell(word);
            }
        }

        ShuffleBoard();
        return board;
    }

    private void ShuffleBoard()
    {
        
    }
    
    private Cell CreateCell(string word)
    {
        return new Cell()
        {
            CellTeam = AssignTeam(),
            State = CellState.Unselected,
            Word = word
        };
    }

    private string GetRandomWord(IList<string> wordList)
    {
        var index = _rnd.Next(0, wordList.Count);
        var word = wordList[index];
        wordList.RemoveAt(index);
        return word;
    }

    private CellTeam AssignTeam()
    {
        if (redLeft > 0)
            return CellTeam.Red;
        if (blueLeft > 0)
            return CellTeam.Blue;
        return greyLeft > 0 ? CellTeam.Grey : CellTeam.Assassin;
    }
}