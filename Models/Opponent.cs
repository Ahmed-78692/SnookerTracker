namespace SnookerTracker.Models;

public class Opponent
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public string Strengths { get; set; } = string.Empty;
    public string Weaknesses { get; set; } = string.Empty;
    public string Tactics { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
    public DateTime LastPlayed { get; set; } = DateTime.Now;
}

public class Tournament
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public DateTime Date { get; set; } = DateTime.Now.AddDays(14);
    public string Venue { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
    public List<string> PrepChecklist { get; set; } = new()
    {
        "Cue tip checked and shaped",
        "Practice minimum 2 hours daily this week",
        "Focus on long potting confidence",
        "Play at least 2 practice matches",
        "Visualize winning the final frame",
        "Early night before match day",
        "Light warm-up on match day (30 min)",
        "Hydration and light meal 2 hours before"
    };
    public List<bool> ChecklistCompleted { get; set; } = new() { false, false, false, false, false, false, false, false };
}
