// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("One Maze at Fredrooms 🐻");
            Window.SetSize(1200, 800);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(222, 199, 99); //yellow backrooms background because yes 🤑🚢🎅🏾(we can change this later)

            Moist_Carpet();
        
        
        }


        public void Moist_Carpet() //this is a function that builds carpets, based on concept
        {
            Draw.SetFillColor(172, 149, 49); //brown moist carpet

            Draw.Rectangle(0, 0, 150, 150); //starting top-left square ⭐⭐⭐⭐🤩🤩🤩🤩
            Draw.Rectangle(50, 150, 200, 50); //path attached to bottom of that square
            Draw.Rectangle(250, 0, 50, 200); //build build build
            Draw.Rectangle(300, 0, 100, 50);
            Draw.Rectangle(350, 50, 50, 350); //big long path going down
            Draw.Rectangle(300, 250, 50, 50); //random square #1
            Draw.Rectangle(400, 150, 50, 50); //random square #2
            Draw.Rectangle(400, 300, 100, 50); //random 2x1
            Draw.Rectangle(450, 250, 50, 50); //random square #3 on that 2x1
            Draw.Rectangle(100, 400, 300, 50);
            Draw.Rectangle(50, 350, 50, 200); //random small nudge at the top
            Draw.Rectangle(100, 500, 50, 150);
            Draw.Rectangle(50, 650, 300, 50); //bottom-left-most part ⭐⭐⭐⭐🤩🤩🤩🤩
            Draw.Rectangle(350, 600, 50, 100);
            Draw.Rectangle(400, 600, 250, 50);
            Draw.Rectangle(600, 50, 50, 550); //REALLY big long path going up
        }
    }

}
