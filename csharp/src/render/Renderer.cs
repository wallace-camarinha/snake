namespace src.render;

public static class Renderer {
    public static void Draw(int x, int y, ConsoleColor color) {
        var (originalX, originalY) = Console.GetCursorPosition();

        Console.SetCursorPosition(x, y);
        Console.BackgroundColor = color;
        SafePrint(" ");

        Console.BackgroundColor = ConsoleColor.Black;
        Console.SetCursorPosition(originalX, originalY);
    }

    public static void SafePrint(String input) {
        var (currentX, currentY) = Console.GetCursorPosition();

        if (currentY < 1 || currentY > Console.WindowHeight - 1) return;
        if (currentX < 1 || currentX >= Console.WindowWidth - 1) return;

        Console.Write(input);
        Console.SetCursorPosition(currentX, currentY);
    }
}
