using System;
using ShapeWorld.Domain.Models;

namespace Shapeworld.Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
           PlayWithShape();
        }

        private static void PlayWithShape()
        {
          Rectangle someRectangle = new Rectangle();
          Square someSquare = new Square();

          Console.WriteLine(someSquare.NumberOfEdges);
          System.Console.WriteLine(someRectangle.NumberOfEdges);
        }


    }
}
