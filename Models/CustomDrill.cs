namespace SnookerTracker.Models;

public class CustomDrill
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DrillCategory Category { get; set; }
    public DrillDifficulty Difficulty { get; set; }
    public string Instructions { get; set; } = string.Empty;
    public int TargetScore { get; set; }
    public int MaxScore { get; set; }
    public string? ImageBase64 { get; set; } // Stored as base64 data URL
    public DateTime CreatedDate { get; set; } = DateTime.Now;
}

public class BreakComposition
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime Date { get; set; } = DateTime.Now;
    public int TotalScore { get; set; }
    public int RedsWithBlack { get; set; }
    public int RedsWithPink { get; set; }
    public int RedsWithBlue { get; set; }
    public int RedsWithBrown { get; set; }
    public int RedsWithGreen { get; set; }
    public int RedsWithYellow { get; set; }
    public string BreakdownReason { get; set; } = string.Empty; // missed pot, bad position, safety error
}

public class DailyNote
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime Date { get; set; } = DateTime.Now;
    public string? PhotoBase64 { get; set; }
    public string Caption { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty; // table position, technique, setup
}
