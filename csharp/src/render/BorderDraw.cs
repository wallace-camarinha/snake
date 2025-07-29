namespace src.render;

public class BorderDraw()
{
    private static int Width = Console.WindowWidth;
    private static int Height = Console.WindowWidth;

    public static void Write()
    {
        Console.Clear();
        // Draw top margin
        Console.SetCursorPosition(0, 0);
        Console.Write("╔");

        for (int i = 1; i < Width - 1; i++)
        {
            Console.Write("═");
        }
        Console.Write("╗");

        // Draw left and right margin
        for (int i = 1; i < Height - 1; i++)
        {
            Console.SetCursorPosition(0, i);
            Console.Write("║");
            Console.SetCursorPosition(Width - 1, i);
            Console.Write("║");
        }

        // Bottom border
        Console.SetCursorPosition(0, Height - 1);
        Console.Write("╚");
        for (int i = 1; i < Width - 1; i++)
        {
            Console.Write("═");
        }
        Console.Write("╝");

        // Reset cursor to a position below the border for user input
        Console.SetCursorPosition(0, Height);
    }
}
