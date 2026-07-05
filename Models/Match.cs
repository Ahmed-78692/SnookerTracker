namespace SnookerTracker.Models;

public class MatchRecord
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime Date { get; set; } = DateTime.Now;
    public string OpponentName { get; set; } = string.Empty;
    public int FramesWon { get; set; }
    public int FramesLost { get; set; }
    public int HighestBreak { get; set; }
    public MatchType Type { get; set; }
    public string Notes { get; set; } = string.Empty;
    public bool IsWin => FramesWon > FramesLost;
}

public enum MatchType
{
    Practice,
    Club,
    League,
    Tournament,
    Ranking
}
