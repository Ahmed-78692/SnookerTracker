namespace SnookerTracker.Models;

public class BreakRecord
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime Date { get; set; } = DateTime.Now;
    public int Score { get; set; }
    public bool IsCentury => Score >= 100;
    public bool IsMaximum => Score == 147;
    public string Notes { get; set; } = string.Empty;
}
