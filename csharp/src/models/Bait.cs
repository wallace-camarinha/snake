namespace src.models;

public class Bait {
    public Bait(ConsoleColor color) {
        var (leftBoundryX, rightBoundryX) = (1, Console.WindowWidth - 1);
        var (upperBoundryY, lowerBoundryY) = (1, Console.WindowHeight - 1);

        Color = color;

        var random = new Random();

        PositionX = random.Next(leftBoundryX, rightBoundryX);
        PositionY = random.Next(upperBoundryY, lowerBoundryY);
    }

    public ConsoleColor Color { get; set; }
    public int PositionX { get; set; }
    public int PositionY { get; set; }
}
