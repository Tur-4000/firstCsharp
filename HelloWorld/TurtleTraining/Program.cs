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
        static void Main(string[] args)
        {
            Turtle.Speed = 9;
            int i = 0;
            while (i < 6)
            {
                Turtle.Move(100);
                Turtle.Turn(60);
                i++;
            }

            i = 0;
            while (i < 4)
            {
                Turtle.Move(20);
                Turtle.TurnRight();
                Turtle.Move(20);
                Turtle.TurnRight();
                Turtle.Move(20);
                Turtle.TurnLeft();
                Turtle.Move(20);
                Turtle.TurnLeft();
                i++;
            }
        }
    }
}
