using SnookerTracker.Models;

namespace SnookerTracker.Services;

public static class TrainingPlanService
{
    public static List<TrainingPlan> GetAllPlans() => new()
    {
        new TrainingPlan
        {
            Id = "foundation-1",
            Name = "Foundation Phase",
            Description = "Build rock-solid fundamentals. Focus on cueing, potting consistency, and basic positional play.",
            WeekNumber = 1,
            Phase = TrainingPhase.Foundation,
            Days = new()
            {
                new DailyPlan { DayName = "Monday", Focus = "Potting Accuracy", TargetMinutes = 90, Drills = new() {
                    new PlannedDrill { DrillId = "line-up", DrillName = "The Line-Up", DurationMinutes = 15, Sets = 3 },
                    new PlannedDrill { DrillId = "blue-to-pink", DrillName = "Blue to Pink", DurationMinutes = 15, Sets = 2 },
                    new PlannedDrill { DrillId = "stun-run-screw", DrillName = "Stun, Run & Screw", DurationMinutes = 20, Sets = 3 },
                    new PlannedDrill { DrillId = "ten-reds-baulk", DrillName = "Ten Reds Baulk", DurationMinutes = 15, Sets = 2 }
                }},
                new DailyPlan { DayName = "Tuesday", Focus = "Cue Ball Control", TargetMinutes = 90, Drills = new() {
                    new PlannedDrill { DrillId = "stun-run-screw", DrillName = "Stun, Run & Screw", DurationMinutes = 20, Sets = 3 },
                    new PlannedDrill { DrillId = "target-zone", DrillName = "Target Zone", DurationMinutes = 20, Sets = 3 },
                    new PlannedDrill { DrillId = "cushion-control", DrillName = "One Cushion Control", DurationMinutes = 20, Sets = 2 },
                    new PlannedDrill { DrillId = "color-clearance", DrillName = "Color Clearance", DurationMinutes = 15, Sets = 3 }
                }},
                new DailyPlan { DayName = "Wednesday", Focus = "Long Potting", TargetMinutes = 90, Drills = new() {
                    new PlannedDrill { DrillId = "long-pot-reds", DrillName = "Long Pots from Baulk", DurationMinutes = 25, Sets = 3 },
                    new PlannedDrill { DrillId = "long-blue", DrillName = "Long Blue", DurationMinutes = 20, Sets = 3 },
                    new PlannedDrill { DrillId = "diagonal-pots", DrillName = "Diagonal Pots", DurationMinutes = 20, Sets = 2 },
                    new PlannedDrill { DrillId = "line-up", DrillName = "The Line-Up", DurationMinutes = 10, Sets = 1 }
                }},
                new DailyPlan { DayName = "Thursday", Focus = "Safety Play", TargetMinutes = 90, Drills = new() {
                    new PlannedDrill { DrillId = "baulk-return", DrillName = "Baulk Return Safety", DurationMinutes = 25, Sets = 3 },
                    new PlannedDrill { DrillId = "snooker-escape", DrillName = "Snooker Escape", DurationMinutes = 25, Sets = 2 },
                    new PlannedDrill { DrillId = "tight-safe", DrillName = "Tight Safety", DurationMinutes = 20, Sets = 2 },
                    new PlannedDrill { DrillId = "target-zone", DrillName = "Target Zone", DurationMinutes = 15, Sets = 2 }
                }},
                new DailyPlan { DayName = "Friday", Focus = "Break Building", TargetMinutes = 120, Drills = new() {
                    new PlannedDrill { DrillId = "t-drill", DrillName = "The T Drill", DurationMinutes = 30, Sets = 3 },
                    new PlannedDrill { DrillId = "three-red-clearance", DrillName = "Three Red Clearance", DurationMinutes = 30, Sets = 5 },
                    new PlannedDrill { DrillId = "color-circle", DrillName = "Color Circle", DurationMinutes = 20, Sets = 3 },
                    new PlannedDrill { DrillId = "red-black-red", DrillName = "Red-Black Sequence", DurationMinutes = 30, Sets = 3 }
                }},
                new DailyPlan { DayName = "Saturday", Focus = "Match Play", TargetMinutes = 150, Drills = new() {
                    new PlannedDrill { DrillId = "full-clearance", DrillName = "Full Clearance Attempt", DurationMinutes = 60, Sets = 4 },
                    new PlannedDrill { DrillId = "frame-start", DrillName = "First Visit Practice", DurationMinutes = 30, Sets = 5 },
                    new PlannedDrill { DrillId = "pressure-pots", DrillName = "Pressure Potting", DurationMinutes = 30, Sets = 3 }
                }},
                new DailyPlan { DayName = "Sunday", Focus = "Rest & Review", TargetMinutes = 30, Drills = new() {
                    new PlannedDrill { DrillId = "line-up", DrillName = "Light session - Line Up only", DurationMinutes = 15, Sets = 2 }
                }}
            }
        },
        new TrainingPlan
        {
            Id = "development-1",
            Name = "Development Phase",
            Description = "Push your scoring ability. Focus on 50+ breaks, advanced positional play, and tactical awareness.",
            WeekNumber = 5,
            Phase = TrainingPhase.Development,
            Days = new()
            {
                new DailyPlan { DayName = "Monday", Focus = "Advanced Position", TargetMinutes = 120, Drills = new() {
                    new PlannedDrill { DrillId = "three-cushion-position", DrillName = "Three-Cushion Position", DurationMinutes = 30, Sets = 3 },
                    new PlannedDrill { DrillId = "pink-black-rotation", DrillName = "Pink-Black Rotation", DurationMinutes = 30, Sets = 3 },
                    new PlannedDrill { DrillId = "deep-screw", DrillName = "Deep Screw Shot", DurationMinutes = 20, Sets = 3 },
                    new PlannedDrill { DrillId = "drag-shot", DrillName = "The Drag Shot", DurationMinutes = 20, Sets = 3 }
                }},
                new DailyPlan { DayName = "Tuesday", Focus = "Scoring Under Pressure", TargetMinutes = 120, Drills = new() {
                    new PlannedDrill { DrillId = "six-red-clearance", DrillName = "Six Red Clearance", DurationMinutes = 40, Sets = 4 },
                    new PlannedDrill { DrillId = "pressure-pots", DrillName = "Pressure Potting", DurationMinutes = 20, Sets = 3 },
                    new PlannedDrill { DrillId = "long-pot-angles", DrillName = "Angled Long Pots", DurationMinutes = 25, Sets = 3 },
                    new PlannedDrill { DrillId = "colors-under-pressure", DrillName = "Colors Under Pressure", DurationMinutes = 20, Sets = 3 }
                }},
                new DailyPlan { DayName = "Wednesday", Focus = "Tactical Mastery", TargetMinutes = 120, Drills = new() {
                    new PlannedDrill { DrillId = "safety-battle", DrillName = "Safety Battle Simulation", DurationMinutes = 40, Sets = 2 },
                    new PlannedDrill { DrillId = "kick-recovery", DrillName = "Kick Recovery", DurationMinutes = 25, Sets = 3 },
                    new PlannedDrill { DrillId = "tough-reds", DrillName = "Tough Red Recovery", DurationMinutes = 30, Sets = 3 },
                    new PlannedDrill { DrillId = "snooker-escape", DrillName = "Snooker Escape", DurationMinutes = 20, Sets = 2 }
                }},
                new DailyPlan { DayName = "Thursday", Focus = "Century Building", TargetMinutes = 150, Drills = new() {
                    new PlannedDrill { DrillId = "ten-red-clearance", DrillName = "Ten Red Clearance", DurationMinutes = 45, Sets = 4 },
                    new PlannedDrill { DrillId = "split-shot", DrillName = "Split Shot Development", DurationMinutes = 30, Sets = 4 },
                    new PlannedDrill { DrillId = "red-black-red", DrillName = "Red-Black Sequence", DurationMinutes = 30, Sets = 3 },
                    new PlannedDrill { DrillId = "last-four", DrillName = "Last Four Colors", DurationMinutes = 20, Sets = 4 }
                }},
                new DailyPlan { DayName = "Friday", Focus = "Match Simulation", TargetMinutes = 180, Drills = new() {
                    new PlannedDrill { DrillId = "endurance-drill", DrillName = "Endurance Scoring", DurationMinutes = 60, Sets = 1 },
                    new PlannedDrill { DrillId = "century-under-pressure", DrillName = "Century Under Pressure", DurationMinutes = 60, Sets = 3 },
                    new PlannedDrill { DrillId = "frame-start", DrillName = "First Visit Practice", DurationMinutes = 30, Sets = 4 }
                }},
                new DailyPlan { DayName = "Saturday", Focus = "Competition Day", TargetMinutes = 180, Drills = new() {
                    new PlannedDrill { DrillId = "full-clearance", DrillName = "Play matches or full clearances", DurationMinutes = 120, Sets = 6 },
                    new PlannedDrill { DrillId = "long-pot-both-corners", DrillName = "Alternate Corner Long Pots", DurationMinutes = 30, Sets = 3 }
                }},
                new DailyPlan { DayName = "Sunday", Focus = "Active Recovery", TargetMinutes = 45, Drills = new() {
                    new PlannedDrill { DrillId = "line-up", DrillName = "Easy potting - stay loose", DurationMinutes = 15, Sets = 2 },
                    new PlannedDrill { DrillId = "color-clearance", DrillName = "Color Clearance", DurationMinutes = 15, Sets = 3 }
                }}
            }
        }
    };
}
