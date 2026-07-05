namespace SnookerTracker.Models;

public class Goal
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public GoalType Type { get; set; }
    public int TargetValue { get; set; }
    public int CurrentValue { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime? TargetDate { get; set; }
    public bool IsCompleted => CurrentValue >= TargetValue;
    public double ProgressPercentage => TargetValue > 0 ? Math.Min(100, (double)CurrentValue / TargetValue * 100) : 0;
}

public enum GoalType
{
    HighestBreak,
    CenturyCount,
    PracticeHours,
    ConsecutiveDays,
    DrillScore
}
