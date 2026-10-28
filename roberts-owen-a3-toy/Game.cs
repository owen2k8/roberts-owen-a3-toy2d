// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using System.Threading.Tasks;

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
            Window.SetTitle("Question Comprehension");
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>

        string correct_answer_shape = "placeholder";
        string correct_answer_number = "-1";
        bool question_answered = true;
        bool ui_visualized = false;
        bool disable_clicking = false;

        public void SelectQuestion()
        {
            int question = Random.Integer(0, 2);

            if (question == 0)
            {
                Text.Draw("What shape is this?", 250, 185);

                //int correct_element = Random.Integer(0, 1);
                //int correct_element = 0;
                int random_colour = Random.Integer(0, 4);

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

                //if (correct_element == 0)
                //{
                    int shape = Random.Integer(0, 4);
                    if (shape == 0)
                    {
                        correct_answer_shape = "Square";

                        Draw.SetLineSize(0);
                        Draw.Square(345, 245, 130);
                        Text.Color = Color.White;
                        Text.Draw(Random.Integer(1,5).ToString(), 400, 300);

                    }
                    else if (shape == 1) 
                    {
                        correct_answer_shape = "Circle";

                        Draw.SetLineSize(0);
                        Draw.Circle(400, 300, 70);
                        Text.Color = Color.White;
                        Text.Draw(Random.Integer(1, 5).ToString(), 390, 285);

                    }
                    else if (shape == 2)
                    {
                        correct_answer_shape = "Triangle";

                        Draw.SetLineSize(0);
                        Draw.Triangle(350, 350, 450, 350, 400, 220);
                        Text.Color = Color.White;
                        Text.Draw(Random.Integer(1, 5).ToString(), 390, 285);

                    }
                    else if (shape == 3)
                    {
                        correct_answer_shape = "Diamond";

                        Draw.SetLineSize(0);
                        Draw.Quad(400, 350, 400, 240, 450, 300, 350, 300);
                        Text.Color = Color.White;
                        Text.Draw(Random.Integer(1, 5).ToString(), 390, 285);

                    }
                //}
            }
            else if (question == 1)
            {
                Text.Draw("What number is this?", 250, 185);

                int random_number = Random.Integer(1, 5);

                int random_colour = Random.Integer(0, 4);

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

                int shape = Random.Integer(0, 3);
                if (shape == 0)
                {
                    Draw.SetLineSize(0);
                    Draw.Square(345, 245, 130);

                }
                else if (shape == 1)
                {

                    Draw.SetLineSize(0);
                    Draw.Circle(400, 300, 70);

                }
                else if (shape == 2)
                {

                    Draw.SetLineSize(0);
                    Draw.Triangle(350, 350, 450, 350, 400, 220);

                }
                else if (shape == 3)
                {

                    Draw.SetLineSize(0);
                    Draw.Quad(400, 350, 400, 240, 450, 300, 350, 300);

                }

                Text.Color = Color.White;
                Text.Draw(random_number.ToString(), 390, 285);
                correct_answer_number = random_number.ToString();

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

        public async Task SubmitAnswer(string answer)
        {
            if (correct_answer_shape != "placeholder")
            {
                if (answer == correct_answer_shape)
                {
                    Text.Color = Color.Green;
                    Text.Draw("CORRECT!", 325, 375);
                    disable_clicking = true;
                    await Task.Delay(4000);
                    question_answered = true;
                    disable_clicking = false;
                    ui_visualized = false;
                
                }
                else
                {
                    Text.Color = Color.Red;
                    Text.Draw("INCORRECT!", 325, 375);
                    disable_clicking = true;
                    await Task.Delay(4000);
                    disable_clicking = false;
                    question_answered = true;
                    ui_visualized = false;
                }
            }
            else if (correct_answer_number != "-1")
            {
                if (answer == correct_answer_number)
                {
                    Text.Color = Color.Green;
                    Text.Draw("CORRECT!", 325, 375);
                    disable_clicking = true;
                    await Task.Delay(4000);
                    disable_clicking = false;
                    question_answered = true;
                    ui_visualized = false;
                }
                else
                {
                    Text.Color = Color.Red;
                    Text.Draw("INCORRECT!", 325, 375);
                    disable_clicking = true;
                    await Task.Delay(4000);
                    disable_clicking = false;
                    question_answered = true;
                    ui_visualized = false;
                }
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
                
                correct_answer_number = "-1";
                correct_answer_shape = "placeholder";

                Draw.SetFillColor(79, 79, 79);
                Draw.Square(0, 0, 900);
                Draw.SetLineSize(30);
                Draw.SetLineColor(51, 51, 51);
                Draw.Line(0, 0, 800, 0);
                Draw.Line(0, 600, 800, 600);
                Draw.Line(0, 0, 0, 600);
                Draw.Line(800, 0, 800, 600);

                Draw.SetLineSize(0);
                Draw.SetFillColor(51, 51, 51);
                Draw.Rectangle(240, 180, 340, 240);
                //Text.Color = Color.White;
                //Text.Draw("What shape is this?", 250, 185);

                DrawShape("Square");
                DrawShape("Circle");
                DrawShape("Triangle");
                DrawShape("Diamond");
                ui_visualized = true;
            }

            if (Input.IsMouseButtonPressed(MouseButton.Left) && disable_clicking == false)
            {
                //square
                if (x >= 20 && x < 150 && y >= 20 && y < 150)
                {
                    
                    if (correct_answer_shape != "placeholder")
                    {
                        SubmitAnswer("Square");
                    }
                    else if (correct_answer_number != "-1")
                    {
                        SubmitAnswer("1");
                    }

                    Console.WriteLine("red");
                }
                //circle
                if (x >= 640 && x < 780 && y >= 20 && y < 160)
                {

                    if (correct_answer_shape != "placeholder")
                    {
                        SubmitAnswer("Circle");
                    }
                    else if (correct_answer_number != "-1")
                    {
                        SubmitAnswer("2");
                    }

                    Console.WriteLine("blue");
                }
                //triangle
                if (x >= 20 && x < 130 && y >= 450 && y < 580)
                {

                    if (correct_answer_shape != "placeholder")
                    {
                        SubmitAnswer("Triangle");
                    }
                    else if (correct_answer_number != "-1")
                    {
                        SubmitAnswer("3");
                    }

                    Console.WriteLine("green");
                }
                //diamond
                if (x >= 660 && x < 780 && y >= 450 && y < 580)
                {

                    if (correct_answer_shape != "placeholder")
                    {
                        SubmitAnswer("Diamond");
                    }
                    else if (correct_answer_number != "-1")
                    {
                        SubmitAnswer("4");
                    }

                    Console.WriteLine("pink");
                }
            }

            if (question_answered == true)
            {
                SelectQuestion();
                Console.WriteLine("selected");
                question_answered = false;
            }
        }
    }

}
