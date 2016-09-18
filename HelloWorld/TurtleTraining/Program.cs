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
        static void WriteT(int x, int y, int size)
        {
            // Напишем букву Т
            Turtle.X = x;
            Turtle.Y = y;

            Turtle.Angle = 0;
            Turtle.Move(size);
            Turtle.TurnLeft();
            Turtle.Move(size / 3);
            Turtle.Angle = 90;
            Turtle.Move(size / 3 *2);
        }

        static void WriteO(int x, int y, int size)
        {
            Turtle.X = x;
            Turtle.Y = y;
            int o = size - size / 3;
            Turtle.Angle = 0;
            for (int i = 0; i < 2; i++)
            {
                Turtle.Move(size);
                Turtle.TurnRight();
                Turtle.Move(o);
                Turtle.TurnRight();
            }
        }

        static void WriteR(int x, int y, int size)
        {
            Turtle.X = x;
            Turtle.Y = y;
            Turtle.Angle = 0;
            Turtle.Move(size);
            int o = size - size / 3;
            for (int i=0; i < 3; i++)
            {
                Turtle.TurnRight();
                Turtle.Move(o);
            }

        }

        static void Main(string[] args)
        {
            Turtle.Speed = 8;
            

            WriteT(200, 200, 120);

            WriteO(240, 200, 60);

            WriteR(300, 200, 60);

            WriteT(370, 200, 60);

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
