using SnookerTracker.Components;

namespace SnookerTracker.Models;

public class Drill
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DrillCategory Category { get; set; }
    public DrillDifficulty Difficulty { get; set; }
    public string Instructions { get; set; } = string.Empty;
    public int TargetScore { get; set; }
    public int MaxScore { get; set; }
    public DrillTableSetup? TableSetup { get; set; }
}

public class DrillTableSetup
{
    public List<BallPosition> Balls { get; set; } = new();
    public List<ArrowPath> Arrows { get; set; } = new();
    public List<TargetZone> Zones { get; set; } = new();
}

public class DrillAttempt
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string DrillId { get; set; } = string.Empty;
    public DateTime Date { get; set; } = DateTime.Now;
    public int Score { get; set; }
    public string Notes { get; set; } = string.Empty;
}

public enum DrillCategory
{
    Potting,
    Positional,
    Safety,
    BreakBuilding,
    CueBall,
    LongPotting,
    Clearance
}

public enum DrillDifficulty
{
    Beginner,
    Intermediate,
    Advanced,
    Pro
}
