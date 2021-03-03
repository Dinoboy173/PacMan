using System;
using Raylib_cs;

namespace PacMan
{
    class Program
    {
        int windowWidth = 800;
        int windowHeight = 450;
        string windowTitle = "Pacman";

        IGameState gameState;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.RunGame();
        }

        void RunGame()
        {
            Raylib.InitWindow(windowWidth, windowHeight, windowTitle);
            Raylib.SetTargetFPS(60);

            LoadGame();

            while (!Raylib.WindowShouldClose())
            {
                Update();
                Draw();
            }

            Raylib.CloseWindow();
        }

        void LoadGame()
        {
            gameState = new GameLevelScreen(this);
        }

        void Update()
        {
            if (gameState != null)
                gameState.Update();
        }

        void Draw()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLACK);

            if (gameState != null)
                gameState.Draw();

            Raylib.DrawFPS(10, windowHeight - 20);
            Raylib.EndDrawing();
        }
    }
}
