namespace SnookerTracker.Models;

public class Achievement
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public AchievementTier Tier { get; set; }
    public bool IsUnlocked { get; set; }
    public DateTime? UnlockedDate { get; set; }
}

public enum AchievementTier
{
    Bronze,
    Silver,
    Gold,
    Diamond
}
