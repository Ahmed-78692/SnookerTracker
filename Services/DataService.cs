using Microsoft.JSInterop;
using SnookerTracker.Models;
using System.Text.Json;

namespace SnookerTracker.Services;

public class DataService
{
    private readonly IJSRuntime _js;
    private const string SessionsKey = "snooker_sessions";
    private const string BreaksKey = "snooker_breaks";
    private const string DrillAttemptsKey = "snooker_drill_attempts";
    private const string GoalsKey = "snooker_goals";
    private const string MatchesKey = "snooker_matches";
    private const string MentalLogsKey = "snooker_mental_logs";

    public DataService(IJSRuntime js)
    {
        _js = js;
    }

    // === Practice Sessions ===
    public async Task<List<PracticeSession>> GetSessionsAsync()
    {
        return await GetAsync<List<PracticeSession>>(SessionsKey) ?? new();
    }

    public async Task SaveSessionAsync(PracticeSession session)
    {
        var sessions = await GetSessionsAsync();
        var existing = sessions.FindIndex(s => s.Id == session.Id);
        if (existing >= 0)
            sessions[existing] = session;
        else
            sessions.Add(session);
        await SetAsync(SessionsKey, sessions);
    }

    public async Task DeleteSessionAsync(Guid id)
    {
        var sessions = await GetSessionsAsync();
        sessions.RemoveAll(s => s.Id == id);
        await SetAsync(SessionsKey, sessions);
    }

    // === Break Records ===
    public async Task<List<BreakRecord>> GetBreaksAsync()
    {
        return await GetAsync<List<BreakRecord>>(BreaksKey) ?? new();
    }

    public async Task SaveBreakAsync(BreakRecord breakRecord)
    {
        var breaks = await GetBreaksAsync();
        breaks.Add(breakRecord);
        await SetAsync(BreaksKey, breaks);
    }

    public async Task DeleteBreakAsync(Guid id)
    {
        var breaks = await GetBreaksAsync();
        breaks.RemoveAll(b => b.Id == id);
        await SetAsync(BreaksKey, breaks);
    }

    // === Drill Attempts ===
    public async Task<List<DrillAttempt>> GetDrillAttemptsAsync()
    {
        return await GetAsync<List<DrillAttempt>>(DrillAttemptsKey) ?? new();
    }

    public async Task<List<DrillAttempt>> GetDrillAttemptsAsync(string drillId)
    {
        var all = await GetDrillAttemptsAsync();
        return all.Where(a => a.DrillId == drillId).OrderByDescending(a => a.Date).ToList();
    }

    public async Task SaveDrillAttemptAsync(DrillAttempt attempt)
    {
        var attempts = await GetDrillAttemptsAsync();
        attempts.Add(attempt);
        await SetAsync(DrillAttemptsKey, attempts);
    }

    // === Goals ===
    public async Task<List<Goal>> GetGoalsAsync()
    {
        return await GetAsync<List<Goal>>(GoalsKey) ?? new();
    }

    public async Task SaveGoalAsync(Goal goal)
    {
        var goals = await GetGoalsAsync();
        var existing = goals.FindIndex(g => g.Id == goal.Id);
        if (existing >= 0)
            goals[existing] = goal;
        else
            goals.Add(goal);
        await SetAsync(GoalsKey, goals);
    }

    public async Task DeleteGoalAsync(Guid id)
    {
        var goals = await GetGoalsAsync();
        goals.RemoveAll(g => g.Id == id);
        await SetAsync(GoalsKey, goals);
    }

    // === Matches ===
    public async Task<List<MatchRecord>> GetMatchesAsync()
    {
        return await GetAsync<List<MatchRecord>>(MatchesKey) ?? new();
    }

    public async Task SaveMatchAsync(MatchRecord match)
    {
        var matches = await GetMatchesAsync();
        var existing = matches.FindIndex(m => m.Id == match.Id);
        if (existing >= 0)
            matches[existing] = match;
        else
            matches.Add(match);
        await SetAsync(MatchesKey, matches);
    }

    public async Task DeleteMatchAsync(Guid id)
    {
        var matches = await GetMatchesAsync();
        matches.RemoveAll(m => m.Id == id);
        await SetAsync(MatchesKey, matches);
    }

    // === Mental Logs ===
    public async Task<List<MentalLog>> GetMentalLogsAsync()
    {
        return await GetAsync<List<MentalLog>>(MentalLogsKey) ?? new();
    }

    public async Task SaveMentalLogAsync(MentalLog log)
    {
        var logs = await GetMentalLogsAsync();
        logs.Add(log);
        await SetAsync(MentalLogsKey, logs);
    }

    // === Statistics ===
    public async Task<PlayerStats> GetStatsAsync()
    {
        var sessions = await GetSessionsAsync();
        var breaks = await GetBreaksAsync();
        var drillAttempts = await GetDrillAttemptsAsync();
        var matches = await GetMatchesAsync();

        return new PlayerStats
        {
            TotalSessions = sessions.Count,
            TotalPracticeMinutes = sessions.Sum(s => s.DurationMinutes),
            HighestBreak = breaks.Any() ? breaks.Max(b => b.Score) : 0,
            CenturyCount = breaks.Count(b => b.IsCentury),
            AverageBreak = breaks.Any() ? (int)breaks.Average(b => b.Score) : 0,
            TotalDrillsCompleted = drillAttempts.Count,
            CurrentStreak = CalculateStreak(sessions),
            Last30DaysSessions = sessions.Count(s => s.Date >= DateTime.Now.AddDays(-30)),
            Last30DaysAvgBreak = breaks.Where(b => b.Date >= DateTime.Now.AddDays(-30)).Any()
                ? (int)breaks.Where(b => b.Date >= DateTime.Now.AddDays(-30)).Average(b => b.Score)
                : 0,
            MatchesPlayed = matches.Count,
            MatchesWon = matches.Count(m => m.IsWin),
            WinRate = matches.Any() ? (int)((double)matches.Count(m => m.IsWin) / matches.Count * 100) : 0
        };
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

    // === Storage Helpers ===
    private async Task<T?> GetAsync<T>(string key)
    {
        var json = await _js.InvokeAsync<string?>("localStorage.getItem", key);
        if (string.IsNullOrEmpty(json)) return default;
        return JsonSerializer.Deserialize<T>(json);
    }

    private async Task SetAsync<T>(string key, T value)
    {
        var json = JsonSerializer.Serialize(value);
        await _js.InvokeVoidAsync("localStorage.setItem", key, json);
    }
}

public class PlayerStats
{
    public int TotalSessions { get; set; }
    public int TotalPracticeMinutes { get; set; }
    public int HighestBreak { get; set; }
    public int CenturyCount { get; set; }
    public int AverageBreak { get; set; }
    public int TotalDrillsCompleted { get; set; }
    public int CurrentStreak { get; set; }
    public int Last30DaysSessions { get; set; }
    public int Last30DaysAvgBreak { get; set; }
    public int MatchesPlayed { get; set; }
    public int MatchesWon { get; set; }
    public int WinRate { get; set; }
}
