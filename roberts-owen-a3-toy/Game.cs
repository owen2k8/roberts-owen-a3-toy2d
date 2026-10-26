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
        /// 


        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.ClearBackground(79, 79, 79);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        
        public void DrawShape(string shape)
        {
            if (shape == "Square")
            {
                Draw.SetLineSize(0);
                Draw.SetFillColor(235, 64, 52);
                Draw.Square(20, 20, 130);
            }
            else if (shape == "Circle")
            {
                Draw.SetLineSize(0);
                Draw.SetFillColor(52, 137, 235);
                Draw.Circle(700, 89, 70);
            }
            else if (shape == "Triangle")
            {
                Draw.SetLineSize(0);
                Draw.SetFillColor(52, 235, 101);
                Draw.Triangle(20, 580, 130, 580, 70, 450);
            }
            else if (shape == "Diamond")
            {
                Draw.SetLineSize(0);
                Draw.SetFillColor(235, 52, 229);
                Draw.Quad(720, 580, 720, 450, 660, 520, 780, 520);
            }
        }
        
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

            Draw.SetLineSize(0);
            Draw.SetFillColor(51, 51, 51);
            Draw.Rectangle(250, 180, 320, 240);
            Text.Draw("test", 400, 300);


            DrawShape("Square");
            DrawShape("Circle");
            DrawShape("Triangle");
            DrawShape("Diamond");
        }
    }

}
