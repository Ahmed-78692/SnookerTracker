using SnookerTracker.Models;
using SnookerTracker.Components;

namespace SnookerTracker.Services;

public static class DrillLibrary
{
    public static List<Drill> GetAllDrills() => new()
    {
        // === POTTING DRILLS ===
        new Drill
        {
            Id = "line-up",
            Name = "The Line-Up",
            Description = "15 reds in a line from black spot to top cushion. The foundation drill.",
            Category = DrillCategory.Potting,
            Difficulty = DrillDifficulty.Beginner,
            Instructions = "Place 15 reds in a straight line from the black spot to the top cushion. Pot each into a top corner pocket with cue ball in hand for each shot. Focus on a smooth, consistent delivery. Score 1 per pot.",
            TargetScore = 12,
            MaxScore = 15,
            TableSetup = new DrillTableSetup
            {
                Balls = GenerateLineUpBalls(),
                Arrows = new() { new ArrowPath { X1 = 340, Y1 = 50, X2 = 375, Y2 = 25, Color = "#4ecca3" } },
                Zones = new()
            }
        },
        new Drill
        {
            Id = "blue-to-pink",
            Name = "Blue to Pink Spot",
            Description = "Pot blues off the spot repeatedly. Builds rhythm and confidence.",
            Category = DrillCategory.Potting,
            Difficulty = DrillDifficulty.Beginner,
            Instructions = "Place the blue on its spot. Pot into any pocket. Replace and repeat 10 times. Cue ball position for next shot is key. Count consecutive pots.",
            TargetScore = 8,
            MaxScore = 10,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 200, Y = 100, Color = "#2980b9" },
                    new BallPosition { X = 150, Y = 100, Color = "#ffffff", Radius = 4 }
                },
                Arrows = new() { new ArrowPath { X1 = 150, Y1 = 100, X2 = 195, Y2 = 100, Color = "#4ecca3" } },
                Zones = new()
            }
        },
        new Drill
        {
            Id = "ten-reds-baulk",
            Name = "Ten Reds Baulk Line",
            Description = "10 reds across baulk line. Pot each into nominated corner pocket.",
            Category = DrillCategory.Potting,
            Difficulty = DrillDifficulty.Intermediate,
            Instructions = "Place 10 reds evenly across the baulk line. Cue ball in hand each shot. Nominate a corner pocket before each shot. Develops accuracy from varied angles.",
            TargetScore = 7,
            MaxScore = 10,
            TableSetup = new DrillTableSetup
            {
                Balls = GenerateBaulkLineRedsBalls(),
                Arrows = new(),
                Zones = new()
            }
        },
        new Drill
        {
            Id = "diagonal-pots",
            Name = "Diagonal Pots",
            Description = "Pot balls diagonally across the table — essential angle training.",
            Category = DrillCategory.Potting,
            Difficulty = DrillDifficulty.Intermediate,
            Instructions = "Place 5 reds at various positions requiring diagonal pots into opposite corner pockets. Cue ball in hand. Develops judgement of angles that appear in real frames.",
            TargetScore = 3,
            MaxScore = 5,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 150, Y = 60, Color = "#e74c3c" },
                    new BallPosition { X = 250, Y = 140, Color = "#e74c3c" },
                    new BallPosition { X = 180, Y = 130, Color = "#e74c3c" },
                    new BallPosition { X = 300, Y = 70, Color = "#e74c3c" },
                    new BallPosition { X = 120, Y = 150, Color = "#e74c3c" }
                },
                Arrows = new() {
                    new ArrowPath { X1 = 150, Y1 = 60, X2 = 380, Y2 = 180, Color = "#4ecca3", Dashed = true },
                    new ArrowPath { X1 = 250, Y1 = 140, X2 = 20, Y2 = 20, Color = "#4ecca3", Dashed = true }
                },
                Zones = new()
            }
        },
        new Drill
        {
            Id = "pressure-pots",
            Name = "Pressure Potting (Pro)",
            Description = "Replicate match pressure: 5 pots in a row or restart from zero.",
            Category = DrillCategory.Potting,
            Difficulty = DrillDifficulty.Pro,
            Instructions = "Place 5 reds in medium-difficulty positions. You MUST pot all 5 in sequence. If you miss ANY ball, restart the count from 0. Record how many complete sets of 5 you achieve in 15 minutes. This simulates match pressure — pros need 100% when it counts.",
            TargetScore = 5,
            MaxScore = 10,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 150, Y = 70, Color = "#e74c3c" },
                    new BallPosition { X = 220, Y = 50, Color = "#e74c3c" },
                    new BallPosition { X = 280, Y = 130, Color = "#e74c3c" },
                    new BallPosition { X = 170, Y = 150, Color = "#e74c3c" },
                    new BallPosition { X = 320, Y = 80, Color = "#e74c3c" },
                    new BallPosition { X = 100, Y = 100, Color = "#ffffff", Radius = 4 }
                },
                Arrows = new(),
                Zones = new()
            }
        },

        // === LONG POTTING DRILLS ===
        new Drill
        {
            Id = "long-pot-reds",
            Name = "Long Pots from Baulk",
            Description = "Full-table long pots. The shot that wins frames at the top level.",
            Category = DrillCategory.LongPotting,
            Difficulty = DrillDifficulty.Intermediate,
            Instructions = "Place 10 reds in the top half of the table. Cue ball stays in baulk area (reset each time). Pot into top corner pockets. Pros hit 60-70% of these. Track your percentage.",
            TargetScore = 5,
            MaxScore = 10,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 280, Y = 60, Color = "#e74c3c" },
                    new BallPosition { X = 310, Y = 80, Color = "#e74c3c" },
                    new BallPosition { X = 330, Y = 50, Color = "#e74c3c" },
                    new BallPosition { X = 290, Y = 130, Color = "#e74c3c" },
                    new BallPosition { X = 350, Y = 140, Color = "#e74c3c" },
                    new BallPosition { X = 80, Y = 100, Color = "#ffffff", Radius = 4 }
                },
                Arrows = new() { new ArrowPath { X1 = 80, Y1 = 100, X2 = 280, Y2 = 60, Color = "#ffcc00", Dashed = true } },
                Zones = new()
            }
        },
        new Drill
        {
            Id = "long-blue",
            Name = "Long Blue Drill",
            Description = "Blue on spot, cue ball on baulk line. Repeat 10 times.",
            Category = DrillCategory.LongPotting,
            Difficulty = DrillDifficulty.Advanced,
            Instructions = "Blue on its spot. Cue ball center of baulk line. Pot blue into either middle pocket. 10 attempts. Judd Trump practices this daily — it's the bread-and-butter long pot in professional snooker.",
            TargetScore = 4,
            MaxScore = 10,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 200, Y = 100, Color = "#2980b9" },
                    new BallPosition { X = 80, Y = 100, Color = "#ffffff", Radius = 4 }
                },
                Arrows = new() { new ArrowPath { X1 = 80, Y1 = 100, X2 = 195, Y2 = 100, Color = "#4ecca3" } },
                Zones = new()
            }
        },
        new Drill
        {
            Id = "long-pot-angles",
            Name = "Angled Long Pots",
            Description = "Long pots with 30-45 degree angles. Match-winning shots.",
            Category = DrillCategory.LongPotting,
            Difficulty = DrillDifficulty.Pro,
            Instructions = "Object ball 3/4 down the table, slightly off-line from pocket. Cue ball in baulk at an angle. These are the pots that separate club players from professionals. 10 attempts at varying angles.",
            TargetScore = 3,
            MaxScore = 10,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 300, Y = 70, Color = "#e74c3c" },
                    new BallPosition { X = 80, Y = 130, Color = "#ffffff", Radius = 4 }
                },
                Arrows = new() {
                    new ArrowPath { X1 = 80, Y1 = 130, X2 = 295, Y2 = 73, Color = "#ffcc00", Dashed = true },
                    new ArrowPath { X1 = 300, Y1 = 70, X2 = 380, Y2 = 20, Color = "#4ecca3" }
                },
                Zones = new()
            }
        },
        new Drill
        {
            Id = "long-pot-both-corners",
            Name = "Alternate Corner Long Pots",
            Description = "Alternate between top-left and top-right long pots. Builds versatility.",
            Category = DrillCategory.LongPotting,
            Difficulty = DrillDifficulty.Pro,
            Instructions = "Place reds in the top third. Alternate potting into top-left then top-right corner. Cue ball resets to baulk each time. Forces you to adjust aim across both sides. 10 shots total.",
            TargetScore = 4,
            MaxScore = 10,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 300, Y = 80, Color = "#e74c3c" },
                    new BallPosition { X = 320, Y = 120, Color = "#e74c3c" },
                    new BallPosition { X = 80, Y = 100, Color = "#ffffff", Radius = 4 }
                },
                Arrows = new() {
                    new ArrowPath { X1 = 300, Y1 = 80, X2 = 380, Y2 = 20, Color = "#4ecca3", Dashed = true },
                    new ArrowPath { X1 = 320, Y1 = 120, X2 = 380, Y2 = 180, Color = "#e94560", Dashed = true }
                },
                Zones = new()
            }
        },

        // === POSITIONAL PLAY DRILLS ===
        new Drill
        {
            Id = "t-drill",
            Name = "The T Drill",
            Description = "Red-black-red-black. The single most important drill for break building.",
            Category = DrillCategory.Positional,
            Difficulty = DrillDifficulty.Intermediate,
            Instructions = "Place a red near each pocket (6 reds). Pot red then black alternately. Black always re-spotted. Focus on getting perfect position on the black after each red. This is THE drill that Stephen Hendry credits for his 775 centuries.",
            TargetScore = 40,
            MaxScore = 72,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 30, Y = 30, Color = "#e74c3c" },
                    new BallPosition { X = 30, Y = 170, Color = "#e74c3c" },
                    new BallPosition { X = 200, Y = 30, Color = "#e74c3c" },
                    new BallPosition { X = 200, Y = 170, Color = "#e74c3c" },
                    new BallPosition { X = 370, Y = 30, Color = "#e74c3c" },
                    new BallPosition { X = 370, Y = 170, Color = "#e74c3c" },
                    new BallPosition { X = 340, Y = 100, Color = "#1a1a1a", Radius = 5 }
                },
                Arrows = new() {
                    new ArrowPath { X1 = 370, Y1 = 30, X2 = 380, Y2 = 20, Color = "#4ecca3" },
                    new ArrowPath { X1 = 345, Y1 = 100, X2 = 365, Y2 = 30, Color = "#ffcc00", Dashed = true }
                },
                Zones = new() { new TargetZone { X = 310, Y = 80, Width = 60, Height = 40, Color = "#4ecca3" } }
            }
        },
        new Drill
        {
            Id = "color-circle",
            Name = "Color Circle",
            Description = "Clear all 6 colors in order from their spots. Tests full-table position.",
            Category = DrillCategory.Positional,
            Difficulty = DrillDifficulty.Advanced,
            Instructions = "All colors on spots. Cue ball in hand for first shot. Clear yellow→green→brown→blue→pink→black in order. Getting from brown to blue (cross-table) is the key challenge. 5 attempts, score total points.",
            TargetScore = 25,
            MaxScore = 35,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 80, Y = 128, Color = "#FFD700" },
                    new BallPosition { X = 80, Y = 72, Color = "#2ecc40" },
                    new BallPosition { X = 80, Y = 100, Color = "#8B4513" },
                    new BallPosition { X = 200, Y = 100, Color = "#2980b9" },
                    new BallPosition { X = 290, Y = 100, Color = "#e84393" },
                    new BallPosition { X = 340, Y = 100, Color = "#1a1a1a" }
                },
                Arrows = new() {
                    new ArrowPath { X1 = 85, Y1 = 128, X2 = 85, Y2 = 105, Color = "#ffcc00", Dashed = true },
                    new ArrowPath { X1 = 85, Y1 = 100, X2 = 190, Y2 = 100, Color = "#ffcc00", Dashed = true }
                },
                Zones = new()
            }
        },
        new Drill
        {
            Id = "red-black-red",
            Name = "Red-Black Sequence",
            Description = "10 reds alternating with black. The century-building pattern.",
            Category = DrillCategory.Positional,
            Difficulty = DrillDifficulty.Advanced,
            Instructions = "Place 10 reds around the pink/black area in realistic positions. Pot red-black-red-black. Black always re-spotted. The goal: maintain position within the scoring zone. Count total points before missing.",
            TargetScore = 50,
            MaxScore = 80,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 290, Y = 70, Color = "#e74c3c" },
                    new BallPosition { X = 310, Y = 90, Color = "#e74c3c" },
                    new BallPosition { X = 280, Y = 110, Color = "#e74c3c" },
                    new BallPosition { X = 320, Y = 130, Color = "#e74c3c" },
                    new BallPosition { X = 300, Y = 60, Color = "#e74c3c" },
                    new BallPosition { X = 340, Y = 100, Color = "#1a1a1a", Radius = 5 },
                    new BallPosition { X = 260, Y = 100, Color = "#ffffff", Radius = 4 }
                },
                Arrows = new() {
                    new ArrowPath { X1 = 260, Y1 = 100, X2 = 285, Y2 = 110, Color = "#4ecca3" },
                    new ArrowPath { X1 = 290, Y1 = 115, X2 = 330, Y2 = 100, Color = "#ffcc00", Dashed = true }
                },
                Zones = new() { new TargetZone { X = 260, Y = 70, Width = 80, Height = 60, Color = "#4ecca3" } }
            }
        },
        new Drill
        {
            Id = "three-cushion-position",
            Name = "Three-Cushion Position",
            Description = "Pot the ball and use 3 cushions to reach perfect position. Pro-level control.",
            Category = DrillCategory.Positional,
            Difficulty = DrillDifficulty.Pro,
            Instructions = "Object ball near a pocket. Pot it and make the cue ball travel off 3 cushions to land in a marked zone. This is what separates world-class players — they can get position from anywhere. 10 attempts.",
            TargetScore = 3,
            MaxScore = 10,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 350, Y = 50, Color = "#e74c3c" },
                    new BallPosition { X = 320, Y = 70, Color = "#ffffff", Radius = 4 }
                },
                Arrows = new() {
                    new ArrowPath { X1 = 320, Y1 = 70, X2 = 350, Y2 = 50, Color = "#4ecca3" },
                    new ArrowPath { X1 = 355, Y1 = 55, X2 = 370, Y2 = 100, Color = "#ffcc00", Dashed = true },
                    new ArrowPath { X1 = 370, Y1 = 100, X2 = 300, Y2 = 175, Color = "#ffcc00", Dashed = true },
                    new ArrowPath { X1 = 300, Y1 = 175, X2 = 200, Y2 = 100, Color = "#ffcc00", Dashed = true }
                },
                Zones = new() { new TargetZone { X = 180, Y = 80, Width = 40, Height = 40, Color = "#4ecca3" } }
            }
        },
        new Drill
        {
            Id = "pink-black-rotation",
            Name = "Pink-Black Rotation",
            Description = "Alternate between pink and black as the color. Develops versatility.",
            Category = DrillCategory.Positional,
            Difficulty = DrillDifficulty.Pro,
            Instructions = "6 reds around the pink/black zone. Pot red-pink-red-black-red-pink alternating colors. Both re-spotted each time. Forces you to play position for TWO different spots. O'Sullivan-level scoring requires this flexibility.",
            TargetScore = 45,
            MaxScore = 72,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 280, Y = 80, Color = "#e74c3c" },
                    new BallPosition { X = 310, Y = 60, Color = "#e74c3c" },
                    new BallPosition { X = 300, Y = 120, Color = "#e74c3c" },
                    new BallPosition { X = 330, Y = 140, Color = "#e74c3c" },
                    new BallPosition { X = 290, Y = 100, Color = "#e84393", Radius = 5 },
                    new BallPosition { X = 340, Y = 100, Color = "#1a1a1a", Radius = 5 }
                },
                Arrows = new(),
                Zones = new() {
                    new TargetZone { X = 270, Y = 80, Width = 40, Height = 40, Color = "#e84393" },
                    new TargetZone { X = 310, Y = 80, Width = 40, Height = 40, Color = "#333333" }
                }
            }
        },

        // === CUE BALL CONTROL ===
        new Drill
        {
            Id = "stun-run-screw",
            Name = "Stun, Run & Screw",
            Description = "Master all 3 cue ball reactions from the same shot position.",
            Category = DrillCategory.CueBall,
            Difficulty = DrillDifficulty.Beginner,
            Instructions = "Object ball 2 feet from pocket, straight pot. Pot 3 ways: (1) Stun - cue ball stops dead, (2) Run-through - follows the object ball, (3) Deep screw - comes back to you. 10 sets of 3 = 30 max.",
            TargetScore = 20,
            MaxScore = 30,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 300, Y = 100, Color = "#e74c3c" },
                    new BallPosition { X = 230, Y = 100, Color = "#ffffff", Radius = 4 }
                },
                Arrows = new() {
                    new ArrowPath { X1 = 230, Y1 = 100, X2 = 295, Y2 = 100, Color = "#4ecca3" },
                    new ArrowPath { X1 = 230, Y1 = 95, X2 = 230, Y2 = 70, Color = "#ffcc00", Dashed = true },
                    new ArrowPath { X1 = 230, Y1 = 105, X2 = 180, Y2 = 105, Color = "#e94560", Dashed = true }
                },
                Zones = new()
            }
        },
        new Drill
        {
            Id = "target-zone",
            Name = "Target Zone",
            Description = "Pot and land cue ball in a specific area. Precision position play.",
            Category = DrillCategory.CueBall,
            Difficulty = DrillDifficulty.Intermediate,
            Instructions = "Place a target marker on the table. Pot the object ball AND land cue ball within a ball's width of the target. Varies angle each time. 10 attempts.",
            TargetScore = 5,
            MaxScore = 10,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 280, Y = 70, Color = "#e74c3c" },
                    new BallPosition { X = 240, Y = 90, Color = "#ffffff", Radius = 4 }
                },
                Arrows = new() {
                    new ArrowPath { X1 = 240, Y1 = 90, X2 = 275, Y2 = 73, Color = "#4ecca3" },
                    new ArrowPath { X1 = 285, Y1 = 75, X2 = 320, Y2 = 110, Color = "#ffcc00", Dashed = true }
                },
                Zones = new() { new TargetZone { X = 305, Y = 95, Width = 30, Height = 30, Color = "#4ecca3" } }
            }
        },
        new Drill
        {
            Id = "cushion-control",
            Name = "One Cushion Control",
            Description = "Pot, then bring cue ball off one cushion to exact position.",
            Category = DrillCategory.CueBall,
            Difficulty = DrillDifficulty.Advanced,
            Instructions = "Object ball mid-table. Pot it. Cue ball must hit one cushion then stop in a marked target zone. Develops angle judgement off cushions — essential for maintaining position in breaks.",
            TargetScore = 4,
            MaxScore = 10,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 250, Y = 80, Color = "#e74c3c" },
                    new BallPosition { X = 200, Y = 100, Color = "#ffffff", Radius = 4 }
                },
                Arrows = new() {
                    new ArrowPath { X1 = 200, Y1 = 100, X2 = 245, Y2 = 83, Color = "#4ecca3" },
                    new ArrowPath { X1 = 210, Y1 = 95, X2 = 210, Y2 = 25, Color = "#ffcc00", Dashed = true },
                    new ArrowPath { X1 = 210, Y1 = 25, X2 = 280, Y2 = 100, Color = "#ffcc00", Dashed = true }
                },
                Zones = new() { new TargetZone { X = 265, Y = 85, Width = 30, Height = 30, Color = "#4ecca3" } }
            }
        },
        new Drill
        {
            Id = "deep-screw",
            Name = "Deep Screw Shot",
            Description = "Full-length screw back. The power shot that pros use to dominate.",
            Category = DrillCategory.CueBall,
            Difficulty = DrillDifficulty.Pro,
            Instructions = "Object ball near top pocket, straight line to pocket. Screw the cue ball back at least half the table length. Requires perfect cueing — low tip contact, follow-through, and no side. This separates amateurs from champions. 10 attempts, score 1 per successful deep screw.",
            TargetScore = 5,
            MaxScore = 10,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 340, Y = 60, Color = "#e74c3c" },
                    new BallPosition { X = 340, Y = 90, Color = "#ffffff", Radius = 4 }
                },
                Arrows = new() {
                    new ArrowPath { X1 = 340, Y1 = 90, X2 = 340, Y2 = 65, Color = "#4ecca3" },
                    new ArrowPath { X1 = 340, Y1 = 95, X2 = 200, Y2 = 100, Color = "#e94560", Dashed = true }
                },
                Zones = new() { new TargetZone { X = 130, Y = 80, Width = 60, Height = 40, Color = "#e94560" } }
            }
        },
        new Drill
        {
            Id = "drag-shot",
            Name = "The Drag Shot",
            Description = "Controlled follow with check-side. Used constantly by Selby.",
            Category = DrillCategory.CueBall,
            Difficulty = DrillDifficulty.Advanced,
            Instructions = "Pot a red into a top pocket at an angle. Use a drag (slow roll with slight follow) to drift the cue ball gently into position for the black. The cue ball should travel slowly and stop predictably. 10 attempts.",
            TargetScore = 4,
            MaxScore = 10,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 320, Y = 60, Color = "#e74c3c" },
                    new BallPosition { X = 290, Y = 80, Color = "#ffffff", Radius = 4 }
                },
                Arrows = new() {
                    new ArrowPath { X1 = 290, Y1 = 80, X2 = 315, Y2 = 63, Color = "#4ecca3" },
                    new ArrowPath { X1 = 295, Y1 = 85, X2 = 310, Y2 = 100, Color = "#ffcc00", Dashed = true }
                },
                Zones = new() { new TargetZone { X = 300, Y = 90, Width = 25, Height = 25, Color = "#4ecca3" } }
            }
        },

        // === SAFETY DRILLS ===
        new Drill
        {
            Id = "baulk-return",
            Name = "Baulk Return Safety",
            Description = "The fundamental safety — return cue ball to baulk from anywhere.",
            Category = DrillCategory.Safety,
            Difficulty = DrillDifficulty.Intermediate,
            Instructions = "Red touching or near the top cushion. Play it safe: (1) leave the red on the cushion, (2) bring cue ball back behind the baulk line. Both conditions = 1 point. 10 attempts. Mark Selby is the master of this.",
            TargetScore = 6,
            MaxScore = 10,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 320, Y = 30, Color = "#e74c3c" },
                    new BallPosition { X = 250, Y = 80, Color = "#ffffff", Radius = 4 }
                },
                Arrows = new() {
                    new ArrowPath { X1 = 250, Y1 = 80, X2 = 315, Y2 = 33, Color = "#4ecca3" },
                    new ArrowPath { X1 = 255, Y1 = 85, X2 = 80, Y2 = 130, Color = "#ffcc00", Dashed = true }
                },
                Zones = new() { new TargetZone { X = 30, Y = 60, Width = 65, Height = 80, Color = "#4ecca3" } }
            }
        },
        new Drill
        {
            Id = "snooker-escape",
            Name = "Snooker Escape",
            Description = "Escape from snookers using cushions. Vital for international play.",
            Category = DrillCategory.Safety,
            Difficulty = DrillDifficulty.Advanced,
            Instructions = "Set up snookers using colors as blockers. Must hit target ball using 1+ cushions. 10 different positions. At the professional level, you face 3-5 snookers per frame. Escaping cleanly is non-negotiable.",
            TargetScore = 5,
            MaxScore = 10,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 300, Y = 100, Color = "#e74c3c" },
                    new BallPosition { X = 200, Y = 100, Color = "#2980b9", Radius = 5 },
                    new BallPosition { X = 120, Y = 100, Color = "#ffffff", Radius = 4 }
                },
                Arrows = new() {
                    new ArrowPath { X1 = 120, Y1 = 100, X2 = 120, Y2 = 25, Color = "#ffcc00", Dashed = true },
                    new ArrowPath { X1 = 120, Y1 = 25, X2 = 300, Y2 = 25, Color = "#ffcc00", Dashed = true },
                    new ArrowPath { X1 = 300, Y1 = 25, X2 = 300, Y2 = 95, Color = "#ffcc00", Dashed = true }
                },
                Zones = new()
            }
        },
        new Drill
        {
            Id = "tight-safe",
            Name = "Tight Safety Exchange",
            Description = "Play red tight to cushion AND get cue ball safe. The Selby special.",
            Category = DrillCategory.Safety,
            Difficulty = DrillDifficulty.Pro,
            Instructions = "Red mid-table. Play it tight to top cushion (within 6 inches) AND cue ball must end in baulk. Both conditions = 1 point. This is match-winning safety at the highest level. 10 attempts.",
            TargetScore = 4,
            MaxScore = 10,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 220, Y = 90, Color = "#e74c3c" },
                    new BallPosition { X = 150, Y = 120, Color = "#ffffff", Radius = 4 }
                },
                Arrows = new() {
                    new ArrowPath { X1 = 150, Y1 = 120, X2 = 215, Y2 = 93, Color = "#4ecca3" },
                    new ArrowPath { X1 = 225, Y1 = 87, X2 = 300, Y2 = 25, Color = "#e74c3c", Dashed = true },
                    new ArrowPath { X1 = 145, Y1 = 115, X2 = 70, Y2 = 90, Color = "#ffcc00", Dashed = true }
                },
                Zones = new() {
                    new TargetZone { X = 270, Y = 20, Width = 60, Height = 15, Color = "#e74c3c" },
                    new TargetZone { X = 30, Y = 60, Width = 65, Height = 80, Color = "#4ecca3" }
                }
            }
        },
        new Drill
        {
            Id = "safety-battle",
            Name = "Safety Battle Simulation",
            Description = "Play 20 safeties in a row. Build patience and consistency.",
            Category = DrillCategory.Safety,
            Difficulty = DrillDifficulty.Pro,
            Instructions = "Red on the top cushion. Alternate playing safeties: cue ball must end behind baulk line each time, red must stay within 12 inches of the top cushion. Simulate a professional safety exchange. 20 shots. Score 1 per shot where BOTH conditions are met.",
            TargetScore = 12,
            MaxScore = 20,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 320, Y = 28, Color = "#e74c3c" },
                    new BallPosition { X = 80, Y = 110, Color = "#ffffff", Radius = 4 }
                },
                Arrows = new() {
                    new ArrowPath { X1 = 80, Y1 = 110, X2 = 315, Y2 = 30, Color = "#4ecca3", Dashed = true },
                    new ArrowPath { X1 = 85, Y1 = 105, X2 = 70, Y2 = 90, Color = "#ffcc00", Dashed = true }
                },
                Zones = new() {
                    new TargetZone { X = 280, Y = 20, Width = 80, Height = 20, Color = "#e74c3c" },
                    new TargetZone { X = 30, Y = 60, Width = 65, Height = 80, Color = "#4ecca3" }
                }
            }
        },

        // === BREAK BUILDING DRILLS ===
        new Drill
        {
            Id = "three-red-clearance",
            Name = "Three Red Clearance",
            Description = "3 reds + colors. Build consistency before attempting big breaks.",
            Category = DrillCategory.BreakBuilding,
            Difficulty = DrillDifficulty.Intermediate,
            Instructions = "Place 3 reds in realistic positions near pink/black area. Clear all reds with black, then clear colors in order. Max = 51. Focus on SMOOTH positional play, not power. Repeat until you can do this 3 times in a row.",
            TargetScore = 30,
            MaxScore = 51,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 290, Y = 80, Color = "#e74c3c" },
                    new BallPosition { X = 310, Y = 110, Color = "#e74c3c" },
                    new BallPosition { X = 280, Y = 120, Color = "#e74c3c" },
                    new BallPosition { X = 340, Y = 100, Color = "#1a1a1a", Radius = 5 },
                    new BallPosition { X = 270, Y = 100, Color = "#ffffff", Radius = 4 }
                },
                Arrows = new(),
                Zones = new() { new TargetZone { X = 260, Y = 70, Width = 90, Height = 70, Color = "#4ecca3" } }
            }
        },
        new Drill
        {
            Id = "six-red-clearance",
            Name = "Six Red Clearance",
            Description = "6 reds + colors. The step between practice and match centuries.",
            Category = DrillCategory.BreakBuilding,
            Difficulty = DrillDifficulty.Advanced,
            Instructions = "Place 6 reds in game-like positions around pink/black area. Clear all with highest color possible. Then colors in order. Max = 75. When you can score 50+ consistently here, you're ready for match centuries.",
            TargetScore = 40,
            MaxScore = 75,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 280, Y = 70, Color = "#e74c3c" },
                    new BallPosition { X = 310, Y = 60, Color = "#e74c3c" },
                    new BallPosition { X = 290, Y = 110, Color = "#e74c3c" },
                    new BallPosition { X = 320, Y = 90, Color = "#e74c3c" },
                    new BallPosition { X = 300, Y = 130, Color = "#e74c3c" },
                    new BallPosition { X = 330, Y = 120, Color = "#e74c3c" },
                    new BallPosition { X = 340, Y = 100, Color = "#1a1a1a", Radius = 5 },
                    new BallPosition { X = 290, Y = 100, Color = "#e84393", Radius = 5 }
                },
                Arrows = new(),
                Zones = new()
            }
        },
        new Drill
        {
            Id = "ten-red-clearance",
            Name = "Ten Red Clearance",
            Description = "10 reds + colors. Near-match conditions for century building.",
            Category = DrillCategory.BreakBuilding,
            Difficulty = DrillDifficulty.Pro,
            Instructions = "10 reds in a loose cluster near pink spot (no tight packs). Full clearance attempt. Max = 107. This is your century training ground. When you score 80+ regularly, you'll make centuries in matches.",
            TargetScore = 70,
            MaxScore = 107,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 270, Y = 70, Color = "#e74c3c" },
                    new BallPosition { X = 290, Y = 60, Color = "#e74c3c" },
                    new BallPosition { X = 310, Y = 75, Color = "#e74c3c" },
                    new BallPosition { X = 280, Y = 90, Color = "#e74c3c" },
                    new BallPosition { X = 300, Y = 100, Color = "#e74c3c" },
                    new BallPosition { X = 320, Y = 110, Color = "#e74c3c" },
                    new BallPosition { X = 280, Y = 120, Color = "#e74c3c" },
                    new BallPosition { X = 300, Y = 130, Color = "#e74c3c" },
                    new BallPosition { X = 260, Y = 105, Color = "#e74c3c" },
                    new BallPosition { X = 330, Y = 90, Color = "#e74c3c" },
                    new BallPosition { X = 340, Y = 100, Color = "#1a1a1a", Radius = 5 },
                    new BallPosition { X = 290, Y = 100, Color = "#e84393", Radius = 5 }
                },
                Arrows = new(),
                Zones = new()
            }
        },
        new Drill
        {
            Id = "full-clearance",
            Name = "Full Table Clearance (147 Attempt)",
            Description = "15 reds all with black + colors. The ultimate test.",
            Category = DrillCategory.BreakBuilding,
            Difficulty = DrillDifficulty.Pro,
            Instructions = "Standard triangle break. Attempt maximum clearance (147). Record highest break. This should be attempted once per practice session. Don't chase it — let it come naturally. Focus on process over outcome.",
            TargetScore = 80,
            MaxScore = 147,
            TableSetup = new DrillTableSetup
            {
                Balls = GenerateTriangleBalls(),
                Arrows = new(),
                Zones = new()
            }
        },
        new Drill
        {
            Id = "century-under-pressure",
            Name = "Century Under Pressure",
            Description = "Must score 100+ or restart from zero. Simulates match conditions.",
            Category = DrillCategory.BreakBuilding,
            Difficulty = DrillDifficulty.Pro,
            Instructions = "Full set of 15 reds. You MUST score 100+ in one visit. If you fail, reset and try again. Time yourself. At tournaments, you get ONE chance. Record: (1) attempts before success, (2) time taken. Goal: century within first 2 attempts.",
            TargetScore = 100,
            MaxScore = 147,
            TableSetup = new DrillTableSetup
            {
                Balls = GenerateTriangleBalls(),
                Arrows = new(),
                Zones = new()
            }
        },

        // === CLEARANCE DRILLS ===
        new Drill
        {
            Id = "color-clearance",
            Name = "Color Clearance",
            Description = "All 6 colors from spots. The end-of-frame scenario.",
            Category = DrillCategory.Clearance,
            Difficulty = DrillDifficulty.Intermediate,
            Instructions = "All colors on spots. Cue ball in hand for first shot. Clear yellow→green→brown→blue→pink→black. Score = total points in order before missing. Max = 27. You'll face this 3-4 times per match.",
            TargetScore = 20,
            MaxScore = 27,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 80, Y = 128, Color = "#FFD700" },
                    new BallPosition { X = 80, Y = 72, Color = "#2ecc40" },
                    new BallPosition { X = 80, Y = 100, Color = "#8B4513" },
                    new BallPosition { X = 200, Y = 100, Color = "#2980b9" },
                    new BallPosition { X = 290, Y = 100, Color = "#e84393" },
                    new BallPosition { X = 340, Y = 100, Color = "#1a1a1a" }
                },
                Arrows = new() { new ArrowPath { X1 = 60, Y1 = 128, X2 = 20, Y2 = 180, Color = "#FFD700", Dashed = true } },
                Zones = new()
            }
        },
        new Drill
        {
            Id = "last-four",
            Name = "Last Four Colors",
            Description = "Brown, blue, pink, black. Common frame-winning clearance.",
            Category = DrillCategory.Clearance,
            Difficulty = DrillDifficulty.Advanced,
            Instructions = "Brown, blue, pink, black on spots. Cue ball in hand. Clear in order. This simulates a common match scenario: you're behind and need to clear from brown. Max = 22. Repeat until 100% success rate.",
            TargetScore = 22,
            MaxScore = 22,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 80, Y = 100, Color = "#8B4513" },
                    new BallPosition { X = 200, Y = 100, Color = "#2980b9" },
                    new BallPosition { X = 290, Y = 100, Color = "#e84393" },
                    new BallPosition { X = 340, Y = 100, Color = "#1a1a1a" },
                    new BallPosition { X = 120, Y = 100, Color = "#ffffff", Radius = 4 }
                },
                Arrows = new() {
                    new ArrowPath { X1 = 120, Y1 = 100, X2 = 200, Y2 = 183, Color = "#ffcc00", Dashed = true }
                },
                Zones = new()
            }
        },
        new Drill
        {
            Id = "colors-under-pressure",
            Name = "Colors Under Pressure (Frame on the Line)",
            Description = "You're 20 points behind with only colors left. Clear to win.",
            Category = DrillCategory.Clearance,
            Difficulty = DrillDifficulty.Pro,
            Instructions = "All colors on spots. You 'need' all of them to win the frame. One miss = you lose the frame. Clear all 6 in order, 5 consecutive times without failure. This builds the ice-cold nerve needed at the highest level. Score = consecutive successful clearances.",
            TargetScore = 3,
            MaxScore = 5,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 80, Y = 128, Color = "#FFD700" },
                    new BallPosition { X = 80, Y = 72, Color = "#2ecc40" },
                    new BallPosition { X = 80, Y = 100, Color = "#8B4513" },
                    new BallPosition { X = 200, Y = 100, Color = "#2980b9" },
                    new BallPosition { X = 290, Y = 100, Color = "#e84393" },
                    new BallPosition { X = 340, Y = 100, Color = "#1a1a1a" },
                    new BallPosition { X = 60, Y = 140, Color = "#ffffff", Radius = 4 }
                },
                Arrows = new(),
                Zones = new()
            }
        },

        // === MATCH SIMULATION DRILLS ===
        new Drill
        {
            Id = "frame-start",
            Name = "First Visit After Break-Off",
            Description = "Practice the critical first scoring visit of a frame.",
            Category = DrillCategory.BreakBuilding,
            Difficulty = DrillDifficulty.Advanced,
            Instructions = "Set up a typical position after a break-off: reds in pack, one or two loose reds. Practice your first visit — pot a red, get on a color, then build from there. Score = total points in first visit. At top level, first visits of 40-60 are common.",
            TargetScore = 40,
            MaxScore = 80,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 280, Y = 80, Color = "#e74c3c" },
                    new BallPosition { X = 295, Y = 95, Color = "#e74c3c", Opacity = 0.5 },
                    new BallPosition { X = 305, Y = 85, Color = "#e74c3c", Opacity = 0.5 },
                    new BallPosition { X = 295, Y = 105, Color = "#e74c3c", Opacity = 0.5 },
                    new BallPosition { X = 260, Y = 130, Color = "#e74c3c" },
                    new BallPosition { X = 340, Y = 100, Color = "#1a1a1a", Radius = 5 },
                    new BallPosition { X = 80, Y = 100, Color = "#ffffff", Radius = 4 }
                },
                Arrows = new() {
                    new ArrowPath { X1 = 80, Y1 = 100, X2 = 255, Y2 = 130, Color = "#4ecca3" }
                },
                Zones = new()
            }
        },
        new Drill
        {
            Id = "split-shot",
            Name = "Split Shot Development",
            Description = "Pot a red and split the pack. The key to big breaks.",
            Category = DrillCategory.BreakBuilding,
            Difficulty = DrillDifficulty.Pro,
            Instructions = "5 reds in a tight cluster. Separate loose red nearby. Pot the loose red while sending cue ball into the pack to split it open. Score based on: (1) red potted, (2) pack opened without leaving bad positions. Repeat 10 times.",
            TargetScore = 6,
            MaxScore = 10,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 290, Y = 95, Color = "#e74c3c" },
                    new BallPosition { X = 295, Y = 100, Color = "#e74c3c" },
                    new BallPosition { X = 290, Y = 105, Color = "#e74c3c" },
                    new BallPosition { X = 300, Y = 98, Color = "#e74c3c" },
                    new BallPosition { X = 300, Y = 108, Color = "#e74c3c" },
                    new BallPosition { X = 260, Y = 120, Color = "#e74c3c" },
                    new BallPosition { X = 230, Y = 110, Color = "#ffffff", Radius = 4 }
                },
                Arrows = new() {
                    new ArrowPath { X1 = 230, Y1 = 110, X2 = 255, Y2 = 120, Color = "#4ecca3" },
                    new ArrowPath { X1 = 240, Y1 = 105, X2 = 290, Y2 = 100, Color = "#ffcc00", Dashed = true }
                },
                Zones = new()
            }
        },
        new Drill
        {
            Id = "kick-recovery",
            Name = "Kick Recovery Drill",
            Description = "Practice recovering after bad contact. Happens 5-10 times per match.",
            Category = DrillCategory.Safety,
            Difficulty = DrillDifficulty.Advanced,
            Instructions = "Deliberately play a red thin/bad contact. Now recover the situation — either play safe or find a pot. In matches, kicks and bad contacts happen constantly. The best players don't panic. 10 different 'bad' positions to recover from.",
            TargetScore = 5,
            MaxScore = 10,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 180, Y = 60, Color = "#e74c3c" },
                    new BallPosition { X = 250, Y = 140, Color = "#ffffff", Radius = 4 }
                },
                Arrows = new() {
                    new ArrowPath { X1 = 250, Y1 = 140, X2 = 80, Y2 = 100, Color = "#ffcc00", Dashed = true }
                },
                Zones = new() { new TargetZone { X = 30, Y = 60, Width = 65, Height = 80, Color = "#4ecca3" } }
            }
        },
        new Drill
        {
            Id = "endurance-drill",
            Name = "Endurance Scoring (Match Fitness)",
            Description = "Score 500+ points in under 60 minutes. Builds match stamina.",
            Category = DrillCategory.BreakBuilding,
            Difficulty = DrillDifficulty.Pro,
            Instructions = "Re-rack after each clearance or breakdown. Total up ALL points scored in 60 minutes. Target: 500+ points. This builds the mental and physical endurance for best-of-19 or best-of-35 matches. Record total points and number of frames completed.",
            TargetScore = 500,
            MaxScore = 1000,
            TableSetup = new DrillTableSetup
            {
                Balls = GenerateTriangleBalls(),
                Arrows = new(),
                Zones = new()
            }
        },
        new Drill
        {
            Id = "tough-reds",
            Name = "Tough Red Recovery",
            Description = "Only difficult reds on the table. Practice scoring from bad positions.",
            Category = DrillCategory.Potting,
            Difficulty = DrillDifficulty.Pro,
            Instructions = "Place 6 reds in difficult positions: tight to cushions, awkward angles, partially blocked. No easy pots. Score as many as you can in one visit. At international level, you must score from ANY position.",
            TargetScore = 25,
            MaxScore = 50,
            TableSetup = new DrillTableSetup
            {
                Balls = new() {
                    new BallPosition { X = 360, Y = 28, Color = "#e74c3c" },
                    new BallPosition { X = 25, Y = 80, Color = "#e74c3c" },
                    new BallPosition { X = 200, Y = 175, Color = "#e74c3c" },
                    new BallPosition { X = 150, Y = 28, Color = "#e74c3c" },
                    new BallPosition { X = 375, Y = 130, Color = "#e74c3c" },
                    new BallPosition { X = 60, Y = 175, Color = "#e74c3c" },
                    new BallPosition { X = 200, Y = 100, Color = "#ffffff", Radius = 4 }
                },
                Arrows = new(),
                Zones = new()
            }
        }
    };

    private static List<BallPosition> GenerateLineUpBalls()
    {
        var balls = new List<BallPosition>();
        for (int i = 0; i < 15; i++)
        {
            balls.Add(new BallPosition { X = 340 - (i * 8), Y = 100, Color = "#e74c3c" });
        }
        balls.Add(new BallPosition { X = 200, Y = 70, Color = "#ffffff", Radius = 4 });
        return balls;
    }

    private static List<BallPosition> GenerateBaulkLineRedsBalls()
    {
        var balls = new List<BallPosition>();
        for (int i = 0; i < 10; i++)
        {
            balls.Add(new BallPosition { X = 100, Y = 30 + (i * 15), Color = "#e74c3c" });
        }
        return balls;
    }

    private static List<BallPosition> GenerateTriangleBalls()
    {
        var balls = new List<BallPosition>
        {
            // Triangle of reds behind pink
            new BallPosition { X = 300, Y = 100, Color = "#e74c3c" },
            new BallPosition { X = 308, Y = 95, Color = "#e74c3c" },
            new BallPosition { X = 308, Y = 105, Color = "#e74c3c" },
            new BallPosition { X = 316, Y = 90, Color = "#e74c3c" },
            new BallPosition { X = 316, Y = 100, Color = "#e74c3c" },
            new BallPosition { X = 316, Y = 110, Color = "#e74c3c" },
            new BallPosition { X = 324, Y = 85, Color = "#e74c3c" },
            new BallPosition { X = 324, Y = 95, Color = "#e74c3c" },
            new BallPosition { X = 324, Y = 105, Color = "#e74c3c" },
            new BallPosition { X = 324, Y = 115, Color = "#e74c3c" },
            new BallPosition { X = 332, Y = 80, Color = "#e74c3c" },
            new BallPosition { X = 332, Y = 90, Color = "#e74c3c" },
            new BallPosition { X = 332, Y = 100, Color = "#e74c3c" },
            new BallPosition { X = 332, Y = 110, Color = "#e74c3c" },
            new BallPosition { X = 332, Y = 120, Color = "#e74c3c" },
            // Colors on spots
            new BallPosition { X = 290, Y = 100, Color = "#e84393", Radius = 5 },
            new BallPosition { X = 340, Y = 100, Color = "#1a1a1a", Radius = 5 },
            new BallPosition { X = 200, Y = 100, Color = "#2980b9", Radius = 5 },
            // Cue ball in baulk
            new BallPosition { X = 80, Y = 100, Color = "#ffffff", Radius = 4 }
        };
        return balls;
    }
}
