namespace SnookerTracker.Services;

public static class DrillMetadata
{
    public static (string objective, string whyItHelps) GetMetadata(string drillId) => drillId switch
    {
        "line-up" => (
            "Build a repeatable, smooth cueing action. Develop consistency in straight potting under zero pressure.",
            "This is THE foundational drill every professional uses to warm up. It trains muscle memory for your delivery stroke. Stephen Hendry did this every single day. If you can pot 15/15, your technique is solid."
        ),
        "blue-to-pink" => (
            "Develop rhythm and confidence with repeated potting. Learn to reset mentally between shots.",
            "Repetition builds confidence. By potting the same ball 10 times, you groove your technique without the anxiety of different angles. Pros use this to find their timing at the start of sessions."
        ),
        "ten-reds-baulk" => (
            "Practice potting from varied angles with cue ball in hand. Build accuracy across the full width of the table.",
            "In matches, you rarely get the same angle twice. This drill forces you to adjust your aim for each shot, training your brain to calculate angles quickly — essential for centuries."
        ),
        "diagonal-pots" => (
            "Train your eyes and brain to judge diagonal angles accurately across the full table.",
            "Diagonal pots are the most common shots in professional snooker. If you can consistently pot diagonally into opposite corners, you'll never be short of scoring opportunities in a frame."
        ),
        "pressure-pots" => (
            "Simulate match pressure by demanding perfection. Train your mind to handle the consequences of missing.",
            "In a match, one miss costs you the frame. This drill teaches you to stay calm and execute under self-imposed pressure. The mental strength built here transfers directly to tournament play."
        ),
        "long-pot-reds" => (
            "Develop accuracy and confidence on full-length table pots. Build the shot that opens up scoring from anywhere.",
            "Long pots win frames at the professional level. When safety battles are tight, the player who can nail a long pot from baulk takes control. Judd Trump's career is built on this shot."
        ),
        "long-blue" => (
            "Master the most common long pot in professional snooker — blue into middle from baulk.",
            "This specific shot appears 3-5 times per frame in professional matches. It's the shot that breaks open safety exchanges. Pros hit this at 60-70% — that's your benchmark."
        ),
        "long-pot-angles" => (
            "Build confidence on angled long pots — the hardest shots in snooker but the most rewarding.",
            "Straight long pots are one thing, but angled ones separate club players from professionals. This drill trains your cut angle judgement at distance — the skill that makes crowds gasp."
        ),
        "long-pot-both-corners" => (
            "Develop versatility in long potting to both sides. Eliminate any left/right bias in your game.",
            "Most players have a preferred side for long pots. At international level, you can't afford a weakness. This drill ensures you're equally dangerous to both corners."
        ),
        "t-drill" => (
            "Master the red-black scoring pattern that builds centuries. Focus on getting position on black after each red.",
            "Stephen Hendry credits this single drill for his 775 career centuries. It teaches the positional play pattern that every big break follows: pot red, get on black, repeat. The T-Drill is non-negotiable for any aspiring professional."
        ),
        "color-circle" => (
            "Develop full-table positional awareness. Learn to navigate between all six color positions.",
            "Clearing the colors in order tests every aspect of position play — short and long range, crossing the table, and planning ahead. The blue-to-pink transition is where most breaks fall apart."
        ),
        "red-black-red" => (
            "Build the scoring pattern for centuries. Stay in the black-ball zone while clearing reds.",
            "Every century is built on red-black. This drill trains you to maintain position within a tight scoring zone. When you can score 50+ here consistently, match centuries become inevitable."
        ),
        "three-cushion-position" => (
            "Develop advanced cue ball control using multiple cushions. The hallmark of world-class players.",
            "When you can send the cue ball off three cushions to a precise position, you can score from ANY layout. This is what separates top 16 players from the rest — they're never stuck."
        ),
        "pink-black-rotation" => (
            "Learn to score with both pink and black as your main color. Doubles your scoring flexibility.",
            "O'Sullivan often switches between pink and black mid-break depending on where the reds are. This flexibility means you always have a scoring option. Most club players only use black."
        ),
        "stun-run-screw" => (
            "Master the three fundamental cue ball reactions. Build a complete positional vocabulary.",
            "Every positional shot in snooker is either a stun, follow, or screw (or combination). Once these three are automatic, you can place the cue ball anywhere on the table. This is cueing 101."
        ),
        "target-zone" => (
            "Develop precision in cue ball placement. Train yourself to land in a specific area, not just 'near' the next ball.",
            "Pros don't just 'get position' — they land on exact spots. This drill trains the precision that turns 40 breaks into centuries. Position to within a ball's width is the professional standard."
        ),
        "cushion-control" => (
            "Learn to judge angles off cushions accurately. Essential for getting position when direct paths are blocked.",
            "In real frames, cushion-first position is required on 30-40% of shots. If you can't judge the rebound angle, you'll run out of position constantly. This drill builds that judgement."
        ),
        "deep-screw" => (
            "Develop the power screw shot that brings the cue ball back the full length of the table.",
            "The deep screw is a power shot that requires perfect technique — low tip, smooth acceleration, follow-through. It's the shot that gets you from the black end back to baulk reds. Without it, your break-building ceiling is limited."
        ),
        "drag-shot" => (
            "Learn the controlled slow-roll follow that places the cue ball with millimetre precision.",
            "Mark Selby uses this shot constantly — a gentle follow with check side that drifts the cue ball into perfect position. It's the 'quiet' shot that pros use 40% of the time but amateurs never practice."
        ),
        "baulk-return" => (
            "Master the fundamental defensive shot — returning the cue ball to baulk from anywhere on the table.",
            "In professional snooker, 60% of safety shots involve returning to baulk. If you can reliably get the cue ball behind the baulk line while keeping the object ball safe, you'll win the tactical battle."
        ),
        "snooker-escape" => (
            "Practice escaping from snookers cleanly using cushion angles. Avoid giving away free points.",
            "You'll face 3-5 snookers per frame at top level. Each missed escape costs 4+ points. Clean escaping is the difference between giving away 20 points per match or zero. That's frames."
        ),
        "tight-safe" => (
            "Achieve both objectives simultaneously: tight object ball AND safe cue ball. The complete safety shot.",
            "At international level, just getting safe isn't enough — you need to leave your opponent with NO shot. This drill trains the dual-objective safety that Mark Selby has built his three world titles on."
        ),
        "safety-battle" => (
            "Build patience and consistency in sustained safety exchanges. Develop match temperament.",
            "Professional frames often feature 10-20 shot safety exchanges. The player who cracks first loses. This drill builds the mental endurance and technical consistency to outlast anyone in a tactical battle."
        ),
        "three-red-clearance" => (
            "Build confidence in completing small clearances perfectly. Foundation for larger breaks.",
            "Before you can make centuries, you need to consistently clear 3 reds with position. This drill teaches break-building fundamentals — shot selection, speed control, and forward planning — in a manageable package."
        ),
        "six-red-clearance" => (
            "Bridge the gap between practice breaks and match centuries. Develop stamina for medium-length breaks.",
            "A 6-red clearance with blacks = 75. If you can do this consistently, you're close to centuries. This is the drill that tells you when you're ready for the big time."
        ),
        "ten-red-clearance" => (
            "Near-match conditions for century building. Learn to maintain concentration through 20+ shots.",
            "A 10-red clearance = 107 maximum. This is your century training ground. The mental challenge of staying focused through 20+ pots is as important as the technical skill."
        ),
        "full-clearance" => (
            "Attempt the ultimate — a 147 maximum break. Train for perfection.",
            "Every session should include one 147 attempt. Not because you'll make it today, but because the PROCESS of attempting perfection raises your standard. The frame where you make 147 starts with 100 failed attempts."
        ),
        "century-under-pressure" => (
            "Train yourself to score 100+ with no second chances. Pure match simulation.",
            "In tournaments, you get ONE chance. This drill removes the safety net. The mental pressure of 'must score 100' is identical to a tournament frame — and that's exactly why you need to practice it."
        ),
        "color-clearance" => (
            "Perfect the end-of-frame clearance sequence. Yellow through to black in order.",
            "You'll face this scenario 3-4 times per match. One mistake on the colors and you lose the frame. Pros clear all 6 colors 95%+ of the time. This drill gets you to that level."
        ),
        "last-four" => (
            "Master the brown-blue-pink-black clearance. The most common frame-winning scenario.",
            "More frames are won or lost on the last four colors than any other phase. The cross-table position from brown to blue is where most players fail. Practice this until it's automatic."
        ),
        "colors-under-pressure" => (
            "Clear all colors 5 times in a row without failing. Build ice-cold nerve for frame deciders.",
            "This is pure mental training. Your technique for potting colors is probably fine — but can you do it when the frame depends on it? Five consecutive clearances builds bulletproof confidence."
        ),
        "frame-start" => (
            "Practice the critical first scoring visit of a frame. Set the tone for each new frame.",
            "The first visit after the break-off sets the frame's tempo. A 40-60 point first visit puts enormous pressure on your opponent. This drill simulates that exact scenario."
        ),
        "split-shot" => (
            "Learn to pot a red while simultaneously opening the pack. The key to building big breaks.",
            "You can't make centuries without splitting the pack. But splitting without control leads to chaos. This drill teaches controlled aggression — opening reds while maintaining position. Essential for 100+ breaks."
        ),
        "kick-recovery" => (
            "Practice recovering after bad contacts and kicks. Build adaptability under adversity.",
            "Kicks happen 5-10 times per match — often at crucial moments. The best players don't panic after a kick. They calmly assess the situation and find the best recovery option. This drill builds that composure."
        ),
        "endurance-drill" => (
            "Build physical and mental stamina for long matches. Score 500+ points in 60 minutes.",
            "Best-of-19 and best-of-35 matches demand incredible endurance. This drill simulates the sustained focus required. If you can maintain quality for 60 minutes non-stop, you can handle any match format."
        ),
        "tough-reds" => (
            "Learn to score from difficult positions. Eliminate scoring droughts caused by bad layouts.",
            "At international level, you can't wait for easy balls. You need to manufacture breaks from tough positions. This drill forces you to find pots where club players would play safe."
        ),
        _ => ("", "")
    };
}
