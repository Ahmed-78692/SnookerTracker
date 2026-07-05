using SnookerTracker.Models;

namespace SnookerTracker.Services;

public class AchievementService
{
    private readonly DataService _data;

    public AchievementService(DataService data)
    {
        _data = data;
    }

    public async Task<List<Achievement>> CheckAchievementsAsync()
    {
        var sessions = await _data.GetSessionsAsync();
        var breaks = await _data.GetBreaksAsync();
        var drills = await _data.GetDrillAttemptsAsync();
        var matches = await _data.GetMatchesAsync();

        var achievements = GetAllAchievements();

        // Check each achievement
        foreach (var a in achievements)
        {
            a.IsUnlocked = a.Id switch
            {
                "first-session" => sessions.Count >= 1,
                "week-warrior" => sessions.Count >= 7,
                "month-grinder" => sessions.Count >= 30,
                "century-club" => breaks.Any(b => b.Score >= 100),
                "half-century" => breaks.Any(b => b.Score >= 50),
                "first-break" => breaks.Any(b => b.Score >= 20),
                "maximum" => breaks.Any(b => b.Score >= 147),
                "drill-starter" => drills.Count >= 1,
                "drill-master" => drills.Count >= 50,
                "drill-legend" => drills.Count >= 200,
                "streak-3" => CalculateStreak(sessions) >= 3,
                "streak-7" => CalculateStreak(sessions) >= 7,
                "streak-30" => CalculateStreak(sessions) >= 30,
                "match-winner" => matches.Any(m => m.IsWin),
                "ten-wins" => matches.Count(m => m.IsWin) >= 10,
                "tournament-win" => matches.Any(m => m.IsWin && m.Type == Models.MatchType.Tournament),
                "hour-100" => sessions.Sum(s => s.DurationMinutes) >= 6000,
                "hour-500" => sessions.Sum(s => s.DurationMinutes) >= 30000,
                "five-centuries" => breaks.Count(b => b.IsCentury) >= 5,
                "break-70" => breaks.Any(b => b.Score >= 70),
                _ => false
            };
        }

        return achievements;
    }

    private int CalculateStreak(List<PracticeSession> sessions)
    {
        if (!sessions.Any()) return 0;
        var dates = sessions.Select(s => s.Date.Date).Distinct().OrderByDescending(d => d).ToList();
        int streak = 0;
        var checkDate = DateTime.Today;
        foreach (var date in dates)
        {
            if (date == checkDate || date == checkDate.AddDays(-1))
            {
                streak++;
                checkDate = date;
            }
            else break;
        }
        return streak;
    }

    private List<Achievement> GetAllAchievements() => new()
    {
        new() { Id = "first-session", Name = "First Steps", Description = "Complete your first practice session", Icon = "👣", Tier = AchievementTier.Bronze },
        new() { Id = "week-warrior", Name = "Week Warrior", Description = "Complete 7 practice sessions", Icon = "⚔️", Tier = AchievementTier.Bronze },
        new() { Id = "month-grinder", Name = "Month Grinder", Description = "Complete 30 practice sessions", Icon = "🔥", Tier = AchievementTier.Silver },
        new() { Id = "first-break", Name = "Breaking In", Description = "Record a 20+ break", Icon = "🎱", Tier = AchievementTier.Bronze },
        new() { Id = "half-century", Name = "Half Century", Description = "Score a 50+ break", Icon = "5️⃣", Tier = AchievementTier.Silver },
        new() { Id = "break-70", Name = "Frame Winner", Description = "Score a 70+ break", Icon = "🏅", Tier = AchievementTier.Silver },
        new() { Id = "century-club", Name = "Century Club", Description = "Make your first century break (100+)", Icon = "💯", Tier = AchievementTier.Gold },
        new() { Id = "five-centuries", Name = "Century Machine", Description = "Make 5 century breaks", Icon = "🏆", Tier = AchievementTier.Gold },
        new() { Id = "maximum", Name = "MAXIMUM!", Description = "Score the perfect 147", Icon = "👑", Tier = AchievementTier.Diamond },
        new() { Id = "drill-starter", Name = "Drill Rookie", Description = "Complete your first drill attempt", Icon = "🎯", Tier = AchievementTier.Bronze },
        new() { Id = "drill-master", Name = "Drill Master", Description = "Complete 50 drill attempts", Icon = "🥋", Tier = AchievementTier.Silver },
        new() { Id = "drill-legend", Name = "Drill Legend", Description = "Complete 200 drill attempts", Icon = "🐉", Tier = AchievementTier.Gold },
        new() { Id = "streak-3", Name = "Consistent", Description = "Practice 3 days in a row", Icon = "📅", Tier = AchievementTier.Bronze },
        new() { Id = "streak-7", Name = "Dedicated", Description = "Practice 7 days in a row", Icon = "💪", Tier = AchievementTier.Silver },
        new() { Id = "streak-30", Name = "Unstoppable", Description = "Practice 30 days in a row", Icon = "⚡", Tier = AchievementTier.Diamond },
        new() { Id = "match-winner", Name = "Winner", Description = "Win your first match", Icon = "✌️", Tier = AchievementTier.Bronze },
        new() { Id = "ten-wins", Name = "Dominant", Description = "Win 10 matches", Icon = "🦁", Tier = AchievementTier.Silver },
        new() { Id = "tournament-win", Name = "Champion", Description = "Win a tournament match", Icon = "🏆", Tier = AchievementTier.Gold },
        new() { Id = "hour-100", Name = "100 Hours", Description = "Practice for 100 total hours", Icon = "⏰", Tier = AchievementTier.Silver },
        new() { Id = "hour-500", Name = "500 Hours", Description = "Practice for 500 total hours", Icon = "🕐", Tier = AchievementTier.Diamond },
    };
}
