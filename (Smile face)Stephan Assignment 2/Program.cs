namespace _Smile_face_Stephan_Assignment_2
{
    using System;
    using Raylib_cs;
    using System.Numerics;

    public class Program
    {
        // If you need variables in the Program class (outside functions), you must mark them as static
        static string title = "Game Title"; // Window title
        static int screenWidth = 800; // Screen width
        static int screenHeight = 600; // Screen height
        static int targetFps = 60; // Target frames-per-second

        static void Main()
        {
            // Create a window to draw to. The arguments define width and height
            Raylib.InitWindow(screenWidth, screenHeight, title);
            // Set the target frames-per-second (FPS)
            Raylib.SetTargetFPS(targetFps);
            // Setup your game. This is a function YOU define.
            Setup();
            // Loop so long as window should not close
            while (!Raylib.WindowShouldClose())
            {
                // Enable drawing to the canvas (window)
                Raylib.BeginDrawing();
                // Clear the canvas with one color
                Raylib.ClearBackground(Color.RayWhite);
                // Your game code here. This is a function YOU define.
                Update();
                // Stop drawing to the canvas, begin displaying the frame
                Raylib.EndDrawing();
            }
            // Close the window
            Raylib.CloseWindow();
        }

        static void Setup()
        {
            Vector2 mousePosition = Raylib.GetMousePosition();

            // Get mouse delta between frames
            Vector2 mouseDelta = Raylib.GetMouseDelta();

            // Check if a mouse button has been pressed once
            bool isMouseButtonPressed = Raylib.IsMouseButtonPressed(MouseButton.Left);

            // Check if a mouse button is being pressed
            bool isMouseButtonDown = Raylib.IsMouseButtonDown(MouseButton.Right);

            // Check if a mouse button has been released once
            bool isMouseButtonReleased = Raylib.IsMouseButtonReleased(MouseButton.Forward);

            // Check if a mouse button is NOT being pressed
            bool isMouseButtonUp = Raylib.IsMouseButtonUp(MouseButton.Back);

            // Get mouse wheel movement for X or Y, whichever is larger
            float mouseWheelMovement = Raylib.GetMouseWheelMove();
            // Your one-time setup code here
        }

        static void Update()
        {
            
            // Your game code run each frame here
        }
    }
}
