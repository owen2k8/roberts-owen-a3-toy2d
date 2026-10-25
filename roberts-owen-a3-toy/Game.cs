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
            Window.SetSize(800, 600);
            Window.ClearBackground(79, 79, 79);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {

            float x = Input.GetMousePosition().X;
            float y = Input.GetMousePosition().Y;

            Console.WriteLine(x);
            Console.WriteLine(y);

            Draw.SetLineSize(30);
            Draw.SetLineColor(51, 51, 51);
            Draw.Line(0, 0, 800, 0);
            Draw.Line(0, 600, 800, 600);
            Draw.Line(0, 0, 0, 600);
            Draw.Line(800, 0, 800, 600);
        }
    }

}
