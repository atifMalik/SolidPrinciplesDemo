using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LSP.After
{
    public abstract class Shape
    {
        public abstract int CalculateArea();
    }

    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Length { get; set; }

        public override int CalculateArea()
        {
            return Width * Length;
        }
    }

    public class Square : Shape
    {
        public int Dimension { get; set; }

        public override int CalculateArea()
        {
            return Dimension * Dimension;
        }
    }

    public static class Orchestrator_After
    {
        public static void RunExample()
        {
            // Create a Rectangle (Parent)
            Rectangle rectangle = new Rectangle();
            rectangle.Length = 5;
            rectangle.Width = 4;

            // Create a Square (Child)
            Square square = new Square();
            square.Dimension = 3;

            // If the following line compiles, we have acheived Syntactic equivalence
            //rectangle = square;       // This line does not compile
            Shape someShape = square;   // This line does, so Square is syntactical equivalent of Shape

            // Substitutability
            var afewShapes = new List<Shape>() { rectangle, square };

            foreach(var shape in afewShapes)
            {
                // Have acheived Semantic equivalence, also acheived polymorphism.
                Console.WriteLine("Area of {0} is {1}", shape.GetType().Name, shape.CalculateArea());
            }
        }
    }
}
