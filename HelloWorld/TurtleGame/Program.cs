using System;
using Microsoft.SmallBasic.Library;

namespace TurtleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.Title = "Turtle Game";
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            Turtle.PenUp();

            GraphicsWindow.BrushColor = "Red";
            var eat = Shapes.AddEllipse(10, 10);
            Shapes.Move(eat, 200, 200);
            Random rnd = new Random();

            while (true)
            {                
                Turtle.Speed = 5;                
                Turtle.Move(1); // Шаг движения черепашки               
                // Находим координаты верхнего левого угла "еды"
                int eatX = Shapes.GetLeft(eat);
                int eatY = Shapes.GetTop(eat);
                // Сверяем координаты "еды" и черепашки и при совпадении 
                // премещаем "еду" случайным образом
                if(Turtle.X > eatX-1 && Turtle.X < eatX+11 && Turtle.Y > eatY-1 && Turtle.Y < eatY+11)
                {
                    Shapes.Move(eat, rnd.Next(1, GraphicsWindow.Width), 
                        rnd.Next(1, GraphicsWindow.Height));
                    Microsoft.SmallBasic.Library.Program.Delay(10);
                }
            }
        }

        private static void GraphicsWindow_KeyDown()
        {
            if(GraphicsWindow.LastKey == "Up")
            {
                Turtle.Angle = 0;
            } else if(GraphicsWindow.LastKey == "Right")
            {
                Turtle.Angle = 90;
            } else if(GraphicsWindow.LastKey == "Down")
            {
                Turtle.Angle = 180;
            } else if(GraphicsWindow.LastKey == "Left")
            {
                Turtle.Angle = 270;
            }
        }
    }
}
