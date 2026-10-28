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
            //Sets up window size and window title
            Window.SetSize(800, 600);
            Window.SetTitle("Question Comprehension");
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>

        //sets up variables
        string correct_answer_shape = "placeholder";
        string correct_answer_number = "-1";
        bool question_answered = true;
        bool ui_visualized = false;
        bool disable_clicking = false;

        //selects the random question
        public void SelectQuestion()
        {
            //chooses a random question
            int question = Random.Integer(0, 2);

            //"what shape?" question
            if (question == 0)
            {
                Text.Draw("What shape is this?", 250, 185);


                //selects a random colour
                int random_colour = Random.Integer(0, 4);

                //sets the random colour
                if (random_colour == 0)
                {
                    //red
                    Draw.SetFillColor(235, 64, 52);
                }
                else if (random_colour == 1)
                {
                    //blue
                    Draw.SetFillColor(52, 137, 235);
                }
                else if (random_colour == 2)
                {
                    //green
                    Draw.SetFillColor(52, 235, 101);
                }
                else if (random_colour == 3)
                {
                    //pink
                    Draw.SetFillColor(235, 52, 229);
                }

                //selects a random shape
                int shape = Random.Integer(0, 4);
                //draws the shape
                if (shape == 0)
                {
                    //square
                    correct_answer_shape = "Square";

                    Draw.SetLineSize(0);
                    Draw.Square(345, 245, 130);
                    Text.Color = Color.White;
                    Text.Draw(Random.Integer(1,5).ToString(), 400, 300);

                }
                else if (shape == 1) 
                {
                    //circle
                    correct_answer_shape = "Circle";

                    Draw.SetLineSize(0);
                    Draw.Circle(400, 300, 70);
                    Text.Color = Color.White;
                    Text.Draw(Random.Integer(1, 5).ToString(), 390, 285);

                }
                else if (shape == 2)
                {
                    //triangle
                    correct_answer_shape = "Triangle";

                    Draw.SetLineSize(0);
                    Draw.Triangle(350, 350, 450, 350, 400, 220);
                    Text.Color = Color.White;
                    Text.Draw(Random.Integer(1, 5).ToString(), 390, 285);

                }
                else if (shape == 3)
                {
                    //diamond
                    correct_answer_shape = "Diamond";

                    Draw.SetLineSize(0);
                    Draw.Quad(400, 350, 400, 240, 450, 300, 350, 300);
                    Text.Color = Color.White;
                    Text.Draw(Random.Integer(1, 5).ToString(), 390, 285);

                }
            }
            //"what number?" question
            else if (question == 1)
            {
                Text.Draw("What number is this?", 250, 185);

                //chooses a random number from 1-4
                int random_number = Random.Integer(1, 5);

                //chooses a random colour
                int random_colour = Random.Integer(0, 4);

                if (random_colour == 0)
                {
                    //red
                    Draw.SetFillColor(235, 64, 52);
                }
                else if (random_colour == 1)
                {
                    //blue
                    Draw.SetFillColor(52, 137, 235);
                }
                else if (random_colour == 2)
                {
                    //green
                    Draw.SetFillColor(52, 235, 101);
                }
                else if (random_colour == 3)
                {
                    //pink
                    Draw.SetFillColor(235, 52, 229);
                }

                //chooses a random shape
                int shape = Random.Integer(0, 3);
                if (shape == 0)
                {
                    //square
                    Draw.SetLineSize(0);
                    Draw.Square(345, 245, 130);

                }
                else if (shape == 1)
                {
                    //circle
                    Draw.SetLineSize(0);
                    Draw.Circle(400, 300, 70);

                }
                else if (shape == 2)
                {
                    //triangle
                    Draw.SetLineSize(0);
                    Draw.Triangle(350, 350, 450, 350, 400, 220);

                }
                else if (shape == 3)
                {
                    //diamond
                    Draw.SetLineSize(0);
                    Draw.Quad(400, 350, 400, 240, 450, 300, 350, 300);

                }

                //sets text colour and draws text
                Text.Color = Color.White;
                Text.Draw(random_number.ToString(), 390, 285);
                correct_answer_number = random_number.ToString();

            }

        }

        //function used for drawing the shapes you click on
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

        //functions used when clicking on shapes
        public async Task SubmitAnswer(string answer)
        {
            if (correct_answer_shape != "placeholder")
            {
                //checks shape answers
                if (answer == correct_answer_shape)
                {
                    //displays "CORRECT!" text
                    Text.Color = Color.Green;
                    Text.Draw("CORRECT!", 325, 375);
                    disable_clicking = true;
                    await Task.Delay(4000); //this delays the script for 4 seconds
                    question_answered = true;
                    disable_clicking = false; //re-enables clicking the shapes
                    ui_visualized = false; //refreshes the interface
                
                }
                else
                {
                    //displays "INCORRECT!" text
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
                    //displays "CORRECT!" text
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
                    //displays "INCORRECT!" text
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

            //gets the mouse position on x and y axis
            float x = Input.GetMousePosition().X;
            float y = Input.GetMousePosition().Y;

            //checks if the ui has refreshed or not
            if (ui_visualized == false)
            {
                
                //resets answer variables to placeholder values
                correct_answer_number = "-1";
                correct_answer_shape = "placeholder";

                //redraws ui
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

            //checks if the user clicked
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
                }
            }

            //checks if a question was answered or not
            if (question_answered == true)
            {
                SelectQuestion();
                question_answered = false;
            }
        }
    }

}
