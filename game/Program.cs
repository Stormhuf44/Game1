using libs;

class Program
{

    static void Main(string[] args)
    {
        //Setup
        Console.CursorVisible = false;
        GameEngine.Setup();

        // Main game loop
        while (true)
        {
            GameEngine.Render();

            // Handle keyboard input
            //ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            InputHandler.RegisterInputHandler();
            
        }
    }
}