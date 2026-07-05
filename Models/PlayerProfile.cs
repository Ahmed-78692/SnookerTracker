namespace SnookerTracker.Models;

public class PlayerProfile
{
    public int XP { get; set; }
    public PlayerLevel Level => XP switch
    {
        < 100 => PlayerLevel.Beginner,
        < 500 => PlayerLevel.ClubPlayer,
        < 1500 => PlayerLevel.Amateur,
        < 4000 => PlayerLevel.SemiPro,
        < 10000 => PlayerLevel.Professional,
        _ => PlayerLevel.WorldClass
    };
    public int XPToNextLevel => Level switch
    {
        PlayerLevel.Beginner => 100,
        PlayerLevel.ClubPlayer => 500,
        PlayerLevel.Amateur => 1500,
        PlayerLevel.SemiPro => 4000,
        PlayerLevel.Professional => 10000,
        _ => 99999
    };
    public double LevelProgress => XPToNextLevel > 0 ? Math.Min(100, (double)XP / XPToNextLevel * 100) : 100;
}

public enum PlayerLevel
{
    Beginner,
    ClubPlayer,
    Amateur,
    SemiPro,
    Professional,
    WorldClass
}

public class DailyChallenge
{
    public DateTime Date { get; set; } = DateTime.Today;
    public string DrillId { get; set; } = string.Empty;
    public string DrillName { get; set; } = string.Empty;
    public int TargetScore { get; set; }
    public bool Completed { get; set; }
    public int? ActualScore { get; set; }
}

public class Challenge
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = string.Empty;
    public string DrillId { get; set; } = string.Empty;
    public int TargetScore { get; set; }
    public DateTime Deadline { get; set; } = DateTime.Now.AddDays(7);
    public bool Completed { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
}

public class RivalComparison
{
    public string ProName { get; set; } = string.Empty;
    public int ProAgeWhenStarted { get; set; }
    public int ProHoursAtYourStage { get; set; }
    public int ProHighestBreakAtYourStage { get; set; }
    public string ProNote { get; set; } = string.Empty;
}
