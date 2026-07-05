namespace SnookerTracker.Models;

public class TrainingPlan
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int WeekNumber { get; set; }
    public TrainingPhase Phase { get; set; }
    public List<DailyPlan> Days { get; set; } = new();
}

public class DailyPlan
{
    public string DayName { get; set; } = string.Empty;
    public string Focus { get; set; } = string.Empty;
    public List<PlannedDrill> Drills { get; set; } = new();
    public int TargetMinutes { get; set; }
}

public class PlannedDrill
{
    public string DrillId { get; set; } = string.Empty;
    public string DrillName { get; set; } = string.Empty;
    public int DurationMinutes { get; set; }
    public int Sets { get; set; } = 1;
}

public enum TrainingPhase
{
    Foundation,
    Development,
    BreakBuilding,
    MatchPrep,
    Tournament
}

public class MentalLog
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime Date { get; set; } = DateTime.Now;
    public int Confidence { get; set; } // 1-10
    public int Focus { get; set; } // 1-10
    public int PressureHandling { get; set; } // 1-10
    public int Enjoyment { get; set; } // 1-10
    public string PreSessionMindset { get; set; } = string.Empty;
    public string PostSessionReflection { get; set; } = string.Empty;
    public string KeyLearning { get; set; } = string.Empty;
}
