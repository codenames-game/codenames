namespace Codenames.Contracts;

public class Cell
{
    public CellState State { get; set; }
    public CellTeam CellTeam { get; set; }
    public string Word { get; set; }
}