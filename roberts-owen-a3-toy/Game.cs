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

        string correct_answer_shape = "placeholder";
        int correct_answer_number = -1;
        bool question_answered = true;
        bool ui_visualized = false;

        public void SelectQuestion()
        {
            //int question = Random.Integer(0, 1);
            int question = 0;

            if (question == 0)
            {
                Text.Draw("What shape is this?", 250, 185);

                //int correct_element = Random.Integer(0, 1);
                int correct_element = 0;
                int random_colour = Random.Integer(0, 3);

                if (random_colour == 0)
                {
                    Draw.SetFillColor(235, 64, 52);
                }
                else if (random_colour == 1)
                {
                    Draw.SetFillColor(52, 137, 235);
                }
                else if (random_colour == 2)
                {
                    Draw.SetFillColor(52, 235, 101);
                }
                else if (random_colour == 3)
                {
                    Draw.SetFillColor(235, 52, 229);
                }

                if (correct_element == 0)
                {
                    int shape = Random.Integer(0, 3);
                    if (shape == 0)
                    {
                        correct_answer_shape = "Square";

                        Draw.SetLineSize(0);
                        Draw.Square(345, 245, 130);
                        Text.Color = Color.White;
                        Text.Draw(Random.Integer(1,4).ToString(), 400, 300);

                    }
                    else if (shape == 1) 
                    {
                        correct_answer_shape = "Circle";

                        Draw.SetLineSize(0);
                        Draw.Circle(400, 300, 70);
                        Text.Color = Color.White;
                        Text.Draw(Random.Integer(1, 4).ToString(), 390, 285);

                    }
                    else if (shape == 2)
                    {
                        correct_answer_shape = "Triangle";

                        Draw.SetLineSize(0);
                        Draw.Triangle(350, 350, 450, 350, 400, 220);
                        Text.Color = Color.White;
                        Text.Draw(Random.Integer(1, 4).ToString(), 390, 285);

                    }
                    else if (shape == 3)
                    {
                        correct_answer_shape = "Diamond";

                        Draw.SetLineSize(0);
                        Draw.Quad(400, 350, 400, 240, 450, 300, 350, 300);
                        Text.Color = Color.White;
                        Text.Draw(Random.Integer(1, 4).ToString(), 390, 285);

                    }
                }
            }

        }

        public void DrawShape(string shape)
        {
            if (shape == "Square")
            {
                Draw.SetLineSize(0);
                Draw.SetFillColor(235, 64, 52);
                Draw.Square(20, 20, 130);
                Text.Color = Color.White;
                Text.Draw("1", 78, 75);

            }
            else if (shape == "Circle")
            {
                Draw.SetLineSize(0);
                Draw.SetFillColor(52, 137, 235);
                Draw.Circle(710, 89, 70);
                Text.Color = Color.White;
                Text.Draw("2", 704, 75);
            }
            else if (shape == "Triangle")
            {
                Draw.SetLineSize(0);
                Draw.SetFillColor(52, 235, 101);
                Draw.Triangle(20, 580, 130, 580, 70, 450);
                Text.Color = Color.White;
                Text.Draw("3", 63, 505);
            }
            else if (shape == "Diamond")
            {
                Draw.SetLineSize(0);
                Draw.SetFillColor(235, 52, 229);
                Draw.Quad(720, 580, 720, 450, 660, 520, 780, 520);
                Text.Color = Color.White;
                Text.Draw("4", 712, 505);
            }
        }
        
        public void Update()
        {

            float x = Input.GetMousePosition().X;
            float y = Input.GetMousePosition().Y;

            //Console.WriteLine(x);
            //Console.WriteLine(y);

            if (ui_visualized == false)
            {
                Draw.SetLineSize(30);
                Draw.SetLineColor(51, 51, 51);
                Draw.Line(0, 0, 800, 0);
                Draw.Line(0, 600, 800, 600);
                Draw.Line(0, 0, 0, 600);
                Draw.Line(800, 0, 800, 600);

                Draw.SetLineSize(0);
                Draw.SetFillColor(51, 51, 51);
                Draw.Rectangle(240, 180, 340, 240);
                Text.Color = Color.White;
                Text.Draw("What shape is this?", 250, 185);

                DrawShape("Square");
                DrawShape("Circle");
                DrawShape("Triangle");
                DrawShape("Diamond");
                ui_visualized = true;
            }

            if (Input.IsMouseButtonPressed(MouseButton.Left))
            {
                //square
                if (x >= 20 && x < 150 && y >= 20 && y < 150)
                {
                    Console.WriteLine("red");
                }
                //circle
                if (x >= 640 && x < 780 && y >= 20 && y < 160)
                {
                    Console.WriteLine("blue");
                }
                //triangle
                if (x >= 20 && x < 130 && y >= 450 && y < 580)
                {
                    Console.WriteLine("green");
                }
                //diamond
                if (x >= 660 && x < 780 && y >= 450 && y < 580)
                {
                    Console.WriteLine("pink");
                }
            }

            if (question_answered == true)
            {
                SelectQuestion();
                question_answered = false;
            }
        }
    }

}
