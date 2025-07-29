namespace src.enums;

public enum Direction
{
    RIGHT,
    LEFT,
    DOWN,
    UP,
}

public static class DirectionExtensions
{
    public static bool isVertical(this Direction direction) =>
        direction.Equals(Direction.UP) || direction.Equals(Direction.DOWN);

    public static bool isHorizontal(this Direction direction) =>
        direction.Equals(Direction.LEFT) || direction.Equals(Direction.RIGHT);
}
