namespace SnookerTracker.Models;

public class PracticeSession
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime Date { get; set; } = DateTime.Now;
    public int DurationMinutes { get; set; }
    public int HighestBreak { get; set; }
    public List<string> DrillsCompleted { get; set; } = new();
    public string Notes { get; set; } = string.Empty;
    public int PottingRating { get; set; } // 1-10
    public int SafetyRating { get; set; } // 1-10
    public int PositionalRating { get; set; } // 1-10
    public int FocusRating { get; set; } // 1-10
}
