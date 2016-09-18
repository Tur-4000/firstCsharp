using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleTraining
{
    class Program
    {
        static void WriteT(int a, int b)
        {
            // Напишем букву Т
            Turtle.Angle = 0;
            Turtle.Move(a);
            Turtle.TurnLeft();
            Turtle.Move(b);
            Turtle.Angle = 90;
            Turtle.Move(b*2);
        }

        static void WriteO(int a, int b)
        {
            Turtle.Angle = 0;
            for (int i = 0; i < 2; i++)
            {
                Turtle.Move(a);
                Turtle.TurnRight();
                Turtle.Move(b);
                Turtle.TurnRight();
            }
        }

        static void WriteR(int a, int b)
        {
            Turtle.Angle = 0;
            Turtle.Move(a);
            for(int i=0; i < 3; i++)
            {
                Turtle.TurnRight();
                Turtle.Move(b);
            }

        }

        static void Main(string[] args)
        {
            Turtle.Speed = 8;
            Turtle.X = 200;
            Turtle.Y = 200;

            WriteT(120, 40);

            // Пишем букву О
            Turtle.X = 240;
            Turtle.Y = 200;

            WriteO(60, 40);

            // Пишем букву P
            Turtle.X = 300;
            Turtle.Y = 200;

            WriteR(60, 40);

            Turtle.X = 370;
            Turtle.Y = 200;

            WriteT(60, 20);

            //for (int i = 0; i < 6; i++)
            //{
            //    Turtle.Move(100);
            //    Turtle.Turn(60);
            //}

            //for (int i =0;  i < 8; i++)
            //{
            //    Turtle.Move(100);
            //    Turtle.Turn(45);
            //}

            //for (int i = 0; i < 4; i++)
            //{
            //    Turtle.Move(20);
            //    Turtle.TurnRight();
            //    Turtle.Move(20);
            //    Turtle.TurnRight();
            //    Turtle.Move(20);
            //    Turtle.TurnLeft();
            //    Turtle.Move(20);
            //    Turtle.TurnLeft();
            //}
        }
    }
}
