using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Text;

namespace PacMan
{
    enum TileType
    {
        EMPTY,
        WALL,
        DOT
    }

    class GameLevelScreen : IGameState
    {
        public GameLevelScreen(Program program) : base(program)
        {

        }

        public override void Update()
        {
            
        }

        public override void Draw()
        {
            Raylib.DrawText("Game Level", 10, 10, 20, Color.WHITE);
        }
    }
}
