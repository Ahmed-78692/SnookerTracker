using SnookerTracker.Models;

namespace SnookerTracker.Services;

public class CoachService
{
    private readonly DataService _data;

    public CoachService(DataService data) { _data = data; }

    public async Task<string> GetSessionSummaryAsync()
    {
        var sessions = await _data.GetSessionsAsync();
        if (!sessions.Any()) return "Start logging sessions to get coaching feedback.";

        var last = sessions.OrderByDescending(s => s.Date).First();
        var last5 = sessions.OrderByDescending(s => s.Date).Take(5).ToList();
        var tips = new List<string>();

        if (last.PottingRating <= 4) tips.Add("Your potting was low today. Spend 20 minutes on the Line-Up drill tomorrow.");
        if (last.SafetyRating <= 4) tips.Add("Safety needs work. Practice Baulk Return for 15 minutes.");
        if (last.PositionalRating <= 4) tips.Add("Positional play struggled. Try the T Drill focusing on cue ball only.");
        if (last.FocusRating <= 4) tips.Add("Focus was off. Consider shorter, more intense sessions (60 min max).");

        if (last5.Count >= 3)
        {
            var avgPot = last5.Average(s => s.PottingRating);
            var avgSafe = last5.Average(s => s.SafetyRating);
            if (avgPot > 7 && avgSafe > 7) tips.Add("Great form! You're ready to push for bigger breaks. Try the 10 Red Clearance.");
            if (last5.Average(s => s.DurationMinutes) > 120) tips.Add("You're putting in serious hours. Make sure you're getting enough rest.");
        }

        if (!tips.Any()) tips.Add("Solid session! Keep the consistency going. Consider upping the difficulty on your drills.");

        return string.Join(" ", tips);
    }

    public async Task<string> PredictNextCenturyAsync()
    {
        var breaks = await _data.GetBreaksAsync();
        if (!breaks.Any()) return "Log more breaks to get a prediction.";

        var highest = breaks.Max(b => b.Score);
        if (highest >= 100) return $"You've already made a century! ({highest}). Now aim for consistency — make 5 more.";

        var recent = breaks.OrderByDescending(b => b.Date).Take(10).ToList();
        if (recent.Count < 3) return "Need more break data. Keep logging!";

        var avgRecent = recent.Average(b => b.Score);
        var trend = recent.Count > 5 ? recent.Take(5).Average(b => b.Score) - recent.Skip(5).Average(b => b.Score) : 0;

        if (trend > 5) return $"Your breaks are improving fast! At this rate, century possible within 4-6 weeks. Current best: {highest}.";
        if (trend > 0) return $"Steady progress. Century likely within 2-3 months. Keep pushing past {highest}.";
        return $"Breaks have plateaued around {(int)avgRecent}. Mix up your drills — try the Six Red Clearance to break through.";
    }

    public async Task<(int optimalMinutes, string insight)> GetFatigueAnalysisAsync()
    {
        var sessions = await _data.GetSessionsAsync();
        if (sessions.Count < 5) return (90, "Not enough data yet. Log at least 5 sessions.");

        var short_sessions = sessions.Where(s => s.DurationMinutes <= 60).ToList();
        var medium_sessions = sessions.Where(s => s.DurationMinutes > 60 && s.DurationMinutes <= 120).ToList();
        var long_sessions = sessions.Where(s => s.DurationMinutes > 120).ToList();

        var shortAvg = short_sessions.Any() ? short_sessions.Average(s => (s.PottingRating + s.PositionalRating + s.SafetyRating + s.FocusRating) / 4.0) : 0;
        var mediumAvg = medium_sessions.Any() ? medium_sessions.Average(s => (s.PottingRating + s.PositionalRating + s.SafetyRating + s.FocusRating) / 4.0) : 0;
        var longAvg = long_sessions.Any() ? long_sessions.Average(s => (s.PottingRating + s.PositionalRating + s.SafetyRating + s.FocusRating) / 4.0) : 0;

        if (longAvg > mediumAvg && longAvg > shortAvg)
            return (150, $"You perform BEST in long sessions (2+ hours). Avg rating: {longAvg:F1}. You're built for match play endurance.");
        if (mediumAvg >= shortAvg)
            return (90, $"Your sweet spot is 60-120 minutes. Performance: {mediumAvg:F1}/10. After 2 hours your quality drops.");
        return (60, $"Short focused sessions work best for you. Avg: {shortAvg:F1}/10. Quality over quantity.");
    }

    public async Task<(string bestTime, string insight)> GetBestTimeAnalysisAsync()
    {
        var sessions = await _data.GetSessionsAsync();
        if (sessions.Count < 5) return ("Unknown", "Need more sessions at different times to analyze.");

        var morning = sessions.Where(s => s.Date.Hour < 12).ToList();
        var afternoon = sessions.Where(s => s.Date.Hour >= 12 && s.Date.Hour < 17).ToList();
        var evening = sessions.Where(s => s.Date.Hour >= 17).ToList();

        var scores = new List<(string time, double avg, int count)>
        {
            ("Morning", morning.Any() ? morning.Average(s => s.PottingRating + s.PositionalRating) / 2.0 : 0, morning.Count),
            ("Afternoon", afternoon.Any() ? afternoon.Average(s => s.PottingRating + s.PositionalRating) / 2.0 : 0, afternoon.Count),
            ("Evening", evening.Any() ? evening.Average(s => s.PottingRating + s.PositionalRating) / 2.0 : 0, evening.Count)
        };

        var best = scores.Where(s => s.count >= 2).OrderByDescending(s => s.avg).FirstOrDefault();
        if (best.count < 2) return ("Unknown", "Practice at different times to find your peak.");
        return (best.time, $"You perform best in the {best.time.ToLower()} (avg: {best.avg:F1}/10 across {best.count} sessions).");
    }

    public async Task<int> CalculateXPAsync()
    {
        var sessions = await _data.GetSessionsAsync();
        var breaks = await _data.GetBreaksAsync();
        var drills = await _data.GetDrillAttemptsAsync();
        var matches = await _data.GetMatchesAsync();

        int xp = 0;
        xp += sessions.Count * 10; // 10 XP per session
        xp += sessions.Sum(s => s.DurationMinutes / 10); // 1 XP per 10 min
        xp += breaks.Count * 5; // 5 XP per break logged
        xp += breaks.Where(b => b.Score >= 50).Count() * 20; // 20 XP per 50+
        xp += breaks.Where(b => b.IsCentury).Count() * 100; // 100 XP per century
        xp += drills.Count * 3; // 3 XP per drill attempt
        xp += matches.Count(m => m.IsWin) * 25; // 25 XP per match win

        return xp;
    }

    public DailyChallenge GetDailyChallenge()
    {
        var drills = new List<(string id, string name, int target)>
        {
            ("line-up", "The Line-Up", 12),
            ("long-blue", "Long Blue Drill", 5),
            ("t-drill", "The T Drill", 35),
            ("color-clearance", "Color Clearance", 20),
            ("baulk-return", "Baulk Return Safety", 7),
            ("stun-run-screw", "Stun, Run & Screw", 22),
            ("three-red-clearance", "Three Red Clearance", 30),
            ("pressure-pots", "Pressure Potting", 4),
            ("deep-screw", "Deep Screw Shot", 5),
            ("six-red-clearance", "Six Red Clearance", 35),
        };

        var dayIndex = DateTime.Today.DayOfYear % drills.Count;
        var (id, name, target) = drills[dayIndex];

        return new DailyChallenge
        {
            Date = DateTime.Today,
            DrillId = id,
            DrillName = name,
            TargetScore = target
        };
    }

    public List<RivalComparison> GetProRivals() => new()
    {
        new() { ProName = "Ronnie O'Sullivan", ProAgeWhenStarted = 7, ProHoursAtYourStage = 5000, ProHighestBreakAtYourStage = 100, ProNote = "Made first century at age 10. Practiced 6+ hours daily from age 8." },
        new() { ProName = "Judd Trump", ProAgeWhenStarted = 9, ProHoursAtYourStage = 4000, ProHighestBreakAtYourStage = 80, ProNote = "Turned pro at 16. Known for aggressive, attacking play. Practice focus: long potting." },
        new() { ProName = "Mark Selby", ProAgeWhenStarted = 8, ProHoursAtYourStage = 4500, ProHighestBreakAtYourStage = 70, ProNote = "3x World Champion. Built career on safety and match toughness. 4-5 hours daily." },
        new() { ProName = "Neil Robertson", ProAgeWhenStarted = 10, ProHoursAtYourStage = 3500, ProHighestBreakAtYourStage = 90, ProNote = "Moved from Australia to UK at 17 for snooker. Extreme dedication." },
        new() { ProName = "Stephen Hendry", ProAgeWhenStarted = 12, ProHoursAtYourStage = 4000, ProHighestBreakAtYourStage = 100, ProNote = "7x World Champion. Credits the T-Drill for his 775 centuries." },
    };
}
