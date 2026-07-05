namespace SnookerTracker.Components;

public class BallPosition
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Color { get; set; } = "#e74c3c";
    public double Radius { get; set; } = 4;
    public string Label { get; set; } = "";
    public double Opacity { get; set; } = 1;
}

public class ArrowPath
{
    public double X1 { get; set; }
    public double Y1 { get; set; }
    public double X2 { get; set; }
    public double Y2 { get; set; }
    public string Color { get; set; } = "#ffffff";
    public double Width { get; set; } = 1;
    public bool Dashed { get; set; } = false;
}

public class TargetZone
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    public string Color { get; set; } = "#4ecca3";
}
