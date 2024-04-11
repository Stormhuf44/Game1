namespace libs;

public static class InputHandler
{

    public static void RegisterInputHandler()
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        GameObject focusedObject = GameEngine.GetFocusedObject();

        if (focusedObject != null)
        {
            // Handle keyboard input to move the player
            switch (keyInfo.Key)
            {
                case ConsoleKey.W:
                    focusedObject.Move(0, -1);
                    break;
                case ConsoleKey.S:
                    focusedObject.Move(0, 1);
                    break;
                case ConsoleKey.A:
                    focusedObject.Move(-1, 0);
                    break;
                case ConsoleKey.D:
                    focusedObject.Move(1, 0);
                    break;
                case ConsoleKey.E:
                    focusedObject.Move(1, -1);
                    break;
                case ConsoleKey.Q:
                    focusedObject.Move(-1, -1);
                    break;
                default:
                    break;
            }
        }
    }
}