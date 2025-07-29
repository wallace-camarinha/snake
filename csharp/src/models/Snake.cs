using src.render;

namespace src.models;

public class Snake {
    public Snake(int x, int y, ConsoleColor color) {
        HeadPosition = (x, y);
        TailPosition = (x - 1, y);

        Body.Add(HeadPosition);
        Body.Add(TailPosition);

        Color = color;
    }

    public (int x, int y) HeadPosition { get; set; }
    public (int x, int y) TailPosition { get; set; }
    public ConsoleColor Color { get; set; }
    public List<(int x, int y)?> Body { get; private set; } = new();


    public void ClearTail() {
        Renderer.Draw(TailPosition.x, TailPosition.y, ConsoleColor.Black);
        Body.RemoveAt(Body.Count - 1);
        TailPosition = Body.Last() ?? throw new Exception("Unhandled");
    }

    public void MoveHead() {
        Body.Insert(0, HeadPosition);
        Renderer.Draw(HeadPosition.x, HeadPosition.y, Color);

        var bodyHit = Body.Skip(1).Contains(HeadPosition);
        if (bodyHit) {
            throw new Exception("You lost the game");
        }

    }
}
