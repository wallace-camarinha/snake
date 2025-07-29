using src.enums;
using src.models;

namespace scr.render;

public static class DirectionControl {
    public static Direction CurrentDirection = Direction.RIGHT;

    public static void ChangeDirections() {
        var keyInfo = Console.ReadKey(true);
        switch (keyInfo.Key) {
            case ConsoleKey.L or ConsoleKey.RightArrow:
                if (CurrentDirection.isVertical()) {
                    CurrentDirection = Direction.RIGHT;
                }
                break;
            case ConsoleKey.H or ConsoleKey.LeftArrow:
                if (CurrentDirection.isVertical()) {
                    CurrentDirection = Direction.LEFT;
                }
                break;
            case ConsoleKey.J or ConsoleKey.DownArrow:
                if (CurrentDirection.isHorizontal()) {
                    CurrentDirection = Direction.DOWN;
                }
                break;
            case ConsoleKey.K or ConsoleKey.UpArrow:
                if (CurrentDirection.isHorizontal()) {
                    CurrentDirection = Direction.UP;
                }
                break;
        }
    }

    public static void GoUp(Snake snake) {
        snake.ClearTail();

        if (snake.HeadPosition.y == 1) {
            snake.HeadPosition = (snake.HeadPosition.x, Console.WindowHeight - 1);
        }
        snake.HeadPosition = (snake.HeadPosition.x, snake.HeadPosition.y - 1);

        snake.MoveHead();
    }

    public static void GoDown(Snake snake) {
        snake.ClearTail();

        if (snake.HeadPosition.y == Console.WindowHeight - 2) {
            snake.HeadPosition = (snake.HeadPosition.x, 0);
        }
        snake.HeadPosition = (snake.HeadPosition.x, snake.HeadPosition.y + 1);

        snake.MoveHead();
    }

    public static void GoLeft(Snake snake) {
        snake.ClearTail();

        if (snake.HeadPosition.x == 1) {
            snake.HeadPosition = (Console.WindowWidth - 1, snake.HeadPosition.y);
        }
        snake.HeadPosition = (snake.HeadPosition.x - 1, snake.HeadPosition.y);

        snake.MoveHead();
    }

    public static void GoRight(Snake snake) {
        snake.ClearTail();

        if (snake.HeadPosition.x == Console.WindowWidth - 2) {
            snake.HeadPosition = (0, snake.HeadPosition.y);
        }
        snake.HeadPosition = (snake.HeadPosition.x + 1, snake.HeadPosition.y);

        snake.MoveHead();
    }
}
