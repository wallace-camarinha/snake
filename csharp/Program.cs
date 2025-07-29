using scr.render;
using src.enums;
using src.models;
using src.render;

Console.BackgroundColor = ConsoleColor.Black;
Console.CursorVisible = false;
Console.Clear();
BorderDraw.Write();

Bait? bait = null;
Snake snake = new(Console.WindowWidth / 2, Console.WindowHeight / 2, ConsoleColor.Yellow);
int speed = 0;

while (true) {
    if (bait == null) {
        bait = new Bait(ConsoleColor.Cyan);

        Renderer.Draw(bait.PositionX, bait.PositionY, bait.Color);
    }

    if (Console.KeyAvailable) {
        DirectionControl.ChangeDirections();
    }

    switch (DirectionControl.CurrentDirection) {
        case Direction.RIGHT:
            DirectionControl.GoRight(snake);
            break;
        case Direction.LEFT:
            DirectionControl.GoLeft(snake);
            break;
        case Direction.UP:
            DirectionControl.GoUp(snake);
            break;
        case Direction.DOWN:
            DirectionControl.GoDown(snake);
            break;
        default:
            throw new Exception("Direction not mapped by control");
    }

    if (snake.HeadPosition.x == bait.PositionX && snake.HeadPosition.y == bait.PositionY) {
        bait = null;
        snake.Body.Add((snake.TailPosition.x, snake.TailPosition.y));
    }

    if (snake.Body.Count > 5) {
        speed = 0;
    }

    Thread.Sleep(speed);

}
